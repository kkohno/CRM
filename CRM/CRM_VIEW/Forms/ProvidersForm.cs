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
		CRMDBContext context = new CRMDBContext();
		void Save()
		{
			ViewUtils.ExceptionWrapper(this, () => {
				providerBindingSource.EndEdit();
				this.Validate();
				context.SaveChanges();
			});
		}

		public ProvidersForm(User user)
		{
			InitializeComponent();
			context.Providers.Load();
			providerBindingSource.DataSource = context.Providers.Local.ToBindingList();
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
