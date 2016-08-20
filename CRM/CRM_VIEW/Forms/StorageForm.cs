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
	public partial class StorageForm : Form
	{
		private bool needLoadAllGoods = true;
		public void LoadAllGoods()
		{
			if (!needLoadAllGoods) return;
			crmdbContextController1.Context.Goods.Load();
			needLoadAllGoods = false;
		}

		void SaveAll()
		{
			goodStorageItemBindingSource.EndEdit();
			Validate();
			crmdbContextController1.Context.SaveChanges();
		}

		public StorageForm()
		{
			InitializeComponent();
			crmdbContextController1.Context.GoodStorageItems.Load();
			goodStorageItemBindingSource.DataSource = crmdbContextController1.Context.GoodStorageItems.Local.ToBindingList();
		}

		private void goodStorageItemBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			goodStorageItemBindingSource.EndEdit();
		}

		private void сохранитьToolStripButton_Click(object sender, EventArgs e)
		{
			SaveAll();
        }

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			LoadAllGoods();		
			ViewUtils.ShowForm<GoodPickerForm>(this,
				form => {
					form.Context = crmdbContextController1.Context;
					form.CurrentGood = (goodStorageItemBindingSource.Current as GoodStorageItem)?.Good;
					form.ResetButton.Visible = false;
				},
				form => {
					if (form.DialogResult == DialogResult.OK) {
						var newItem = (goodStorageItemBindingSource.Current as GoodStorageItem);
						newItem.Good = form.CurrentGood;
						newItem.PurchasePrice = newItem.Good.PurchasePrice;
						goodStorageItemBindingSource.ResetBindings(true);
					}
					else goodStorageItemBindingSource.RemoveCurrent();
				});
		}
	}
}
