namespace CRM_VIEW.Forms
{
	partial class AdvertisingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvertisingsForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.advertisingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.advertisingBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
			this.advertisingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.advertisingTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.advertisingExtendedDataGridView = new CRM_VIEW.DataGridViewColumns.ExtendedDataGridView();
			this.crmdbContextController1 = new CRM_VIEW.CRMDBContextController(this.components);
			this.dataGridViewTextBoxColumn2 = new CRM_VIEW.DataGridViewColumns.ExtendedComboBoxColumn();
			this.dataGridViewTextBoxColumn6 = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new CRM_VIEW.DataGridViewColumns.DataGridViewCalendarColumn();
			this.dataGridViewTextBoxColumn5 = new CRM_VIEW.DataGridViewColumns.DataGridViewCalendarColumn();
			this.dataGridViewTextBoxColumn8 = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.advertisingBindingNavigator)).BeginInit();
			this.advertisingBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.advertisingBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.advertisingTypeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.advertisingExtendedDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// advertisingBindingNavigator
			// 
			this.advertisingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.advertisingBindingNavigator.BindingSource = this.advertisingBindingSource;
			this.advertisingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.advertisingBindingNavigator.CountItemFormat = "из {0}";
			this.advertisingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.advertisingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.advertisingBindingNavigatorSaveItem});
			this.advertisingBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.advertisingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.advertisingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.advertisingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.advertisingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.advertisingBindingNavigator.Name = "advertisingBindingNavigator";
			this.advertisingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.advertisingBindingNavigator.Size = new System.Drawing.Size(841, 25);
			this.advertisingBindingNavigator.TabIndex = 0;
			this.advertisingBindingNavigator.Text = "bindingNavigator1";
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
			// advertisingBindingSource
			// 
			this.advertisingBindingSource.DataSource = typeof(CRM_MODEL.Advertising);
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
			// advertisingBindingNavigatorSaveItem
			// 
			this.advertisingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.advertisingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("advertisingBindingNavigatorSaveItem.Image")));
			this.advertisingBindingNavigatorSaveItem.Name = "advertisingBindingNavigatorSaveItem";
			this.advertisingBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.advertisingBindingNavigatorSaveItem.Text = "Сохранить данные";
			this.advertisingBindingNavigatorSaveItem.Click += new System.EventHandler(this.advertisingBindingNavigatorSaveItem_Click);
			// 
			// advertisingTypeBindingSource
			// 
			this.advertisingTypeBindingSource.DataSource = typeof(CRM_MODEL.AdvertisingType);
			// 
			// advertisingExtendedDataGridView
			// 
			this.advertisingExtendedDataGridView.AllowUserToAddRows = false;
			this.advertisingExtendedDataGridView.AllowUserToOrderColumns = true;
			this.advertisingExtendedDataGridView.AutoGenerateColumns = false;
			this.advertisingExtendedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.advertisingExtendedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8});
			this.advertisingExtendedDataGridView.DataSource = this.advertisingBindingSource;
			this.advertisingExtendedDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.advertisingExtendedDataGridView.Location = new System.Drawing.Point(0, 25);
			this.advertisingExtendedDataGridView.Name = "advertisingExtendedDataGridView";
			this.advertisingExtendedDataGridView.ReadonlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.advertisingExtendedDataGridView.Size = new System.Drawing.Size(841, 326);
			this.advertisingExtendedDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "AdvertisingType";
			this.dataGridViewTextBoxColumn2.DataSource = this.advertisingTypeBindingSource;
			this.dataGridViewTextBoxColumn2.HeaderText = "Тип рекламы";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "AdvertisingType_Name";
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewTextBoxColumn6.HeaderText = "Название рекламы";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "AdvertisingType_Comment";
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn7.HeaderText = "Описание рекламы";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Summ";
			this.dataGridViewTextBoxColumn3.HeaderText = "Затрачено";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Start";
			this.dataGridViewTextBoxColumn4.HeaderText = "Начало";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "End";
			this.dataGridViewTextBoxColumn5.HeaderText = "Конец";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Duration";
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle3.NullValue = null;
			this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn8.HeaderText = "Длительность";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// AdvertisingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 351);
			this.Controls.Add(this.advertisingExtendedDataGridView);
			this.Controls.Add(this.advertisingBindingNavigator);
			this.Name = "AdvertisingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Реклама";
			((System.ComponentModel.ISupportInitialize)(this.advertisingBindingNavigator)).EndInit();
			this.advertisingBindingNavigator.ResumeLayout(false);
			this.advertisingBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.advertisingBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.advertisingTypeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.advertisingExtendedDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource advertisingBindingSource;
		private System.Windows.Forms.BindingNavigator advertisingBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton advertisingBindingNavigatorSaveItem;
		private DataGridViewColumns.ExtendedDataGridView advertisingExtendedDataGridView;
		private System.Windows.Forms.BindingSource advertisingTypeBindingSource;
		private CRMDBContextController crmdbContextController1;
		private DataGridViewColumns.ExtendedComboBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewColumns.ExtendedTextBoxColumn dataGridViewTextBoxColumn6;
		private DataGridViewColumns.ExtendedTextBoxColumn dataGridViewTextBoxColumn7;
		private DataGridViewColumns.ExtendedTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewColumns.DataGridViewCalendarColumn dataGridViewTextBoxColumn4;
		private DataGridViewColumns.DataGridViewCalendarColumn dataGridViewTextBoxColumn5;
		private DataGridViewColumns.ExtendedTextBoxColumn dataGridViewTextBoxColumn8;
	}
}