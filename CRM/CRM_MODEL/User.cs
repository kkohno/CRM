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
		/// фамилия
		/// </summary>
		[Required]
		public string Name1 { get; set; }
		/// <summary>
		/// имя
		/// </summary>
		public string Name2 { get; set; }
		/// <summary>
		/// отчество
		/// </summary>
		public string Name3 { get; set; }
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
			
		/// <summary>
		/// возвращает короткое ФИО
		/// </summary>
		public string ShortFIO
		{
			get
			{
				string fio = Name1;
				if (!string.IsNullOrEmpty(Name2)) fio += " " + Name2[0] + ".";
				if (!string.IsNullOrEmpty(Name3)) fio += " " + Name3[0] + ".";
				return fio;
			}
		}

		public override string ToString()
		{
			return ShortFIO;
		}
	}
}
