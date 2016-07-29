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
	public partial class CRMDBContextController : Component
	{
		private CRMDBContext _context;
		public CRM_MODEL.CRMDBContext Context
		{
			get
			{
				if (_context == null) _context = new CRMDBContext();
				return _context;
			}
			set { _context = value; }
		}

		public static implicit operator CRMDBContext(CRMDBContextController controller)
		{
			return controller.Context;
		}

		public static implicit operator CRMDBContextController(CRMDBContext context)
		{
            return new CRMDBContextController() { Context = context };
		}

		public CRMDBContextController()
		{
			InitializeComponent();
		}

		public CRMDBContextController(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
	}
}
