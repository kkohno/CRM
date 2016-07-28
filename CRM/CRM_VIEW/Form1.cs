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

namespace CRM_VIEW
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			/*providerView1.Provider = new CRM_MODEL.Provider {
				Name = "Имя",
				Comment = "Описание",
				Phones = {
					new CRM_MODEL.Phone {  PhoneNumber="123", Comment="abc"},
					new CRM_MODEL.Phone {  PhoneNumber="456", Comment="def"},
                    new CRM_MODEL.Phone {  PhoneNumber="789", Comment="hij"}
				},
				References = {
					new CRM_MODEL.Reference { ReferenceString="http://vk.com/im?sel=7559398", Comment="Описание 1" },
					new CRM_MODEL.Reference { ReferenceString="http://vk.com/firs_ss?z=photo29097574_419887290%2Falbum29097574_0%2Frev", Comment="Описание 2" },
					new CRM_MODEL.Reference { ReferenceString="http://vk.com/id92762086?z=photo92762086_414040155%2Falbum92762086_0%2Frev", Comment="Описание 3" },
				}
			};*/
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
	}
}
