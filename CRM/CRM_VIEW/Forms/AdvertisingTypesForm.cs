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

namespace CRM_VIEW.Forms
{
	public partial class AdvertisingTypesForm : Form
	{
		public AdvertisingTypesForm()
		{
			InitializeComponent();
			crmdbContextController1.Context.AdvertisingTypes.Load();
			advertisingTypeBindingSource.DataSource = crmdbContextController1.Context.AdvertisingTypes.Local.ToBindingList();
		}

		private void advertisingTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			advertisingTypeBindingSource.EndEdit();
			Validate();
			crmdbContextController1.Context.SaveChanges();
		}
	}
}
