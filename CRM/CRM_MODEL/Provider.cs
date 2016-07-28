using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	/// <summary>
	/// поставщик
	/// </summary>
	public class Provider
	{
		public long? Id { get; set; }
		/// <summary>
		/// название поставщика
		/// </summary>
		[Required]
		public string Name { get; set; }
		/// <summary>
		/// комментарий к поставщику
		/// </summary>
		public string Comment { get; set; }

		/// <summary>
		/// телефоны поставщика
		/// </summary>
		public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();
		/// <summary>
		/// ссылки на поставщика
		/// </summary>
		public virtual ICollection<Reference> References { get; set; } = new List<Reference>();

		public override string ToString()
		{
			return !string.IsNullOrEmpty(Name) ? Name : "<NONE>";
		}
	}
}
