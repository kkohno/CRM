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
			goodStorageItemView1.Context = crmdbContextController1;
		}

		private void goodStorageItemBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			goodStorageItemBindingSource.EndEdit();
			goodStorageItemView1.GoodStorageItem = goodStorageItemBindingSource.Current as GoodStorageItem;
		}

		private void сохранитьToolStripButton_Click(object sender, EventArgs e)
		{
			SaveAll();
        }
	}
}
