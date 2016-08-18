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

namespace CRM_VIEW
{
	public partial class GoodTypesForm : Form
	{
		public CRMDBContext Context
		{
			get { return crmdbContextController1; }
		}
		void SaveChanges()
		{
			goodTypeBindingSource.EndEdit();
			this.Validate();
			Context.SaveChanges();
		}

		public GoodTypesForm()
		{
			InitializeComponent();
			Context.GoodTypes.Load();
			var list = Context.GoodTypes.Local.ToBindingList();
            goodTypeBindingSource.DataSource = list;
		}

		private void сохранитьToolStripButton_Click(object sender, EventArgs e)
		{
			ViewUtils.ExceptionWrapper(this, SaveChanges);
		}
	}
}
