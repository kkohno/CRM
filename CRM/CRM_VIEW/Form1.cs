using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_VIEW.Forms;
using CRM_MODEL;
using System.Data.Entity;

namespace CRM_VIEW
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//goodStorageItemView1.GoodStorageItem.Good = new Good { Name = "ololo" };
            //goodStorageItemView1.GoodStorageItem.ReceivingDate = new DateTime(1990, 1, 1);
        }

		private void crmController1_OnAuthorized(object sender, CRM_MODEL.User e)
		{
			MessageBox.Show(this, "Авторизовались", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void crmController1_OnLogout(object sender, CRM_MODEL.User e)
		{
			MessageBox.Show(this, "Пользователь вышел из системы", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void входToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var f = new AuthorizationForm(crmController1.User)) {
				f.ShowDialog();
				crmController1.User = f.User;
			}
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			crmController1.LogOut();
		}

		private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ExceptionWrapper(this, () => { using (var f = new RegistrationForm()) f.ShowDialog(); });
		}

		private void типыТоваровToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ExceptionWrapper(this, () => { using (var f = new GoodTypesForm(crmController1.User)) f.ShowDialog(); });
		}

		private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ExceptionWrapper(this, () => { using (var f = new ProvidersForm(crmController1.User)) f.ShowDialog(); });
		}

		private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ExceptionWrapper(this, () => { using (var f = new GoodsForm(crmController1.User)) f.ShowDialog(); });
		}

		private void складToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ExceptionWrapper(this, () => { using (var f = new StorageForm(crmController1.User)) f.ShowDialog(); });
		}
	}
}
