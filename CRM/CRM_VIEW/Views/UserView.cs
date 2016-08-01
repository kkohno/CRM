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

namespace CRM_VIEW.Views
{
	[DefaultBindingProperty("User")]
	[DefaultProperty("User")]
	public partial class UserView : BaseCRMVIew
	{
		[Description("Задает или возвращает текущего пользователя")]
		[Browsable(false)]
		public User User
		{
			get
			{
				return userBindingSource.DataSource as User;			
			}
			set
			{
				if (value != null) userBindingSource.DataSource = value;
				else userBindingSource.DataSource = new User();
            }
		}

		public UserView()
		{
			InitializeComponent();
		}
	}
}
