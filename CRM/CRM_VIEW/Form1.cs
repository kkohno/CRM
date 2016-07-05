using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_VIEW
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
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
			using (var f = new RegistrationForm()) f.ShowDialog();
		}
	}
}
