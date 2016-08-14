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
	public partial class PaymentTypesForm : Form
	{
		public void SaveAll()
		{
			paymentTypeBindingSource.EndEdit();
			Validate();
			crmdbContextController1.Context.SaveChanges();
		}
		public PaymentTypesForm(User user)
		{
			InitializeComponent();
			crmdbContextController1.Context.PaymentTypes.Load();
			paymentTypeBindingSource.DataSource = crmdbContextController1.Context.PaymentTypes.Local.ToBindingList();
		}

		private void paymentTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ExceptionWrapper(this, SaveAll);
		}
	}
}
