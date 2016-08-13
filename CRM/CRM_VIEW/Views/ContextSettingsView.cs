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
		ContextSettings _contextSettings;
		public ContextSettingsView()
		{
			InitializeComponent();
			_contextSettings = ContextSettings.Instance.GetCopy();
            contextSettingsBindingSource.DataSource = _contextSettings;
        }
		public void SaveContext()
		{
			ContextSettings.Instance = _contextSettings;
            ContextSettings.Instance.Save();
        }
	}
}
