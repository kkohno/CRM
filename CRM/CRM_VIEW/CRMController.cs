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
	public partial class CRMController : Component
	{
		CRMDBContext _dbContext;
		public CRMDBContext DBContext
		{
			get
			{
				return _dbContext;
			}
			set
			{
				_dbContext = value;
			}
		}
		User _user;
		public CRM_MODEL.User User
		{
			get { return _user; }
			private set
			{
				if (value == _user) return;
				var last = _user;
				_user = value;
				if (last != null && OnDeauthorized != null) OnDeauthorized(this, last);
				if (_user != null && OnAuthorized != null) OnAuthorized(this, _user);
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

		[Category("Авторизация")]
		[Description("Происходит когда был авторизован пользователь")]
		public event EventHandler<User> OnAuthorized;
		[Category("Авторизация")]
		[Description("Происходит пользователь стал не авторизован")]
		public event EventHandler<User> OnDeauthorized;
	}
}
