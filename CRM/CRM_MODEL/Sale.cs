using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	/// <summary>
	/// продажа
	/// </summary>
	[Serializable]
	public class Sale
	{
		public long? Id { get; set; }
		[Required]
		public virtual Good Good { get; set; }
		public double? PurchasePrice { get; set; }
		public double? SellingPrice { get; set; }
		public int? Count { get; set; }
		public DateTime? Date { get; set; }
		public virtual Person Person { get; set; }

		public override string ToString()
		{
			return string.Format("{0} {1}шт. {2}р.", Good, Count, SellingPrice * Count);
		}

		#region Good
		/// <summary>
		/// название товара
		/// </summary>
		public string Name
		{
			get { return Good?.Name; }
		}
		/// <summary>
		/// тип товара
		/// </summary>
		public GoodType GoodType
		{
			get { return Good?.GoodType; }
		}
		/// <summary>
		/// поставщик
		/// </summary>
		public Provider Provider
		{
			get { return Good?.Provider; }
		}
		/// <summary>
		/// комментарий к товару
		/// </summary>
		public string GoodComment
		{
			get { return Good?.Comment; }
		}

		/// <summary>
		/// показывает прибыль с продажи одной штуки
		/// </summary>
		public double? Profit
		{
			get
			{
				if (SellingPrice == null) return null;
				return SellingPrice - (PurchasePrice ?? 0);
			}
		}
		/// <summary>
		/// показывает коэффициент накрутки
		/// </summary>
		public double? Koef
		{
			get
			{
				if (PurchasePrice == null || SellingPrice == null) return null;
				return SellingPrice / PurchasePrice;
			}
		}
		#endregion
	}
}
