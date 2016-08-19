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
	public partial class GoodsBrowser : BaseCRMVIew
	{
		/// <summary>
		/// происходит, при двойном клике по строке
		/// </summary>
		[Description("происходит, при двойном клике по строке")]
		public event EventHandler OnRowDoubleClick;

		Good _currentGood;
		/// <summary>
		/// текущий выбранный товар
		/// </summary>
		[Browsable(false)]
		public Good SelectedGood
		{
			get
			{
				if (goodDataGridView.SelectedRows.Count == 0) return null;
				return goodBindingSource.Current as Good;
			}
			set
			{
				_currentGood = value;
			}
		} 

		/// <summary>
		/// сбрасывает текущее значение
		/// </summary>
		public void RemoveCurrent()
		{
			goodDataGridView.ClearSelection();
			_currentGood = null;
		}

		public GoodsBrowser()
		{
			InitializeComponent();	
		}

		private void GoodsBrowser_Load(object sender, EventArgs e)
		{
			if (ContextController.Owner || Context.Goods.Local.Count == 0)
				Context.Goods.Load();
			var list = Context.Goods.Local.ToBindingList();
			goodBindingSource.DataSource = list;
			if (_currentGood != null) goodBindingSource.Position = list.IndexOf(_currentGood);			
		}

		private void goodDataGridView_DoubleClick(object sender, EventArgs e)
		{
			if (OnRowDoubleClick != null) OnRowDoubleClick(this, e);
		}
	}
}
