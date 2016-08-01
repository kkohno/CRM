using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM_MODEL;

namespace CRM_VIEW
{
	/// <summary>
	/// логика работы с БД от имени пользователя
	/// </summary>
	public partial class CRMController : Component
	{
		User _user;
		public CRM_MODEL.User User
		{
			get { return _user; }
			set
			{
				_user = value;
			}
		}
		public bool Authorized
		{
			get
			{
				return User != null;
			}
		}

		public CRMController()
		{
			InitializeComponent();
		}
		public CRMController(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
		public void CopyState(CRMController other)
		{
			_user = other._user;
		}

		public void Authorization(string login, string pass)
		{
			if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass)) return;

			var loginPass = new LoginPass { Login = login, Pass = pass };
			using (var context = new CRMDBContext()) {
				var query = from lp in context.LoginPasses
							where lp.Login == loginPass.Login && lp.Pass == loginPass.Pass
							select lp;
				var reslp = query.FirstOrDefault();
				if (reslp == null) {
					if (OnBadLoginOrPass != null) {
						loginPass.Pass = "";
						OnBadLoginOrPass(this, loginPass);
					}
                    return;
				}
				User = reslp.User;
				if (User == null) throw new Exception("Не указан пользователь в БД для логина или пароля");
				if (OnAuthorized != null) OnAuthorized(this, User);
			}
		}
		public bool Registration(LoginPass loginPass, User user)
		{
			if (string.IsNullOrEmpty(loginPass.Login)) throw new Exception("Не удалось зарегестрировать пользователя - не указан логин");
			if (string.IsNullOrEmpty(loginPass.Pass)) throw new Exception("Не удалось зарегестрировать пользователя - не указан пароль");
			if (user == null) throw new Exception("Не удалось зарегестрировать пользователя - не указан пользователь");
			if (string.IsNullOrEmpty(user.Name1)) throw new Exception("Не удалось зарегестрировать пользователя - не указана фамилия");
			if (string.IsNullOrEmpty(user.Name2)) throw new Exception("Не удалось зарегестрировать пользователя - не указана имя");
			if (string.IsNullOrEmpty(user.Name3)) throw new Exception("Не удалось зарегестрировать пользователя - не указана отчество");

			using (var context = new CRMDBContext()) {
				// проверка логина
				var query = from lp in context.LoginPasses
							where lp.Login == loginPass.Login
							select lp;
				var reslp = query.FirstOrDefault();
				if (reslp != null) {
					if (OnLoginExists != null) OnLoginExists(this, loginPass);
                    return false;
				}
				// вставляем логинпароль
				loginPass.User = user;
				context.LoginPasses.Add(loginPass);
				context.SaveChanges();
				return true;
			}
		}
		public void LogOut()
		{
			if (!Authorized) return;
			var last = User;
			_user = null;
			if (OnLogout != null) OnLogout(this, last);
        }

		[Category("Авторизация")]
		[Description("авторизовался пользователь")]
		public event EventHandler<User> OnAuthorized;
		[Category("Авторизация")]
		[Description("пользователь стал не авторизован")]
		public event EventHandler<User> OnLogout;
		[Category("Авторизация")]
		[Description("если логин или пароль не совпадают при авторизации")]
		public event EventHandler<LoginPass> OnBadLoginOrPass;

		[Category("Регистрация")]
		[Description("если логин уже существует")]
		public event EventHandler<LoginPass> OnLoginExists;
	}
}
