using System;
using CRM_MODEL;
using NUnit.Framework;
using System.Data;
using System.Data.SqlClient;

namespace CRM_TEST
{
	[TestFixture]
	public class ModelTest
	{
		/*[OneTimeSetUp]
		public void Init()
		{
			//if (inited) return;
			//inited = true;
			// дропаем БД
			using (var conn = new SqlConnection(@"Data Source=localhost;Integrated Security=True")) {//это строка соединения с БД
				var command = new SqlCommand("IF EXISTS (SELECT name FROM SYS.DATABASES WHERE [name] = 'SMMTest') DROP DATABASE [SMMTest];", conn);
				conn.Open();
				command.ExecuteNonQuery();
			}
		}*/
		[Test]
		public void RegisterUser()
		{
			using (var context = new CRMDBContext()) {
				var lp1 = new LoginPass {
					Login = "RegisterUser_login1",
					Pass = "RegisterUser_pass1",
					User = new User { Name1 = "Иванов", Name2 = "Иван", Name3 = "Иванович" }
				};
				var lp2 = new LoginPass {
					Login = "RegisterUser_login2",
					Pass = "RegisterUser_pass2",
					User = new User { Name1 = "Иванов", Name2 = "Иван", Name3 = "Иванович" }
				};
				context.LoginPasses.Add(lp1);
				context.LoginPasses.Add(lp2);
				context.SaveChanges();
				Assert.IsTrue(lp1.Id > 0);
			}
		}

		[Test]
		public void EntityModelTest()
		{
			using (var context = new CRMDBContext()) {
				var good = new Good {
					Name = "товар 1",
					GoodType = new GoodType { Name = "тип товара 1" },
					Reference = "ссылка на товар",
					CurrentSellingPrice = 123.45,
					CompetitorRefs = new GoodCompetitorRef[] {
						new GoodCompetitorRef { Reference="ссылка на такойже товар конкурента 1", Comment="коммент к ссылке конкурента 1" },
						new GoodCompetitorRef { Reference="ссылка на такойже товар конкурента 2", Comment="коммент к ссылке конкурента 2" },
						new GoodCompetitorRef { Reference="ссылка на такойже товар конкурента 3", Comment="коммент к ссылке конкурента 3" }
					},
					Provider = new Provider {
						Name = "имя провайдера",
						Comment = "коммент к провайдеру",
						Phones = new Phone[] {
							new Phone { PhoneNumber="номер телефона 1", Comment="комментарий 1" },
							new Phone { PhoneNumber="номер телефона 2", Comment="комментарий 2" },
							new Phone { PhoneNumber="номер телефона 3", Comment="комментарий 3" }
						},
						References = new Reference[] {
							new Reference { ReferenceString="ссылка 1", Comment= "коммент к ссылке 1" },
							new Reference { ReferenceString="ссылка 2", Comment= "коммент к ссылке 2" },
							new Reference { ReferenceString="ссылка 3", Comment= "коммент к ссылке 3" }
						}
					}
				};
				var goodStorageItem = new GoodStorageItem {
					Good = good,
					Count = 123,
					PurchasePrice = 123.32,
					ReceivingDate = DateTime.Today
				};
				var user = new User {
					Name1 = "AddGood фамилия",
					Name2 = "AddGood имя",
					Name3 = "AddGood отчество",
				};
				var sale = new Sale {
					Date = DateTime.Today,
					Good = good,
					SellingPrice = good.CurrentSellingPrice,
					User = user
				};
				var lp = new LoginPass {
					Login = "AddGood login",
					Pass = "AddGood pass",
					User = user
				};
                context.Goods.Add(good);
				context.GoodStorageItems.Add(goodStorageItem);
				context.Sales.Add(sale);
				context.LoginPasses.Add(lp);
				context.SaveChanges();
			}
		}
	}
}