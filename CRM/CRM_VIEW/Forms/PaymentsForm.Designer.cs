namespace CRM_VIEW.Forms
{
	partial class PaymentsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsForm));
			CRM_MODEL.CRMDBContext crmdbContext1 = new CRM_MODEL.CRMDBContext();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.paymentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.paymentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.paymentDataGridView = new System.Windows.Forms.DataGridView();
			this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.paymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewCalendarColumn1 = new CRM_VIEW.DataGridViewColumns.DataGridViewCalendarColumn();
			this.crmdbContextController1 = new CRM_VIEW.CRMDBContextController(this.components);
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new CRM_VIEW.DataGridViewColumns.DataGridViewCalendarColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.paymentBindingNavigator)).BeginInit();
			this.paymentBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// paymentBindingNavigator
			// 
			this.paymentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.paymentBindingNavigator.BindingSource = this.paymentBindingSource;
			this.paymentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.paymentBindingNavigator.CountItemFormat = "из {0}";
			this.paymentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.paymentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.paymentBindingNavigatorSaveItem});
			this.paymentBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.paymentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.paymentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.paymentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.paymentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.paymentBindingNavigator.Name = "paymentBindingNavigator";
			this.paymentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.paymentBindingNavigator.Size = new System.Drawing.Size(532, 25);
			this.paymentBindingNavigator.TabIndex = 0;
			this.paymentBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Добавить";
			// 
			// paymentBindingSource
			// 
			this.paymentBindingSource.DataSource = typeof(CRM_MODEL.Payment);
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
			this.bindingNavigatorCountItem.Text = "из {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Положение";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// paymentBindingNavigatorSaveItem
			// 
			this.paymentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.paymentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentBindingNavigatorSaveItem.Image")));
			this.paymentBindingNavigatorSaveItem.Name = "paymentBindingNavigatorSaveItem";
			this.paymentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.paymentBindingNavigatorSaveItem.Text = "Сохранить данные";
			this.paymentBindingNavigatorSaveItem.Click += new System.EventHandler(this.paymentBindingNavigatorSaveItem_Click);
			// 
			// paymentDataGridView
			// 
			this.paymentDataGridView.AutoGenerateColumns = false;
			this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.paymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.Date,
            this.dataGridViewTextBoxColumn5});
			this.paymentDataGridView.DataSource = this.paymentBindingSource;
			this.paymentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.paymentDataGridView.Location = new System.Drawing.Point(0, 25);
			this.paymentDataGridView.Name = "paymentDataGridView";
			this.paymentDataGridView.Size = new System.Drawing.Size(532, 302);
			this.paymentDataGridView.TabIndex = 1;
			// 
			// personBindingSource
			// 
			this.personBindingSource.DataSource = typeof(CRM_MODEL.Person);
			// 
			// paymentTypeBindingSource
			// 
			this.paymentTypeBindingSource.DataSource = typeof(CRM_MODEL.PaymentType);
			// 
			// dataGridViewCalendarColumn1
			// 
			this.dataGridViewCalendarColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewCalendarColumn1.DataPropertyName = "Date";
			this.dataGridViewCalendarColumn1.HeaderText = "Дата";
			this.dataGridViewCalendarColumn1.Name = "dataGridViewCalendarColumn1";
			this.dataGridViewCalendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewCalendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// crmdbContextController1
			// 
			this.crmdbContextController1.Context = crmdbContext1;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Person";
			this.dataGridViewTextBoxColumn2.DataSource = this.personBindingSource;
			this.dataGridViewTextBoxColumn2.DisplayMember = "ShortFIO";
			this.dataGridViewTextBoxColumn2.HeaderText = "Персона";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn2.ValueMember = "Instance";
			this.dataGridViewTextBoxColumn2.Width = 76;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "PaymentType";
			this.dataGridViewTextBoxColumn4.DataSource = this.paymentTypeBindingSource;
			this.dataGridViewTextBoxColumn4.DisplayMember = "Name";
			this.dataGridViewTextBoxColumn4.HeaderText = "Тип платежа";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn4.ValueMember = "Instance";
			this.dataGridViewTextBoxColumn4.Width = 97;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Summ";
			dataGridViewCellStyle1.Format = "C2";
			dataGridViewCellStyle1.NullValue = null;
			this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewTextBoxColumn3.HeaderText = "Сумма";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 66;
			// 
			// Date
			// 
			this.Date.DataPropertyName = "Date";
			this.Date.FillWeight = 350F;
			this.Date.HeaderText = "Дата";
			this.Date.Name = "Date";
			this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn5.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 102;
			// 
			// PaymentsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 327);
			this.Controls.Add(this.paymentDataGridView);
			this.Controls.Add(this.paymentBindingNavigator);
			this.Name = "PaymentsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Платежи";
			((System.ComponentModel.ISupportInitialize)(this.paymentBindingNavigator)).EndInit();
			this.paymentBindingNavigator.ResumeLayout(false);
			this.paymentBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CRMDBContextController crmdbContextController1;
		private System.Windows.Forms.BindingSource paymentBindingSource;
		private System.Windows.Forms.BindingNavigator paymentBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton paymentBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView paymentDataGridView;
		private System.Windows.Forms.BindingSource paymentTypeBindingSource;
		private System.Windows.Forms.BindingSource personBindingSource;
		private DataGridViewColumns.DataGridViewCalendarColumn dataGridViewCalendarColumn1;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewColumns.DataGridViewCalendarColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
	}
}