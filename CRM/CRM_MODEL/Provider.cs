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
		public ICollection<ProviderPhone> Phones { get; set; } = new List<ProviderPhone>();
		/// <summary>
		/// ссылки на поставщика
		/// </summary>
		public ICollection<ProviderReference> References { get; set; } = new List<ProviderReference>();
	}
}
