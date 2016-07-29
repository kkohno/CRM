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
using System.Data.Entity;

namespace CRM_VIEW.Views
{
	public partial class GoodView : UserControl
	{
		CRMDBContext context = new CRMDBContext();
		Good _good;
		public Good Good
		{
			get { return _good; }
			set
			{
				_good = value;
				if (_good == null) _good = new Good();
				textBox1.DataBindings.Clear();
				textBox1.DataBindings.Add("Text", _good, "Name");
				textBox2.DataBindings.Clear();
				textBox2.DataBindings.Add("Text", _good, "Comment");
				textBox3.DataBindings.Clear();
				textBox3.DataBindings.Add("Text", _good, "PurchasePrice");
				textBox4.DataBindings.Clear();
				textBox4.DataBindings.Add("Text", _good, "CurrentSellingPrice");
				referenceBindingSource.DataSource = _good.References;
				referenceBindingSource1.DataSource = _good.CompetitorRefs;

				comboBox1.SelectedItem = _good?.GoodType;
			}
		}

		public GoodView()
		{
			InitializeComponent();
			context.GoodTypes.Load();
			context.Providers.Load();
			goodTypeBindingSource.DataSource = context.GoodTypes.Local;
			providerBindingSource.DataSource = context.Providers.Local;
			Good = new Good();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var item = comboBox1.SelectedItem as GoodType;
			_good.GoodType = item;
        }
	}
}
