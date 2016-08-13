using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	[Serializable]
	public class Person
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
