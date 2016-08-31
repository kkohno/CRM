using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	public partial class CRMDBContext
	{
		/// <summary>
		/// производит возврат товара
		/// выдает исключение в случае, если не удается произвести возврат
		/// </summary>
		/// <param name="sale">продажа, которую стоит отменить</param>
		public void Return(Sale sale)
		{
			if (sale == null) return;
			// производим поиск позиции на складе, которая явно удовлетворяет всем критериям
			var storagePositions = GoodStorageItems.Where(si => si.Good.Id == sale.Good.Id).ToList();
			if (storagePositions.Count > 1) {
				string positions = "";
				int i = 0;
				foreach (var position in storagePositions) {
					++i;
					positions += i + ")\t" + position + "\n";
					if (i >= 10) break;
				}
				throw new Exception("имеется несколько позиций на складе, куда можно вернуть товар - возврат автоматически произвести не удается. Попробуйте ручной вариант.\nКонфликтные позиции на складе:\n" + positions);
			}
			if (storagePositions.Count == 0) {
				GoodStorageItems.Attach(new GoodStorageItem { Good = sale.Good, Count = sale.Count, PurchasePrice = sale.Good.PurchasePrice });
				return;
			}
			if (storagePositions.Count == 1) {
				storagePositions[0].Count+=sale.Count;
				Sales.Remove(sale);
				return;
			}
			throw new Exception("при возврате товара что-то пошло не так");
		}
	}
}
