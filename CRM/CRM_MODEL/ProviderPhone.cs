using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	/// <summary>
	/// телефон поставщика
	/// </summary>
	public class ProviderPhone
	{
		public long? Id { get; set; }
		/// <summary>
		/// телефон
		/// </summary>
		[Required]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// комментарий
		/// </summary>
		public string Comment { get; set; }
	}
}
