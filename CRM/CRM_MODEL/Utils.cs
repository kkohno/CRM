using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	class Utils
	{
		public static string NoNameString { get { return "<Безимянный>"; } }
		/// <summary>
		/// производит сравнение по имени элемента
		/// </summary>
		/// <typeparam name="TypeName">тип элемента, для которого сделан метод сравнения</typeparam>
		/// <param name="item">элемент для сравнения</param>
		/// <param name="obj">с чем сравнить</param>
		/// <returns>то, что нужно для CompareTo</returns>
		public static int StringCompareTo<TypeName>(TypeName item, object obj) where TypeName: class
		{
			var b = obj as TypeName;
			if (b == null) return item.GetHashCode() - obj.GetHashCode();
			return item.ToString().CompareTo(b.ToString());
		}
	}
}
