using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CRM_MODEL
{
	public partial class CRMDBContext: DbContext
	{
		#region пользователи
		/// <summary>
		/// все логины и пароли
		/// </summary>
		public DbSet<LoginPass> LoginPasses { get; set; }
		/// <summary>
		/// пользователи системы CRM
		/// </summary>
		public DbSet<User> Users { get; set; }
		/// <summary>
		/// персоны
		/// </summary>
		public DbSet<Person> Persons { get; set; }
		#endregion
		#region товары
		/// <summary>
		/// товары
		/// </summary>
		public DbSet<Good> Goods { get; set; }
		/// <summary>
		/// типы товаров
		/// </summary>
		public DbSet<GoodType> GoodTypes { get; set; }
		/// <summary>
		/// все имеющиеся в наличии товары
		/// </summary>
		public DbSet<GoodStorageItem> GoodStorageItems { get; set; }
		#endregion		
        #region поставщики
		/// <summary>
		/// поставщики
		/// </summary>
		public DbSet<Provider> Providers { get; set; }
		/// <summary>
		/// телефоны поставщиков
		/// </summary>
		public DbSet<Phone> ProviderPhones { get; set; }
		/// <summary>
		/// интернет ссылки на поставщиков
		/// </summary>
		public DbSet<Reference> ProviderReferences { get; set; }
		#endregion
		#region продажи
		/// <summary>
		/// все сделанные продажи
		/// </summary>
		public DbSet<Sale> Sales { get; set; }
		#endregion
		#region платежи
		/// <summary>
		/// типы платежей
		/// </summary>
		public DbSet<PaymentType> PaymentTypes { get; set; }
		/// <summary>
		/// платежи
		/// </summary>
		public DbSet<Payment> Payments { get; set; }
		#endregion
		#region реклама
		/// <summary>
		/// типы рекламы
		/// </summary>
		public DbSet<AdvertisingType> AdvertisingTypes { get; set; }
		/// <summary>
		/// рекламные акции
		/// </summary>
		public DbSet<Advertising> Advertisings { get; set; }
		#endregion

		public CRMDBContext() : base(ContextSettings.Instance.ToString())
		{
#if DEBUG
			Database.SetInitializer<CRMDBContext>(null);    // ДЛЯ КОРРЕКТНОЙ РАБОТЫ КОНСТРУКТОРА. ЭТО СПОРНОЕ РЕШЕНИЕ - СЛЕДУЕТ ИСПРАВИТЬ!!!!!!!!!!!
#endif
		}
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			//modelBuilder.Entity<LoginPass>().HasRequired(lp => lp.User).WithRequiredDependent(user => user.LoginPass);
		}
	}
}
