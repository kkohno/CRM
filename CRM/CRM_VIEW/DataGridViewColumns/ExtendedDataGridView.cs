using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_VIEW.DataGridViewColumns
{
	public class ExtendedDataGridView : DataGridView
	{
		public ExtendedDataGridView()
		{
			this.Invalidated += ExtendedDataGridView_Invalidated;
		}

		private void ExtendedDataGridView_Invalidated(object sender, InvalidateEventArgs e)
		{
			if (!ReadOnlyColorEnabled) return;
			foreach (DataGridViewColumn column in Columns) {
				if (column.ReadOnly) column.DefaultCellStyle.BackColor = ReadonlyColor;
			}
		}

		[Category("Внешний вид")]
		[Description("Задает цвет столбцов, доступных только для чтения")]
		[DefaultValue(true)]
		public bool ReadOnlyColorEnabled { get; set; } = true;
		[Category("Внешний вид")]
		[Description("Задает цвет столбцов, доступных только для чтения")]
		public Color ReadonlyColor { get; set; } = Color.FromArgb(224, 224, 224);
	}
}
