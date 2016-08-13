using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	/// <summary>
	/// пользователь CRM
	/// </summary>
	[Serializable]
	public class User
	{
		public long? Id { get; set; }
		/// <summary>
		/// персона
		/// </summary>
		public virtual Person Person { get; set; } = new Person();
		/// <summary>
		/// бинарная маска прав пользователя
		/// </summary>
		public int Rights { get; set; }

		/// <summary>
		/// является ли пользователь администратором
		/// </summary>
		[NotMapped]
		[Display(Name ="Админ")]
		public bool IsAdmin
		{
			get
			{
				return (Rights & 1) == 1;
			}
			set
			{
				if (value) Rights |= 1;
				else Rights &= ~(Rights | 1);
			}
		}

		public override string ToString()
		{
			return Person.ToString();
		}
	}
}
