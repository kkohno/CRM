using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_MODEL;

namespace CRM_VIEW.Forms
{
	public partial class GoodPickerForm : Form
	{
		/// <summary>
		/// текущий выбранный товар
		/// </summary>
		public Good CurrentGood
		{
			get
			{
				return goodsBrowser1.SelectedGood;
			}
			set
			{
				goodsBrowser1.SelectedGood = value;
			}
		}

		/// <summary>
		/// контекст бд
		/// </summary>
		[Description("Контекст БД")]
		public CRMDBContextController Context
		{
			get
			{
				return crmdbContextController1.Context;
			}
			set
			{
				crmdbContextController1.Context = value;
				goodsBrowser1.Context = value;
			}
		}

		void OK()
		{
			Close();
			DialogResult = DialogResult.OK;
		}

		public GoodPickerForm()
		{
			InitializeComponent();
		}

		public GoodPickerForm(CRMDBContextController Context)
		{
			InitializeComponent();
			this.Context = Context;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Close();
			DialogResult = DialogResult.Cancel;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			goodsBrowser1.RemoveCurrent();
			Close();
			DialogResult = DialogResult.OK;
		}

		private void goodsBrowser1_OnRowDoubleClick(object sender, EventArgs e)
		{
			OK();
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			OK();
		}
	}
}
