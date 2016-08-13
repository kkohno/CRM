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
	[DefaultBindingProperty("Person")]
	[DefaultProperty("Person")]
	public partial class PersonView : UserControl
	{
		public Person Person
		{
			get
			{
				return personBindingSource.DataSource as Person;
			}
			set
			{
				if (value != null) personBindingSource.DataSource = value;
				else personBindingSource.DataSource = new Person();

			}
		}
		public PersonView()
		{
			InitializeComponent();
			Person = new Person();
		}
	}
}
