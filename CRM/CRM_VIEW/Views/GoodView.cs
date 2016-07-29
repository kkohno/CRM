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
		public CRM_MODEL.CRMDBContext Context
		{
			get { return crmdbContextController1.Context; }
			set
			{
				crmdbContextController1.Context = value; ReloadData();
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
				goodBindingSource.DataSource = _good;
				referenceBindingSource.DataSource = _good.References;
				competitorBindingSource.DataSource = _good.CompetitorRefs;
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
	}
}
