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
		public void ReloadAll()
		{
			crmdbContextController1.Context.GoodStorageItems.Load();
			goodStorageItemBindingSource.DataSource = crmdbContextController1.Context.GoodStorageItems.Local.ToBindingList();
		}
		public StorageForm(User user)
		{
			InitializeComponent();
			ReloadAll();
        }

		private void goodStorageItemBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			goodStorageItemView1.GoodStorageItem = goodStorageItemBindingSource.Current as GoodStorageItem;
		}
	}
}
