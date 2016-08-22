using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MODEL
{
	[Serializable]
	public class Advertising
	{
		public long? Id { get; set; }
		/// <summary>
		/// тип рекламы
		/// </summary>
		[DisplayName("Тип рекламы")]
		public virtual AdvertisingType AdvertisingType { get; set; }
		/// <summary>
		/// сумма выплаты по рекламе
		/// </summary>
		[DisplayName("Затрачено")]
		public double? Summ { get; set; }
		/// <summary>
		/// начало действия рекламы
		/// </summary>
		[DisplayName("Начало")]
		public DateTime? Start { get; set; }
		/// <summary>
		/// конец действия рекламы
		/// </summary>
		[DisplayName("Конец")]
		public DateTime? End { get; set; }

		#region тип платежа
		/// <summary>
		/// название типа рекламы
		/// </summary>
		[DisplayName("Название рекламы")]
		public string AdvertisingType_Name
		{
			get { return AdvertisingType?.Name; }
		}
		/// <summary>
		/// описание типа рекламы
		/// </summary>
		[DisplayName("Описание рекламы")]
		public string AdvertisingType_Comment
		{
			get { return AdvertisingType?.Comment; }
		}
		#endregion

		#region расчеты
		/// <summary>
		/// продолжительность по времени
		/// </summary>
		[DisplayName("Длительность")]
		public TimeSpan? Duration
		{
			get
			{
				if (!End.HasValue || !Start.HasValue) return null;
				return End - Start;
			}
		}
		#endregion
	}
}
