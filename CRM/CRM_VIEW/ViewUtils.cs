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
		/// <summary>
		/// стандартный метод, возвращающий значение из источника данных
		/// </summary>
		/// <typeparam name="TypeName">тип элеметна источника данных</typeparam>
		/// <param name="bindingSource">источник данных, из которого извлекается значение</param>
		/// <returns>элемент из визуализатора. (Не может вернуть NULL)</returns>
		public static TypeName Get_Std_ViewMethod<TypeName>(BindingSource bindingSource) where TypeName : class, new()
		{
			if (bindingSource.DataSource == null) bindingSource.DataSource = new TypeName();
			return bindingSource.DataSource as TypeName;
		}
		/// <summary>
		/// стандартный метод установки значения на источник данных
		/// </summary>
		/// <typeparam name="TypeName">тип элеметна источника данных</typeparam>
		/// <param name="bindingSource">источник данных, на который задается значение</param>
		/// <param name="value">задаваемое значение на источник данных если null то задает новый пустой экземпляр</param>
		public static void Set_Std_ViewMethod<TypeName>(BindingSource bindingSource, TypeName value) where TypeName : new()
		{
			if (value == null) value = new TypeName();
			bindingSource.DataSource = value;
		}

		public delegate void SimpleMethod();
		public delegate void SimpleMethod<TypeName>(TypeName arg);

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
				MessageBox.Show(window, ex.Message, "SMM", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			return ExceptionWrapper(method, null);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="method"></param>
		/// <param name="caption"></param>
		/// <returns></returns>
		public static bool ExceptionWrapper(SimpleMethod method, string caption)
		{
#if DEBUG
			method();
#else
			try {
				method();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, string.IsNullOrEmpty(caption)? "SMM": caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return true;
			}
#endif
			return false;
		}
		/// <summary>
		/// создает и отображает окно
		/// </summary>
		/// <typeparam name="FormType">тип окна для отображения</typeparam>
		/// <param name="ownerWindow">окно, пораждающее текущее окно</param>
		public static DialogResult ShowForm<FormType>(IWin32Window ownerWindow) where FormType : Form, new()
		{
			DialogResult res = DialogResult.None;
			ExceptionWrapper(ownerWindow,
				() => {
					using (var f = new FormType()) res = f.ShowDialog();
				});
			return res;
		}
		/// <summary>
		/// создает и отображает окно
		/// </summary>
		/// <typeparam name="FormType">тип окна для отображения</typeparam>
		/// <param name="ownerWindow">окно, пораждающее текущее окно</param>
		/// <param name="beforeShow">делегат выполнения кода с формой перед ее отображением</param>
		public static DialogResult ShowForm<FormType>(IWin32Window ownerWindow, SimpleMethod<FormType> beforeShow) where FormType : Form, new()
		{
			DialogResult res = DialogResult.None; 
			ExceptionWrapper(ownerWindow,
				() => {
					using (var f = new FormType()) {
						if(beforeShow!=null) beforeShow(f);
						res = f.ShowDialog();
					}
				});
			return res;
		}
		/// <summary>
		/// создает и отображает окно
		/// </summary>
		/// <typeparam name="FormType">тип окна для отображения</typeparam>
		/// <param name="ownerWindow">окно, пораждающее текущее окно</param>
		/// <param name="beforeShow">делегат выполнения кода с формой перед ее отображением</param>
		/// <param name="afterClose">делегат выполнения кода с формой после ее закрытия</param>
		public static DialogResult ShowForm<FormType>(IWin32Window ownerWindow, SimpleMethod<FormType> beforeShow,SimpleMethod<FormType> afterClose) where FormType : Form, new()
		{
			DialogResult res = DialogResult.None;
			ExceptionWrapper(ownerWindow,
				() => {
					using (var f = new FormType()) {
						if(beforeShow!=null) beforeShow(f);
						res = f.ShowDialog();
						if(afterClose!=null) afterClose(f);
					}
				});
			return res;
		}
		/// <summary>
		/// создает и отображает окно
		/// </summary>
		/// <typeparam name="FormType">тип окна для отображения</typeparam>
		public static DialogResult ShowForm<FormType>() where FormType : Form, new()
		{
			return ShowForm<FormType>(null);
		}
	}
}
