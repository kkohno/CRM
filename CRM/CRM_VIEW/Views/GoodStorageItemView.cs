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
using CRM_VIEW.Forms;

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

		private void GoodStorageItemView_ReloadAll(object sender, EventArgs e)
		{
			Context.Goods.Load();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ViewUtils.ShowForm<GoodPickerForm>(this,
				form => {
					form.Context = Context;
					form.CurrentGood = GoodStorageItem.Good;
				},
				form => {
					if (form.DialogResult == DialogResult.OK) GoodStorageItem.Good = form.CurrentGood;
					goodStorageItemBindingSource.ResetBindings(true);
				});
		}
	}
}
