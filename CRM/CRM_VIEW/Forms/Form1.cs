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
			using (var f = new AuthorizationForm()) {
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
			ViewUtils.ShowForm<RegistrationForm>(this);
		}

		private void типыТоваровToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ShowForm<GoodTypesForm>(this);
		}

		private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ShowForm<ProvidersForm>(this);
		}

		private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ShowForm<GoodsForm>(this);
		}

		private void складToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ShowForm<StorageForm>(this);
		}

		private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ShowForm<SalesForm>(this);
		}

		private void оформитьПродажуToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ShowForm<SaleConstructorForm>(this);
		}

		private void подключениеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ShowForm<ConnectionSettingsForm>(this);
		}

		private void людиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ShowForm<PersonsForm>(this);
		}

		private void типыПлатежейToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ShowForm<PaymentTypesForm>(this);
		}

		private void платежиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewUtils.ShowForm<PaymentsForm>(this);
		}
	}
}
