using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	public class GoodType
	{
		public long? Id { get; set; }
		[Required]
		public string Name { get; set; }
	}
}
