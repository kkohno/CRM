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
	public partial class PaymentsForm : Form
	{
		public void SaveAll()
		{
			paymentBindingSource.EndEdit();
			Validate();
			crmdbContextController1.Context.SaveChanges();
		}

		public PaymentsForm(User user)
		{
			InitializeComponent();
			crmdbContextController1.Context.Payments.Load();
			crmdbContextController1.Context.PaymentTypes.Load();
			crmdbContextController1.Context.Persons.Load();
			paymentBindingSource.DataSource = crmdbContextController1.Context.Payments.Local.ToBindingList();
			paymentTypeBindingSource.DataSource = crmdbContextController1.Context.PaymentTypes.Local.ToBindingList();
			personBindingSource.DataSource = crmdbContextController1.Context.Persons.Local.ToBindingList();
		}

		private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ExceptionWrapper(this, SaveAll);
		}
	}
}
