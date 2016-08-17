using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_VIEW.Extensions
{
	public class ExtBindingList<DataType> : BindingList<DataType>
	{
		/// <summary>
		/// происходит перед удалением элемента из списка
		/// </summary>
		public event EventHandler<DataType> BeforeRemove;

		protected override void RemoveItem(int index)
		{
			if (BeforeRemove != null) BeforeRemove(this, this[index]);
			base.RemoveItem(index);
		}
	}
}
