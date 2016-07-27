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
	public partial class GoodTypesForm : Form
	{
		public GoodTypesForm(User user)
		{
			if (user == null) throw new Exception("Сначала нужно авторизоваться");
			InitializeComponent();
			crmController1.User = user;
		}
	}
}
