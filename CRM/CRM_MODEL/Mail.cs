using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	[Serializable]
	public class Mail
	{
		public long? ID { get; set; }
		[Required]
		public string MailString { get; set; }
		public string Comment { get; set; }

		public override string ToString()
		{
			return string.IsNullOrEmpty(MailString) ? Utils.NoNameString : MailString;
		}
	}
}
