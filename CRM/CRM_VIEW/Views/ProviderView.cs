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
	[DefaultBindingProperty("Provider")]
	[DefaultValue("Provider")]
	public partial class ProviderView : BaseCRMVIew
	{
		[Browsable(false)]
		public Provider Provider
		{
			get
			{
				return providerBindingSource.DataSource as Provider;
			}
			set
			{
				if (value != null) providerBindingSource.DataSource = value;
				else providerBindingSource.DataSource = new Provider();
				phoneBindingSource.DataSource = value.Phones;
				referenceBindingSource.DataSource = value.References;
			}
		}

		public ProviderView()
		{
			InitializeComponent();
			Provider = new Provider();
		}
	}
}
