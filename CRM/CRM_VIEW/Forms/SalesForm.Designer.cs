namespace CRM_VIEW.Forms
{
	partial class SalesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.saleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
			this.saleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.extendedDataGridView1 = new CRM_VIEW.DataGridViewColumns.ExtendedDataGridView();
			this.nameDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.ExtendedComboBoxColumn();
			this.goodTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.goodCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.DataGridViewCalendarColumn();
			this.purchasePriceDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			this.sellingPriceDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.koefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Person = new CRM_VIEW.DataGridViewColumns.ExtendedComboBoxColumn();
			this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.crmdbContextController1 = new CRM_VIEW.CRMDBContextController(this.components);
			((System.ComponentModel.ISupportInitialize)(this.saleBindingNavigator)).BeginInit();
			this.saleBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extendedDataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// saleBindingNavigator
			// 
			this.saleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.saleBindingNavigator.BindingSource = this.saleBindingSource;
			this.saleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.saleBindingNavigator.CountItemFormat = "из {0}";
			this.saleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.saleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.saleBindingNavigatorSaveItem});
			this.saleBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.saleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.saleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.saleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.saleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.saleBindingNavigator.Name = "saleBindingNavigator";
			this.saleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.saleBindingNavigator.Size = new System.Drawing.Size(982, 25);
			this.saleBindingNavigator.TabIndex = 0;
			this.saleBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Добавить";
			this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
			// saleBindingNavigatorSaveItem
			// 
			this.saleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("saleBindingNavigatorSaveItem.Image")));
			this.saleBindingNavigatorSaveItem.Name = "saleBindingNavigatorSaveItem";
			this.saleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.saleBindingNavigatorSaveItem.Text = "Сохранить данные";
			this.saleBindingNavigatorSaveItem.Click += new System.EventHandler(this.saleBindingNavigatorSaveItem_Click);
			// 
			// extendedDataGridView1
			// 
			this.extendedDataGridView1.AllowUserToAddRows = false;
			this.extendedDataGridView1.AutoGenerateColumns = false;
			this.extendedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.extendedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.goodTypeDataGridViewTextBoxColumn,
            this.providerDataGridViewTextBoxColumn,
            this.goodCommentDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn,
            this.koefDataGridViewTextBoxColumn,
            this.Person});
			this.extendedDataGridView1.DataSource = this.saleBindingSource;
			this.extendedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.extendedDataGridView1.Location = new System.Drawing.Point(0, 25);
			this.extendedDataGridView1.Name = "extendedDataGridView1";
			this.extendedDataGridView1.ReadonlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.extendedDataGridView1.Size = new System.Drawing.Size(982, 445);
			this.extendedDataGridView1.TabIndex = 1;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.nameDataGridViewTextBoxColumn.HeaderText = "Товар";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.nameDataGridViewTextBoxColumn.Width = 200;
			// 
			// goodTypeDataGridViewTextBoxColumn
			// 
			this.goodTypeDataGridViewTextBoxColumn.DataPropertyName = "GoodType";
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.goodTypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.goodTypeDataGridViewTextBoxColumn.HeaderText = "Тип товара";
			this.goodTypeDataGridViewTextBoxColumn.Name = "goodTypeDataGridViewTextBoxColumn";
			this.goodTypeDataGridViewTextBoxColumn.ReadOnly = true;
			this.goodTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.goodTypeDataGridViewTextBoxColumn.Width = 200;
			// 
			// providerDataGridViewTextBoxColumn
			// 
			this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.providerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.providerDataGridViewTextBoxColumn.HeaderText = "Поставщик";
			this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
			this.providerDataGridViewTextBoxColumn.ReadOnly = true;
			this.providerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.providerDataGridViewTextBoxColumn.Width = 200;
			// 
			// goodCommentDataGridViewTextBoxColumn
			// 
			this.goodCommentDataGridViewTextBoxColumn.DataPropertyName = "GoodComment";
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.goodCommentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
			this.goodCommentDataGridViewTextBoxColumn.HeaderText = "Описание товара";
			this.goodCommentDataGridViewTextBoxColumn.Name = "goodCommentDataGridViewTextBoxColumn";
			this.goodCommentDataGridViewTextBoxColumn.ReadOnly = true;
			this.goodCommentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.goodCommentDataGridViewTextBoxColumn.Width = 200;
			// 
			// countDataGridViewTextBoxColumn
			// 
			this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
			this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
			this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
			this.countDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.countDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// purchasePriceDataGridViewTextBoxColumn
			// 
			this.purchasePriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
			dataGridViewCellStyle5.Format = "C2";
			this.purchasePriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
			this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Цена закуп.";
			this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
			this.purchasePriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.purchasePriceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.purchasePriceDataGridViewTextBoxColumn.Width = 86;
			// 
			// sellingPriceDataGridViewTextBoxColumn
			// 
			this.sellingPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "SellingPrice";
			dataGridViewCellStyle6.Format = "C2";
			this.sellingPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
			this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "Цена прод.";
			this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
			this.sellingPriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.sellingPriceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.sellingPriceDataGridViewTextBoxColumn.Width = 81;
			// 
			// profitDataGridViewTextBoxColumn
			// 
			this.profitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle7.Format = "C2";
			this.profitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
			this.profitDataGridViewTextBoxColumn.HeaderText = "Прибыль";
			this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
			this.profitDataGridViewTextBoxColumn.ReadOnly = true;
			this.profitDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.profitDataGridViewTextBoxColumn.Width = 78;
			// 
			// koefDataGridViewTextBoxColumn
			// 
			this.koefDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.koefDataGridViewTextBoxColumn.DataPropertyName = "Koef";
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle8.Format = "N2";
			dataGridViewCellStyle8.NullValue = null;
			this.koefDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
			this.koefDataGridViewTextBoxColumn.HeaderText = "k";
			this.koefDataGridViewTextBoxColumn.Name = "koefDataGridViewTextBoxColumn";
			this.koefDataGridViewTextBoxColumn.ReadOnly = true;
			this.koefDataGridViewTextBoxColumn.Width = 38;
			// 
			// Person
			// 
			this.Person.DataPropertyName = "Person";
			this.Person.DataSource = this.personsBindingSource;
			this.Person.HeaderText = "Продавец";
			this.Person.Name = "Person";
			this.Person.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Person.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// saleBindingSource
			// 
			this.saleBindingSource.DataSource = typeof(CRM_MODEL.Sale);
			this.saleBindingSource.CurrentItemChanged += new System.EventHandler(this.saleBindingSource_CurrentItemChanged);
			// 
			// SalesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(982, 470);
			this.Controls.Add(this.extendedDataGridView1);
			this.Controls.Add(this.saleBindingNavigator);
			this.Name = "SalesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Продажи";
			((System.ComponentModel.ISupportInitialize)(this.saleBindingNavigator)).EndInit();
			this.saleBindingNavigator.ResumeLayout(false);
			this.saleBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extendedDataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource saleBindingSource;
		private System.Windows.Forms.BindingNavigator saleBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton saleBindingNavigatorSaveItem;
		private CRMDBContextController crmdbContextController1;
		private DataGridViewColumns.ExtendedDataGridView extendedDataGridView1;
		private System.Windows.Forms.BindingSource personsBindingSource;
		private DataGridViewColumns.ExtendedComboBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn goodTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn goodCommentDataGridViewTextBoxColumn;
		private DataGridViewColumns.ExtendedTextBoxColumn countDataGridViewTextBoxColumn;
		private DataGridViewColumns.DataGridViewCalendarColumn dateDataGridViewTextBoxColumn;
		private DataGridViewColumns.ExtendedTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
		private DataGridViewColumns.ExtendedTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn koefDataGridViewTextBoxColumn;
		private DataGridViewColumns.ExtendedComboBoxColumn Person;
	}
}