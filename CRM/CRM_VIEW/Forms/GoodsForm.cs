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
	public partial class GoodsForm : Form
	{
		object buf;
		Type bufType;
		void Save()
		{
			goodBindingSource.EndEdit();
			Validate();
			crmdbContextController1.Context.SaveChanges();
		}

		public GoodsForm()
		{
			InitializeComponent();
			crmdbContextController1.Context.Goods.Load();
			crmdbContextController1.Context.GoodTypes.Load();
			crmdbContextController1.Context.Providers.Load();
			goodTypeBindingSource.DataSource = crmdbContextController1.Context.GoodTypes.Local.ToBindingList();
			goodBindingSource.DataSource = crmdbContextController1.Context.Goods.Local.ToBindingList();
			providerBindingSource.DataSource = crmdbContextController1.Context.Providers.Local.ToBindingList();
		}

		private void сохранитьToolStripButton_Click(object sender, EventArgs e)
		{
			ViewUtils.ExceptionWrapper(this, Save);
		}

		private void goodBindingSource_CurrentItemChanged(object sender, EventArgs e)
		{
			goodListsView1.Good = goodBindingSource.Current as Good;
		}

		private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (dataGridView1.CurrentCell.IsInEditMode) return;
			if (e.KeyData == (Keys.Control | Keys.C)) {
				buf = dataGridView1.CurrentCell.Value;
				bufType = dataGridView1.CurrentCell.ValueType;
				return;
			}
			if(e.KeyData == (Keys.Control | Keys.V)) {
				if (bufType == dataGridView1.CurrentCell.ValueType)
					dataGridView1.CurrentCell.Value = buf;
				return;
			}
		}
	}
}
