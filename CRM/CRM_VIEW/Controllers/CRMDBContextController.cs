using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM_MODEL;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Collections;

namespace CRM_VIEW
{
	public partial class CRMDBContextController : Component
	{
		public ContainerControl ContainerForm { get; set; }
		public override ISite Site
		{
			get { return base.Site; }
			set
			{
				base.Site = value;
				if (value == null) return;

				IDesignerHost host = value.GetService(typeof(IDesignerHost)) as IDesignerHost;
				if (host == null) return;

				IComponent componentHost = host.RootComponent;
				if (componentHost is ContainerControl) ContainerForm = componentHost as ContainerControl;				
			}
		}

		[Browsable(false)]
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
