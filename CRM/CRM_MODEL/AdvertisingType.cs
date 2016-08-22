using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	/// <summary>
	/// описывает тип рекламы
	/// </summary>
	[Serializable]
	public class AdvertisingType
	{
		public long? Id { get; set; }
		/// <summary>
		/// название рекламы
		/// </summary>
		[DisplayName("Название")]
		public string Name { get; set; }
		/// <summary>
		/// описание рекламы
		/// </summary>
		[DisplayName("Описание")]
		public string Comment { get; set; }
		/// <summary>
		/// оценка для типа рекламы
		/// </summary>
		[DisplayName("Оценка")]
		public double? Rating { get; set; }
		/// <summary>
		/// ссылка на тип рекламы
		/// </summary>
		[DisplayName("Ссылка")]
		public string Reference { get; set; }

		public override string ToString()
		{
			return string.IsNullOrEmpty(Name) ? Utils.NoNameString : Name;
		}
	}
}
