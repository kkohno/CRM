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
	public class Sale
	{
		public ulong? Id { get; set; }
		[Required]
		public Good Good { get; set; }
		public double SellingPrice { get; set; }
		public User User { get; set; }
		[Required]
		public DateTime? Date { get; set; }
	}
}
