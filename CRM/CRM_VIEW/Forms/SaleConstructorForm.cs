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

namespace CRM_VIEW.Forms
{
	public partial class SaleConstructorForm : Form
	{
		BindingList<GoodStorageItem> storage;
		BindingList<Sale> sales = new BindingList<Sale>();
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
		public SaleConstructorForm(User user)
		{
			InitializeComponent();
			saleBindingSource.DataSource = sales;
			ReloadAll();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void listBox1_DoubleClick(object sender, EventArgs e)
		{
			var gsi = storageBindingSource.Current as GoodStorageItem;
			if (gsi == null) return;
			sales.Add(new Sale { Good = gsi.Good, Date = DateTime.Now, Count = 1, SellingPrice = gsi.Good.CurrentSellingPrice });
			storage.Remove(gsi);
		}
	}
}
