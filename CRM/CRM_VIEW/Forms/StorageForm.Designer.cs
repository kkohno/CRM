namespace CRM_VIEW.Forms
{
	partial class StorageForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.goodStorageItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
			this.dataGridView1 = new CRM_VIEW.DataGridViewColumns.ExtendedDataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCalendarColumn1 = new CRM_VIEW.DataGridViewColumns.DataGridViewCalendarColumn();
			this.dataGridViewCalendarColumn2 = new CRM_VIEW.DataGridViewColumns.DataGridViewCalendarColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.crmdbContextController1 = new CRM_VIEW.CRMDBContextController(this.components);
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.goodTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.receivingDateDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.DataGridViewCalendarColumn();
			this.shelfLifeDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.DataGridViewCalendarColumn();
			this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.purchasePriceDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			this.currentSellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.koefDataGridViewTextBoxColumn = new CRM_VIEW.DataGridViewColumns.ExtendedTextBoxColumn();
			this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.goodStorageItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator1.BindingSource = this.goodStorageItemBindingSource;
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
			this.bindingNavigator1.Size = new System.Drawing.Size(995, 25);
			this.bindingNavigator1.TabIndex = 0;
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
			this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
			// 
			// goodStorageItemBindingSource
			// 
			this.goodStorageItemBindingSource.DataSource = typeof(CRM_MODEL.GoodStorageItem);
			this.goodStorageItemBindingSource.CurrentChanged += new System.EventHandler(this.goodStorageItemBindingSource_CurrentChanged);
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
            this.receivingDateDataGridViewTextBoxColumn,
            this.shelfLifeDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.currentSellingPriceDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn,
            this.koefDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.goodStorageItemBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 25);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadonlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridView1.Size = new System.Drawing.Size(995, 359);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Count";
			this.dataGridViewTextBoxColumn1.HeaderText = "Количество";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "PurchasePrice";
			this.dataGridViewTextBoxColumn2.HeaderText = "Цена зак.";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "CurrentSellingPrice";
			this.dataGridViewTextBoxColumn3.HeaderText = "Цена прод.";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewCalendarColumn1
			// 
			this.dataGridViewCalendarColumn1.DataPropertyName = "ReceivingDate";
			this.dataGridViewCalendarColumn1.HeaderText = "Получен";
			this.dataGridViewCalendarColumn1.Name = "dataGridViewCalendarColumn1";
			this.dataGridViewCalendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewCalendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewCalendarColumn2
			// 
			this.dataGridViewCalendarColumn2.DataPropertyName = "ShelfLife";
			this.dataGridViewCalendarColumn2.HeaderText = "Годен до";
			this.dataGridViewCalendarColumn2.Name = "dataGridViewCalendarColumn2";
			this.dataGridViewCalendarColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewCalendarColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "ReceivingDate";
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridViewTextBoxColumn4.HeaderText = "Получен";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "ShelfLife";
			dataGridViewCellStyle10.Format = "C2";
			dataGridViewCellStyle10.NullValue = null;
			this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridViewTextBoxColumn5.HeaderText = "Годен до";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Profit";
			dataGridViewCellStyle11.Format = "C2";
			dataGridViewCellStyle11.NullValue = null;
			this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle11;
			this.dataGridViewTextBoxColumn6.HeaderText = "Прибыль";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Koef";
			dataGridViewCellStyle12.Format = "C2";
			dataGridViewCellStyle12.NullValue = null;
			this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridViewTextBoxColumn7.HeaderText = "k";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
			dataGridViewCellStyle13.Format = "N2";
			dataGridViewCellStyle13.NullValue = null;
			this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle13;
			this.dataGridViewTextBoxColumn8.HeaderText = "Название";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "GoodType";
			this.dataGridViewTextBoxColumn9.HeaderText = "Тип товара";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "Provider";
			this.dataGridViewTextBoxColumn10.HeaderText = "Поставщик";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn11.HeaderText = "Описание";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// goodTypeDataGridViewTextBoxColumn
			// 
			this.goodTypeDataGridViewTextBoxColumn.DataPropertyName = "GoodType";
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.goodTypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.goodTypeDataGridViewTextBoxColumn.HeaderText = "Тип товара";
			this.goodTypeDataGridViewTextBoxColumn.Name = "goodTypeDataGridViewTextBoxColumn";
			this.goodTypeDataGridViewTextBoxColumn.ReadOnly = true;
			this.goodTypeDataGridViewTextBoxColumn.Width = 89;
			// 
			// providerDataGridViewTextBoxColumn
			// 
			this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.providerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.providerDataGridViewTextBoxColumn.HeaderText = "Поставщик";
			this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
			this.providerDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// receivingDateDataGridViewTextBoxColumn
			// 
			this.receivingDateDataGridViewTextBoxColumn.DataPropertyName = "ReceivingDate";
			this.receivingDateDataGridViewTextBoxColumn.HeaderText = "Получен";
			this.receivingDateDataGridViewTextBoxColumn.Name = "receivingDateDataGridViewTextBoxColumn";
			this.receivingDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.receivingDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// shelfLifeDataGridViewTextBoxColumn
			// 
			this.shelfLifeDataGridViewTextBoxColumn.DataPropertyName = "ShelfLife";
			this.shelfLifeDataGridViewTextBoxColumn.HeaderText = "Годен до";
			this.shelfLifeDataGridViewTextBoxColumn.Name = "shelfLifeDataGridViewTextBoxColumn";
			this.shelfLifeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.shelfLifeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// countDataGridViewTextBoxColumn
			// 
			this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
			this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
			this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
			// 
			// purchasePriceDataGridViewTextBoxColumn
			// 
			this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
			dataGridViewCellStyle4.Format = "C2";
			this.purchasePriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
			this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Цена зак.";
			this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
			this.purchasePriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.purchasePriceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// currentSellingPriceDataGridViewTextBoxColumn
			// 
			this.currentSellingPriceDataGridViewTextBoxColumn.DataPropertyName = "CurrentSellingPrice";
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle5.Format = "C2";
			dataGridViewCellStyle5.NullValue = null;
			this.currentSellingPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
			this.currentSellingPriceDataGridViewTextBoxColumn.HeaderText = "Цена прод.";
			this.currentSellingPriceDataGridViewTextBoxColumn.Name = "currentSellingPriceDataGridViewTextBoxColumn";
			this.currentSellingPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// profitDataGridViewTextBoxColumn
			// 
			this.profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle6.Format = "C2";
			dataGridViewCellStyle6.NullValue = null;
			this.profitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
			this.profitDataGridViewTextBoxColumn.HeaderText = "Прибыль";
			this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
			this.profitDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// koefDataGridViewTextBoxColumn
			// 
			this.koefDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.koefDataGridViewTextBoxColumn.DataPropertyName = "Koef";
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle7.Format = "N2";
			this.koefDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
			this.koefDataGridViewTextBoxColumn.HeaderText = "k";
			this.koefDataGridViewTextBoxColumn.Name = "koefDataGridViewTextBoxColumn";
			this.koefDataGridViewTextBoxColumn.ReadOnly = true;
			this.koefDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.koefDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.koefDataGridViewTextBoxColumn.Width = 38;
			// 
			// commentDataGridViewTextBoxColumn
			// 
			this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.commentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
			this.commentDataGridViewTextBoxColumn.HeaderText = "Описание";
			this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
			this.commentDataGridViewTextBoxColumn.ReadOnly = true;
			this.commentDataGridViewTextBoxColumn.Width = 200;
			// 
			// StorageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(995, 384);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.bindingNavigator1);
			this.Name = "StorageForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Склад";
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.goodStorageItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

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
		private CRMDBContextController crmdbContextController1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton сохранитьToolStripButton;
		private System.Windows.Forms.BindingSource goodStorageItemBindingSource;
		private DataGridViewColumns.ExtendedDataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private DataGridViewColumns.DataGridViewCalendarColumn dataGridViewCalendarColumn1;
		private DataGridViewColumns.DataGridViewCalendarColumn dataGridViewCalendarColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn goodTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
		private DataGridViewColumns.DataGridViewCalendarColumn receivingDateDataGridViewTextBoxColumn;
		private DataGridViewColumns.DataGridViewCalendarColumn shelfLifeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
		private DataGridViewColumns.ExtendedTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn currentSellingPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
		private DataGridViewColumns.ExtendedTextBoxColumn koefDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
	}
}