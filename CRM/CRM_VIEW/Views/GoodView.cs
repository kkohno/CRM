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
	[DefaultBindingProperty("Good")]
	[DefaultValue("Good")]
	public partial class GoodView : BaseCRMVIew
	{
		[ReadOnly(true)]
		[Browsable(false)]
		public Good Good
		{
			get { return goodBindingSource.DataSource as Good; }
			set
			{
				if (value != null) goodBindingSource.DataSource = value;
				else goodBindingSource.DataSource = new Good();
				referenceBindingSource.DataSource = value.References;
				competitorBindingSource.DataSource = value.CompetitorRefs;
			}
		}

		public GoodView()
		{
			InitializeComponent();
			Good = new Good();
		}

		private void GoodView_ReloadAll(object sender, EventArgs e)
		{
			Context.GoodTypes.Load();
			Context.Providers.Load();
			goodTypeBindingSource.DataSource = Context.GoodTypes.Local;
			providerBindingSource.DataSource = Context.Providers.Local;
		}
	}
}
