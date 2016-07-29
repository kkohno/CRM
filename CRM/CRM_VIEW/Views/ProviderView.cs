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
	public partial class ProviderView : UserControl
	{
		Provider _provider;
		public Provider Provider
		{
			get { return _provider; }
			set
			{
				_provider = value?? new Provider();
				textBox1.DataBindings.Clear();
				textBox1.DataBindings.Add("Text", _provider, "Name");
				textBox2.DataBindings.Clear();
				textBox2.DataBindings.Add("Text", _provider, "Comment");
				phoneBindingSource.DataSource = _provider.Phones;
				referenceBindingSource.DataSource = _provider.References;
			}
		}

		public ProviderView()
		{
			InitializeComponent();
			Provider = new Provider();
		}
	}
}
