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

		/// производит выполнение делегата с выводом ошибки в случае исключения
		/// в режиме DEBUG не производит обработку ошибок
		/// </summary>
		/// <param name="window">ссылка на форму вызвавшую метод</param>
		/// <param name="method">метод для выполнения</param>
		/// <returns>было ли обработано исключение</returns>		
		public static bool ExceptionWrapper(IWin32Window window, SimpleMethod method)
		{
#if DEBUG
			method();
#else
			try {
				method();
			}
			catch (Exception ex) {
				MessageBox.Show(window, ex.Message, "CRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return true;
			}
#endif
			return false;
		}
		/// производит выполнение делегата с выводом ошибки в случае исключения
		/// в режиме DEBUG не производит обработку ошибок
		/// </summary>
		/// <param name="method">метод для выполнения</param>
		/// <returns>было ли обработано исключение</returns>
		public static bool ExceptionWrapper(SimpleMethod method)
		{
#if DEBUG
			method();
#else
			try {
				method();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, "CRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return true;
			}
#endif
			return false;
		}
	}
}
