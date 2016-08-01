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
	public partial class GoodStorageItemView : BaseCRMVIew
	{
		GoodStorageItem _goodStorageItem;
		[Bindable(BindableSupport.Default)]
		public GoodStorageItem GoodStorageItem
		{
			get
			{
				return _goodStorageItem;
			}
			set
			{
				_goodStorageItem = value;
				if (value == null) _goodStorageItem = new GoodStorageItem();
				comboBox1.SelectedItem = _goodStorageItem.Good;
				goodStorageItemBindingSource.DataSource = _goodStorageItem;
            }
		}
        public GoodStorageItemView()
		{
			InitializeComponent();
			GoodStorageItem = new GoodStorageItem();
		}

		private void comboBox1_TextChanged(object sender, EventArgs e)
		{
			comboBox1.Text = comboBox1.SelectedItem?.ToString();
		}

		private void GoodStorageItemView_ReloadAll(object sender, EventArgs e)
		{
			Context.Goods.Load();
			goodBindingSource.DataSource = Context.Goods.Local.ToList();
		}
	}
}
