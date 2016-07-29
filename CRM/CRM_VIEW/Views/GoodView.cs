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
		public CRM_MODEL.CRMDBContext Context
		{
			get { return context; }
			set
			{
				context = value;
				ReloadData();
            }
		}
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
				comboBox2.SelectedItem = _good?.Provider;
			}
		}

		void ReloadData()
		{
			Context.GoodTypes.Load();
			Context.Providers.Load();
			goodTypeBindingSource.DataSource = Context.GoodTypes.Local;
			providerBindingSource.DataSource = Context.Providers.Local;
		}
		public GoodView()
		{
			InitializeComponent();
			ReloadData();
			Good = new Good();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Good.GoodType = comboBox1.SelectedItem as GoodType;
        }

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			Good.Provider = comboBox2.SelectedItem as Provider;
		}
	}
}
