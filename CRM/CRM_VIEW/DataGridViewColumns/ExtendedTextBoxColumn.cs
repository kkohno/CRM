using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_VIEW.DataGridViewColumns
{
	public class ExtendedTextBoxColumn : DataGridViewColumn
	{
		public ExtendedTextBoxColumn() :
			base(new ExtendedDataGridViewTextBoxCell())
		{
		}
		public override DataGridViewCell CellTemplate
		{
			get
			{
				return base.CellTemplate;
			}
			set
			{
				if (value != null &&
					!value.GetType().IsAssignableFrom(typeof(ExtendedDataGridViewTextBoxCell))) {
					throw new InvalidCastException("Must be a ExtendedDataGridViewTextBoxCell");
				}
				base.CellTemplate = value;
			}
		}
	}

	public class ExtendedDataGridViewTextBoxCell : DataGridViewTextBoxCell
	{
		protected override void OnKeyDown(KeyEventArgs e, int rowIndex)
		{
			switch (e.KeyCode) {
				case Keys.Delete:
				case Keys.Back:
					Value = null;
					return;
			}
			base.OnKeyDown(e, rowIndex);
		}
	}

}
