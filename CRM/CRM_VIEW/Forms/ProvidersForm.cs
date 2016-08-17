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
	public partial class ProvidersForm : Form
	{
		public CRMDBContext Context
		{
			get
			{
				return crmdbContextController1;
			}
		}
		void Save()
		{
			ViewUtils.ExceptionWrapper(this, () => {
				providerBindingSource.EndEdit();
				this.Validate();
				Context.SaveChanges();
			});
		}

		public ProvidersForm(User user)
		{
			InitializeComponent();
			Context.Providers.Load();
			providerBindingSource.DataSource = Context.Providers.Local.ToBindingList();
		}

		private void providerBindingSource_CurrentItemChanged(object sender, EventArgs e)
		{
			providerView1.Provider = providerBindingSource.Current as Provider;
		}

		private void сохранитьToolStripButton_Click(object sender, EventArgs e)
		{
			Save();
        }
	}
}
