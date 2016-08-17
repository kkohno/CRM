using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_MODEL;
using CRM_VIEW.Extensions;
using CRM_VIEW.VisualModel;

namespace CRM_VIEW.Forms
{
	public partial class SaleConstructorForm : Form
	{
		BindingList<GoodStorageItem> storage;											// все товары на складе
		List<GoodStorageItem> invStorageItems = new List<GoodStorageItem>();			// те товары склада, которые сейчас не видны
		ExtBindingList<SaleVisualItem> sales = new ExtBindingList<SaleVisualItem>();	// текущий намеченый список продажи
		CRMDBContext Context
		{
			get
			{
				return crmdbContextController1;
			}
		}

		void ReloadAll()
		{
			var req = from gsi in Context.GoodStorageItems
					  where gsi.Count > 0
					  orderby gsi.Good.Name
					  select gsi;
			storage = new BindingList<GoodStorageItem>(req.ToList());
			storageBindingSource.DataSource = storage;
        }
		void RecalculateAll()
		{
			double sum = 0;
			foreach (var sale in sales){
				sum += sale.Sum;
			}
			toolStripStatusLabel2.Text = sum.ToString();

			double cash = 0;
            try {
				cash = double.Parse(textBox1.Text);
				double delta = cash - sum;
				toolStripStatusLabel5.Text = delta >= 0 ? delta.ToString() : "клиенту не хватает " + (-delta).ToString();
			}
			catch(Exception) {
				toolStripStatusLabel5.Text = "-";
			}
        }

		public SaleConstructorForm(User user)
		{
			InitializeComponent();
			saleVisualItemBindingSource.DataSource = sales;
			ReloadAll();
			sales.BeforeRemove += Sales_BeforeRemove;
        }

		private void Sales_BeforeRemove(object sender, SaleVisualItem e)
		{
			var gsi = saleVisualItemBindingSource.Current as SaleVisualItem;
			if (gsi == null) return;
			int index = -1;
			for (int i = 1; i < storage.Count; ++i)
				if (string.Compare(gsi.Good.Name, storage[i].Good.Name, StringComparison.InvariantCulture) < 0) {
					index = i;
					break;
				}
			if (index == -1) index = storage.Count;
			storage.Insert(index, gsi.GoodStorageItem);
			RecalculateAll();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void listBox1_DoubleClick(object sender, EventArgs e)
		{
			var gsi = storageBindingSource.Current as GoodStorageItem;
			if (gsi == null) return;
			invStorageItems.Add(gsi);
			sales.Add(new SaleVisualItem {
				Sale = new Sale {
					Good = gsi.Good,
					Date = DateTime.Now,
					Count = 1,
					SellingPrice = gsi.Good.CurrentSellingPrice
				},
				GoodStorageItem = gsi
			});
			storage.Remove(gsi);
			RecalculateAll();
        }

		private void button1_Click(object sender, EventArgs e)
		{

			saleVisualItemBindingSource.EndEdit();
			// ограничитель
			if (sales.Count == 0) {
				Close();
				return;
			}
			// добавляем продажи
			foreach (var saleView in sales) Context.Sales.Add(saleView.Sale);

			// отнимаем склад
			foreach (var gsi in invStorageItems) {
				gsi.Count -= sales.First(x => x.Good == gsi.Good).Count;
				Context.GoodStorageItems.Attach(gsi);
				Context.Entry(gsi).State = EntityState.Modified;
			}

			// сохранение
			Context.SaveChanges();

			// закрываем форму
			Close();
		}

		private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			RecalculateAll();
        }

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{
			RecalculateAll();
        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			RecalculateAll();
        }

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar)) {
				//разделитель еще не стоит
				if (((e.KeyChar == '.') || (e.KeyChar == ',')) && (textBox1.Text.IndexOf(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0]) == -1))
					e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
				else if (!char.IsDigit(e.KeyChar))
					e.Handled = true;
			}
		}
	}
}
