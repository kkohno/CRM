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
    [DefaultProperty("Sale")]
    [DefaultBindingProperty("Sale")]
	public partial class SaleView : BaseCRMVIew
	{
		[Bindable(BindableSupport.Default)]
		[Browsable(false)]
		public Sale Sale
		{
			get
			{
				if (saleBindingSource.DataSource == null) saleBindingSource.DataSource = new Sale();
				return saleBindingSource.DataSource as Sale;
			}
			set
			{
				if (value != null) saleBindingSource.DataSource = value;
				else saleBindingSource.DataSource = new Sale();
			}
		}

		public SaleView()
		{
			InitializeComponent();
		}

		private void SaleView_ReloadAll(object sender, EventArgs e)
		{
			Context.Goods.Load();
			goodBindingSource.DataSource = Context.Goods.Local.ToBindingList();
		}
	}
}
