using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_MODEL;

namespace CRM_VIEW.Views
{
	public partial class BaseCRMVIew : UserControl
	{
		/// <summary>
		/// контекст базы данных
		/// </summary>
		public CRMDBContext Context
		{
			get
			{
				return crmdbContextController;
			}
			set
			{
				crmdbContextController = value;
			}
		}

		public BaseCRMVIew()
		{
			InitializeComponent();
		}

		private void BaseCRMVIew_Load(object sender, EventArgs e)
		{
			if (ReloadAll != null) ReloadAll(this, e);
		}

		/// <summary>
		/// Вызывается при необходимости перезагрузки контента для визуализатора
		/// </summary>
		[Category("Данные")]
		[Description("Вызывается при необходимости перезагрузки контента для визуализатора")]
		public event EventHandler ReloadAll;
	}
}
