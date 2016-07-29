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
		CRMDBContext context = new CRMDBContext();
		bool saved = true;
		void SaveChanges()
		{
			goodTypeBindingSource.EndEdit();
			this.Validate();
			context.SaveChanges();
			saved = true;
		}

		public GoodTypesForm(User user)
		{
			//if (user == null) throw new Exception("Сначала нужно авторизоваться");
			InitializeComponent();
			crmController1.User = user;
			context.GoodTypes.Load();
			var list = context.GoodTypes.Local.ToBindingList();
			list.ListChanged += List_ListChanged;
            goodTypeBindingSource.DataSource = list;
		}

		private void List_ListChanged(object sender, ListChangedEventArgs e)
		{
			saved = false;
		}

		private void GoodTypesForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!saved && MessageBox.Show(this, "Сохранить изменения?", "CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				e.Cancel = ViewUtils.ExceptionWrapper(this, SaveChanges);
        }

		private void сохранитьToolStripButton_Click(object sender, EventArgs e)
		{
			ViewUtils.ExceptionWrapper(this, SaveChanges);
		}

		private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			saved = false;
		}
	}
}
