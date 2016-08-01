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
    [DefaultBindingProperty("NullableValue")]
    public partial class NullableDateTimePicker : DateTimePicker
	{
		[Bindable(BindableSupport.Default)]
		public DateTime? NullableValue
		{
			get
			{
				if (Checked) return Value;
				else return null;
			}
			set
			{
				if (value.HasValue) Value = value.Value;
				else Value = DateTime.Today;
				Checked = value.HasValue;
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
