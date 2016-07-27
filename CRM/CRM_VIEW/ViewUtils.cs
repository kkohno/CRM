using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_VIEW
{
	public class ViewUtils
	{
		public delegate void SimpleMethod();

		public static void ExceptionWrapper(IWin32Window window, SimpleMethod method)
		{
			try {
				method();
			}
			catch(Exception ex) {
				MessageBox.Show(window, ex.Message, "CRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
