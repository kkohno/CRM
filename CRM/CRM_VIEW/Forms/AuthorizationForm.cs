using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_MODEL;

namespace CRM_VIEW
{
	public partial class AuthorizationForm : Form
	{
        public AuthorizationForm(User user)
		{
			InitializeComponent();
			crmController1.User = user;
        }
		public User User
		{
			get
			{
				return crmController1.User;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text)) {
				MessageBox.Show(this, "Не указан логин", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(textBox2.Text)) {
				MessageBox.Show(this, "Не указан пароль", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			crmController1.Authorization(textBox1.Text, textBox2.Text);
		}

		private void crmController1_OnAuthorized(object sender, User e)
		{		
			MessageBox.Show(this, "Авторизовались", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);		
            Close();
		}

		private void crmController1_OnBadLoginOrPass(object sender, LoginPass e)
		{
			MessageBox.Show(this, "Не верный логин или пароль", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
