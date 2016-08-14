using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	/// <summary>
	/// описывает один платеж
	/// </summary>
	[Serializable]
	public class Payment
	{
		public long? Id { get; set; }
		/// <summary>
		/// персона, связанная с платежем
		/// </summary>
		[Required]
		public virtual Person Person { get; set; }
		/// <summary>
		/// сумма платежа
		/// </summary>
		public double? Summ { get; set; }
		/// <summary>
		/// тип платежа
		/// </summary>
		[Required]
		public virtual PaymentType PaymentType { get; set; }
		/// <summary>
		/// описание или комментарий к платежу
		/// </summary>
		public string Comment { get; set; }
		/// <summary>
		/// дата платежа
		/// </summary>
		[Required]
		public DateTime? Date { get; set; } = DateTime.Now;

		public override string ToString()
		{
			return Person + "(" + Summ + "р.) - " + PaymentType;
		}
	}
}
