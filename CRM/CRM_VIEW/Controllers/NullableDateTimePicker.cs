using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_VIEW.Controllers
{
	public partial class NullableDateTimePicker : DateTimePicker
	{
		[Bindable(BindableSupport.Default)]
		public DateTime? NullableValue
		{
			get
			{
				if (!Checked) return null;
				return Value;
			}
			set
			{
				Checked = value != null;
				if (value == null) Value = DateTime.Today;
				else Value = Value;				
			}
		}
		public NullableDateTimePicker()
		{
			InitializeComponent();
			ShowCheckBox = true;
		}

		public NullableDateTimePicker(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
	}
}
