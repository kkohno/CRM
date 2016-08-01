using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_MODEL;

namespace CRM_VIEW
{
	[DefaultBindingProperty("User")]
	public partial class UserView : UserControl
	{
		[Description("Задает или возвращает текущего пользователя")]
		public User User
		{
			get
			{
				return new User {
					Name1 = Name1,
					Name2 = Name2,
					Name3 = Name3,
					Rights = Rights
				};			
			}
			set
			{
				Name1 = value.Name1;
				Name2 = value.Name2;
				Name3 = value.Name3;
				Rights = value.Rights;
			}
		}
		[Description("фамилия")]
		public string Name1
		{
			get
			{
				return textBox1.Text;
            }
			set
			{
				textBox1.Text = value;
			}
		}
		[Description("имя")]
		public string Name2
		{
			get
			{
				return textBox2.Text;
			}
			set
			{
				textBox2.Text = value;
			}
		}
		[Description("отчество")]
		public string Name3
		{
			get
			{
				return textBox3.Text;
			}
			set
			{
				textBox3.Text = value;
			}
		}
		[Description("права")]
		public int Rights
		{
			get
			{
				return checkBox1.Checked ? 1 : 0;
			}
			set
			{
				checkBox1.Checked = value == 1;
			}
		} 

		public UserView()
		{
			InitializeComponent();
		}
	}
}
