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
	[DefaultBindingProperty("GoodStorageItem")]
	[DefaultProperty("GoodStorageItem")]
	public partial class GoodStorageItemView : BaseCRMVIew
	{
		[Bindable(BindableSupport.Default)]
		[Browsable(false)]
		public GoodStorageItem GoodStorageItem
		{
			get
			{
				if (goodStorageItemBindingSource.DataSource == null) goodStorageItemBindingSource.DataSource = new GoodStorageItem();
				return goodStorageItemBindingSource.DataSource as GoodStorageItem;
			}
			set
			{
				if (value != null) goodStorageItemBindingSource.DataSource = value;
				else goodStorageItemBindingSource.DataSource = new GoodStorageItem();
            }
		}
        public GoodStorageItemView()
		{
			InitializeComponent();
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
