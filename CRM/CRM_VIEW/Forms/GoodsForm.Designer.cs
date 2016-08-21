namespace CRM_VIEW.Forms
{
	partial class GoodsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dataGridView1 = new CRM_VIEW.DataGridViewColumns.ExtendedDataGridView();
			this.nameDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			this.goodTypeDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.ExtendedComboBoxColumn();
			this.goodTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.providerDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.ExtendedComboBoxColumn();
			this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.purchasePriceDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			this.currentSellingPriceDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			this.profitDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			this.Koef = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			this.commentDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.goodListsView1 = new CRM_VIEW.Views.GoodListsView();
			this.extendedTextBoxColumn1 = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.crmdbContextController1 = new CRM_VIEW.CRMDBContextController(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.goodTypeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator1.BindingSource = this.goodBindingSource;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.CountItemFormat = "из {0}";
			this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripSeparator,
            this.сохранитьToolStripButton});
			this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(928, 25);
			this.bindingNavigator1.TabIndex = 2;
			this.bindingNavigator1.Text = "bindingNavigator1";
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
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// сохранитьToolStripButton
			// 
			this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.сохранитьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripButton.Image")));
			this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
			this.сохранитьToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.сохранитьToolStripButton.Text = "&Сохранить";
			this.сохранитьToolStripButton.Click += new System.EventHandler(this.сохранитьToolStripButton_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 25);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.goodListsView1);
			this.splitContainer1.Size = new System.Drawing.Size(928, 349);
			this.splitContainer1.SplitterDistance = 656;
			this.splitContainer1.TabIndex = 3;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.goodTypeDataGridViewTextBoxColumn,
            this.providerDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.currentSellingPriceDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn,
            this.Koef,
            this.commentDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.goodBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadonlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView1.Size = new System.Drawing.Size(656, 349);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.nameDataGridViewTextBoxColumn.Width = 150;
			// 
			// goodTypeDataGridViewTextBoxColumn
			// 
			this.goodTypeDataGridViewTextBoxColumn.DataPropertyName = "GoodType";
			this.goodTypeDataGridViewTextBoxColumn.DataSource = this.goodTypeBindingSource;
			this.goodTypeDataGridViewTextBoxColumn.HeaderText = "Тип";
			this.goodTypeDataGridViewTextBoxColumn.Name = "goodTypeDataGridViewTextBoxColumn";
			this.goodTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.goodTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.goodTypeDataGridViewTextBoxColumn.Width = 200;
			// 
			// goodTypeBindingSource
			// 
			this.goodTypeBindingSource.DataSource = typeof(CRM_MODEL.GoodType);
			// 
			// providerDataGridViewTextBoxColumn
			// 
			this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
			this.providerDataGridViewTextBoxColumn.DataSource = this.providerBindingSource;
			dataGridViewCellStyle8.NullValue = null;
			this.providerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
			this.providerDataGridViewTextBoxColumn.HeaderText = "Поставщик";
			this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
			this.providerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.providerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.providerDataGridViewTextBoxColumn.Width = 150;
			// 
			// providerBindingSource
			// 
			this.providerBindingSource.DataSource = typeof(CRM_MODEL.Provider);
			// 
			// purchasePriceDataGridViewTextBoxColumn
			// 
			this.purchasePriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
			dataGridViewCellStyle1.Format = "C2";
			dataGridViewCellStyle1.NullValue = null;
			this.purchasePriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Цена зак.";
			this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
			this.purchasePriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.purchasePriceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.purchasePriceDataGridViewTextBoxColumn.Width = 82;
			// 
			// currentSellingPriceDataGridViewTextBoxColumn
			// 
			this.currentSellingPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.currentSellingPriceDataGridViewTextBoxColumn.DataPropertyName = "CurrentSellingPrice";
			dataGridViewCellStyle9.Format = "C2";
			dataGridViewCellStyle9.NullValue = null;
			this.currentSellingPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
			this.currentSellingPriceDataGridViewTextBoxColumn.HeaderText = "Цена прод.";
			this.currentSellingPriceDataGridViewTextBoxColumn.Name = "currentSellingPriceDataGridViewTextBoxColumn";
			this.currentSellingPriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.currentSellingPriceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.currentSellingPriceDataGridViewTextBoxColumn.Width = 88;
			// 
			// profitDataGridViewTextBoxColumn
			// 
			this.profitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle10.Format = "C2";
			this.profitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
			this.profitDataGridViewTextBoxColumn.HeaderText = "Прибыль";
			this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
			this.profitDataGridViewTextBoxColumn.ReadOnly = true;
			this.profitDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.profitDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.profitDataGridViewTextBoxColumn.Width = 78;
			// 
			// Koef
			// 
			this.Koef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Koef.DataPropertyName = "Koef";
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle11.Format = "N2";
			this.Koef.DefaultCellStyle = dataGridViewCellStyle11;
			this.Koef.HeaderText = "k";
			this.Koef.Name = "Koef";
			this.Koef.ReadOnly = true;
			this.Koef.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Koef.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Koef.Width = 38;
			// 
			// commentDataGridViewTextBoxColumn
			// 
			this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
			this.commentDataGridViewTextBoxColumn.HeaderText = "Описание";
			this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
			this.commentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.commentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.commentDataGridViewTextBoxColumn.Width = 250;
			// 
			// goodBindingSource
			// 
			this.goodBindingSource.DataSource = typeof(CRM_MODEL.Good);
			this.goodBindingSource.CurrentItemChanged += new System.EventHandler(this.goodBindingSource_CurrentItemChanged);
			// 
			// goodListsView1
			// 
			this.goodListsView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.goodListsView1.Location = new System.Drawing.Point(0, 0);
			this.goodListsView1.Name = "goodListsView1";
			this.goodListsView1.Size = new System.Drawing.Size(268, 349);
			this.goodListsView1.TabIndex = 0;
			// 
			// extendedTextBoxColumn1
			// 
			this.extendedTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.extendedTextBoxColumn1.DataPropertyName = "Koef";
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle12.Format = "N2";
			this.extendedTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle12;
			this.extendedTextBoxColumn1.HeaderText = "k";
			this.extendedTextBoxColumn1.Name = "extendedTextBoxColumn1";
			this.extendedTextBoxColumn1.ReadOnly = true;
			this.extendedTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.extendedTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Koef";
			dataGridViewCellStyle13.Format = "N2";
			dataGridViewCellStyle13.NullValue = null;
			this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle13;
			this.dataGridViewTextBoxColumn1.HeaderText = "k";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// GoodsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(928, 374);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.bindingNavigator1);
			this.Name = "GoodsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Товары";
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.goodTypeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource goodBindingSource;
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton сохранитьToolStripButton;
		private CRMDBContextController crmdbContextController1;
		private DataGridViewColumns.ExtendedDataGridView dataGridView1;
		private System.Windows.Forms.BindingSource goodTypeBindingSource;
		private System.Windows.Forms.BindingSource providerBindingSource;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private Views.GoodListsView goodListsView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewColumns.ExtendedTextBoxColumn extendedTextBoxColumn1;
		private DataGridViewColumns.ExtendedTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewColumns.ExtendedComboBoxColumn goodTypeDataGridViewTextBoxColumn;
		private DataGridViewColumns.ExtendedComboBoxColumn providerDataGridViewTextBoxColumn;
		private DataGridViewColumns.ExtendedTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
		private DataGridViewColumns.ExtendedTextBoxColumn currentSellingPriceDataGridViewTextBoxColumn;
		private DataGridViewColumns.ExtendedTextBoxColumn profitDataGridViewTextBoxColumn;
		private DataGridViewColumns.ExtendedTextBoxColumn Koef;
		private DataGridViewColumns.ExtendedTextBoxColumn commentDataGridViewTextBoxColumn;
	}
}