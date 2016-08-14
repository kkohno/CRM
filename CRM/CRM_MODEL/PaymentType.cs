using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	/// <summary>
	/// описывает тип платежа
	/// </summary>
	[Serializable]
	public class PaymentType
	{
		public long? Id { get; set; }
		/// <summary>
		/// название типа платежа
		/// </summary>
		[Required]
		public string Name { get; set; }
		/// <summary>
		/// описание платежа или комментарий к нему
		/// </summary>
		public string Comment { get; set; }

		/// <summary>
		/// возвращает ссылку на текущий объект
		/// </summary>
		public PaymentType Instance
		{
			get
			{
				return this;
			}
		}

		public override string ToString()
		{
			return string.IsNullOrEmpty(Name) ? Utils.NoNameString : Name;
		}
	}
}
