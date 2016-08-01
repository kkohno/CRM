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
		public SalesForm(User user)
		{
			InitializeComponent();
			crmdbContextController1.Context.Sales.Load();
			saleBindingSource.DataSource = crmdbContextController1.Context.Sales.Local.ToBindingList();
			saleView1.Context = crmdbContextController1;
		}

		private void saleBindingSource_CurrentItemChanged(object sender, EventArgs e)
		{
			saleBindingSource.EndEdit();
			saleView1.Sale = saleBindingSource.Current as Sale;
		}

		private void saleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			saleBindingSource.EndEdit();
			Validate();
			crmdbContextController1.Context.SaveChanges();
		}
	}
}
