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
	public partial class SalesForm : Form
	{
		object buf;
		Type bufType;
		private bool needLoadAllGoods = true;
		public void LoadAllGoods()
		{
			if (!needLoadAllGoods) return;
			crmdbContextController1.Context.Goods.Load();
			needLoadAllGoods = false;
		}

		public SalesForm()
		{
			InitializeComponent();
			crmdbContextController1.Context.Sales.Load();
			crmdbContextController1.Context.Persons.Load();
			saleBindingSource.DataSource = crmdbContextController1.Context.Sales.Local.ToBindingList();
			personsBindingSource.DataSource = crmdbContextController1.Context.Persons.Local.ToBindingList();
		}

		private void saleBindingSource_CurrentItemChanged(object sender, EventArgs e)
		{
			saleBindingSource.EndEdit();
		}

		private void saleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			saleBindingSource.EndEdit();
			Validate();
			crmdbContextController1.Context.SaveChanges();
		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			LoadAllGoods();
			ViewUtils.ShowForm<GoodPickerForm>(this,
				form => {
					form.Context = crmdbContextController1.Context;
					form.ResetButton.Visible = false;
				},
				form => {
					if (form.DialogResult == DialogResult.OK) {
						var newItem = (saleBindingSource.Current as Sale);
						newItem.Good = form.CurrentGood;
						newItem.SellingPrice = newItem.Good.CurrentSellingPrice;
						newItem.PurchasePrice = newItem.Good.PurchasePrice;
						newItem.Count = 1;
						newItem.Date = DateTime.Now;
						saleBindingSource.ResetBindings(true);
					}
					else saleBindingSource.RemoveCurrent();
				});
		}
	}
}
