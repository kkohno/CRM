using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_MODEL;

namespace CRM_VIEW.VisualModel
{
	public class SaleVisualItem
	{
		public Sale Sale { get; set; }
		public GoodStorageItem GoodStorageItem { get; set; }

		public Good Good
		{
			get
			{
				return Sale.Good;
			}
		}
		public double SellingPrice
		{
			get
			{
				return Sale.SellingPrice;
			}
			set
			{
				Sale.SellingPrice = value;
			}
		}
		public int Count
		{
			get
			{
				return Sale.Count;
			}
			set
			{
				if (value > MaxCount) {
					MessageBox.Show(null, "На складе не хватает товара. Всего на складе " + MaxCount + "шт.", "CRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				Sale.Count = value;
			}
		}
		public int MaxCount
		{
			get { return GoodStorageItem.Count; }
		}
		public double Sum
		{
			get
			{
				return SellingPrice * Count;
			}
		}
	}
}
