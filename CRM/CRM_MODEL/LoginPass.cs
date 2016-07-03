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
		public ulong? Id { get; set; }
		[Required]
		[Index(IsUnique = true)]
		public string Login { get; set; }
		[Required]
		public string Pass { get; set; }
		[Required]
		[Index(IsUnique = true)]
		public User User { get; set; }
	}
}
