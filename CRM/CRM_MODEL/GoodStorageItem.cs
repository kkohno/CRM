using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	/// <summary>
	/// описывает товар на складе
	/// </summary>
	public class GoodStorageItem
	{
		public long? Id { get; set; }
		/// <summary>
		/// товар на складе
		/// </summary>
		[Required]
		public virtual Good Good { get; set; }
		/// <summary>
		/// количество товара на складе
		/// </summary>
		public int Count { get; set; }
		/// <summary>
		/// почем была куплена единица товара
		/// </summary>
		public double? PurchasePrice { get; set; }
		/// <summary>
		/// дата приема товара
		/// </summary>
		public DateTime? ReceivingDate { get; set; }
		/// <summary>
		/// срок годности
		/// </summary>
		public DateTime? ShelfLife { get; set; }
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

		#region методы доступа
		/// <summary>
		/// название товара
		/// </summary>
		public string Name
		{
			get
			{
				return Good?.Name;
			}
		}
		/// <summary>
		/// тип товара
		/// </summary>
		public virtual GoodType GoodType
		{
			get
			{
				return Good?.GoodType;
			}
		}
		/// <summary>
		/// поставщик
		/// </summary>
		public virtual Provider Provider
		{
			get
			{
				return Good?.Provider;
			}
		}
		/// <summary>
		/// текущая розничная цена
		/// </summary>
		public double? CurrentSellingPrice
		{
			get
			{
				return Good?.CurrentSellingPrice;
			}
		}
		/// <summary>
		/// комментарий к товару
		/// </summary>
		public string Comment
		{
			get
			{
				return Good?.Comment; 
			}
		}
		#endregion

		public override string ToString()
		{
			return (Good?.ToString() ?? "<Товар не указан>") + " (" + Count + " шт.)";
		}
	}
}
