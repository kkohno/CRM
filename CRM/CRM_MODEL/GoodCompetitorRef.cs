using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	/// <summary>
	/// ссылка на товар у конкурента
	/// </summary>
	public class GoodCompetitorRef
	{
		public ulong? Id { get; set; }
		[Required]
		public string Reference { get; set; }
		public string Comment { get; set; }
	}
}
