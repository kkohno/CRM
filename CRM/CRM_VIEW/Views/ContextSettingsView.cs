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
	public partial class ContextSettingsView : UserControl
	{
		public ContextSettingsView()
		{
			InitializeComponent();
			contextSettingsBindingSource.DataSource = ContextSettings.Instance;
        }
		public void SaveContext()
		{
			ContextSettings.Instance.Save();
        }
	}
}
