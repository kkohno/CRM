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
	public class Good
	{
		public long? Id { get; set; }
		/// <summary>
		/// название товара
		/// </summary>
		[Required]
		public string Name { get; set; }
		/// <summary>
		/// ссылка на товар
		/// </summary>
		public string Reference { get; set; }
		/// <summary>
		/// тип товара
		/// </summary>
		public virtual GoodType GoodType { get; set; }
		/// <summary>
		/// поставщик
		/// </summary>
		public virtual Provider Provider { get; set; }
		/// <summary>
		/// текущая розничная цена
		/// </summary>
		public double CurrentSellingPrice { get; set; }

		/// <summary>
		/// ссылки на теже товары у конкурентов
		/// </summary>
		public virtual ICollection<GoodCompetitorRef> CompetitorRefs { get; set; } = new List<GoodCompetitorRef>();
	}
}
