﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_MODEL;

namespace CRM_VIEW.Forms
{
	public partial class GoodsForm : Form
	{
		CRMDBContext context = new CRMDBContext();
		void Save()
		{
			goodBindingSource.EndEdit();
			Validate();
			context.SaveChanges();
		}

		public GoodsForm(User user)
		{
			InitializeComponent();
			goodView1.Context = context;
			context.Goods.Load();
			goodBindingSource.DataSource = context.Goods.Local.ToBindingList();
		}

		private void сохранитьToolStripButton_Click(object sender, EventArgs e)
		{
			ViewUtils.ExceptionWrapper(this, Save);
		}

		private void goodBindingSource_CurrentItemChanged(object sender, EventArgs e)
		{
			goodView1.Good = goodBindingSource.Current as Good;
		}
	}
}