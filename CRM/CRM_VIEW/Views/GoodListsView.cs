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

namespace CRM_VIEW.Views
{
	[DefaultBindingProperty("Good")]
	[DefaultValue("Good")]
	public partial class GoodListsView : UserControl
	{
		Good _good;
		[ReadOnly(true)]
		[Browsable(false)]
		public Good Good
		{
			get
			{
				return _good;
			}
			set
			{
				_good = value;
				referenceBindingSource.DataSource = value?.References;
				competitorBindingSource.DataSource = value?.CompetitorRefs;
			}
		}

		public GoodListsView()
		{
			InitializeComponent();
		}
	}
}
