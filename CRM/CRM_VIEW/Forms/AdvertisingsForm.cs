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
using CRM_VIEW.Formatters;

namespace CRM_VIEW.Forms
{
	public partial class AdvertisingsForm : Form
	{
		public AdvertisingsForm()
		{
			InitializeComponent();
			dataGridViewTextBoxColumn8.DefaultCellStyle.FormatProvider = new TimeSpanFormatter();
			dataGridViewTextBoxColumn8.DefaultCellStyle.Format = "dd";
			crmdbContextController1.Context.Advertisings.Load();
			crmdbContextController1.Context.AdvertisingTypes.Load();
			advertisingBindingSource.DataSource = crmdbContextController1.Context.Advertisings.Local.ToBindingList();
			advertisingTypeBindingSource.DataSource = crmdbContextController1.Context.AdvertisingTypes.Local.ToBindingList();
		}

		private void advertisingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			advertisingBindingSource.EndEdit();
			Validate();
			crmdbContextController1.Context.SaveChanges();
		}
	}
}
