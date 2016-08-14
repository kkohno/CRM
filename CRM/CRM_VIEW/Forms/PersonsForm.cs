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
	public partial class PersonsForm : Form
	{
		void SaveAll()
		{
			personBindingSource.EndEdit();
			Validate();
			crmdbContextController1.Context.SaveChanges();
		}

		public PersonsForm(User user)
		{
			InitializeComponent();
			crmdbContextController1.Context.Persons.Load();
			personBindingSource.DataSource = crmdbContextController1.Context.Persons.Local.ToBindingList();
		}

		private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ExceptionWrapper(this, SaveAll);
        }
	}
}
