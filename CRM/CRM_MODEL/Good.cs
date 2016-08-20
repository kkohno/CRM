using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	/// <summary>
	/// товар
	/// </summary>
	[Serializable]
	public class Good
	{
		public long? Id { get; set; }
		/// <summary>
		/// название товара
		/// </summary>
		[Required]
		public string Name { get; set; }
		/// <summary>
		/// тип товара
		/// </summary>
		public virtual GoodType GoodType { get; set; }
		/// <summary>
		/// поставщик
		/// </summary>
		public virtual Provider Provider { get; set; }
		/// <summary>
		/// цена закупки товара
		/// </summary>
		public double? PurchasePrice { get; set; }
		/// <summary>
		/// текущая розничная цена
		/// </summary>
		public double? CurrentSellingPrice { get; set; }
		/// <summary>
		/// комментарий к товару
		/// </summary>
		public string Comment { get; set; }

		/// <summary>
		/// показывает прибыль с продажи одной штуки
		/// </summary>
		public double? Profit
		{
			get
			{
				if (CurrentSellingPrice == null) return null;
				return CurrentSellingPrice - (PurchasePrice ?? 0);
			}
		}
		/// <summary>
		/// показывает коэффициент накрутки
		/// </summary>
		public double? Koef
		{
			get
			{
				if (PurchasePrice == null || CurrentSellingPrice == null) return null;
				return CurrentSellingPrice / PurchasePrice;
			}
		}

		/// <summary>
		/// дополнительные ссылки на товар
		/// </summary>
		public virtual ICollection<Reference> References { get; set; } = new List<Reference>();
		/// <summary>
		/// ссылки на теже товары у конкурентов
		/// </summary>
		public virtual ICollection<Reference> CompetitorRefs { get; set; } = new List<Reference>();

		public override string ToString()
		{
			return !string.IsNullOrEmpty(Name) ? Name: Utils.NoNameString;
		}
	}
}
