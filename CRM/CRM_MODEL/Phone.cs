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
	[Serializable]
	public class Phone
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

		public override string ToString()
		{
			string res = string.IsNullOrEmpty(PhoneNumber) ? PhoneNumber : "<NONE>";
			if (!string.IsNullOrEmpty(Comment)) res += " - " + Comment;
            return res;
		}
	}
}
