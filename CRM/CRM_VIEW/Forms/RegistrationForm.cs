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

namespace CRM_VIEW.Forms
{
	public partial class RegistrationForm : Form
	{
		public RegistrationForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(textBox2.Text!=textBox3.Text) {
				MessageBox.Show(this, "Пароли не совпадают", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textBox2.Text = "";
				textBox3.Text = "";
				return;
			}
			try
			{
				crmController1.Registration(new LoginPass {
					Login = textBox1.Text,
					Pass = textBox2.Text
				},
				userView1.User);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
            }
			Close();
		}
	}
}
