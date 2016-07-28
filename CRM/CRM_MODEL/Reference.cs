using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	/// <summary>
	/// ссылка на поставщика в интернете
	/// </summary>
	public class Reference
	{
		public long? Id { get; set; }
		/// <summary>
		/// ссылка
		/// </summary>
		[Required]
		public string ReferenceString { get; set; }
		/// <summary>
		/// комментарий
		/// </summary>
		public string Comment { get; set; }
	}
}
