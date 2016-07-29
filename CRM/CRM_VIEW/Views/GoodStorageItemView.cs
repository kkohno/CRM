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
	public partial class GoodStorageItemView : UserControl
	{
		public CRMDBContext Context
		{
			get { return crmdbContextController1.Context; }
			set { crmdbContextController1.Context = value; }
		}
		GoodStorageItem _goodStorageItem;
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
		public void ReloadAll()
		{
			Context.Goods.Load();
			goodBindingSource.DataSource = Context.Goods.Local.ToList();
        }
        public GoodStorageItemView()
		{
			InitializeComponent();
			ReloadAll();
			GoodStorageItem = new GoodStorageItem();
		}
	}
}
