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
		public uint Count { get; set; }
		/// <summary>
		/// почем была куплена единица товара
		/// </summary>
		public double PurchasePrice { get; set; }
		/// <summary>
		/// дата приема товара
		/// </summary>
		public DateTime? ReceivingDate { get; set; }
		/// <summary>
		/// срок годности
		/// </summary>
		public DateTime? ShelfLife { get; set; }

		public override string ToString()
		{
			return (Good?.ToString() ?? "<Товар не указан>") + " (" + Count + " шт.)";
		}
	}
}
