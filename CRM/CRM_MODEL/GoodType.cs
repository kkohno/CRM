﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	[Serializable]
	public class GoodType: IComparable
	{
		public long? Id { get; set; }
		[Required]
		public string Name { get; set; }

		public int CompareTo(object obj)
		{
			return Utils.StringCompareTo(this, obj);
		}

		public override string ToString()
		{
			return !string.IsNullOrEmpty(Name) ? Name : Utils.NoNameString;
		}
	}
}
