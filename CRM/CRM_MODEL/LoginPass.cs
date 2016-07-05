using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	public class LoginPass
	{
		public long? Id { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[StringLength(50)]
		public string Login { get; set; }
		[Required]
		public string Pass { get; set; }
		[Required]
		public virtual User User { get; set; }
	}
}
