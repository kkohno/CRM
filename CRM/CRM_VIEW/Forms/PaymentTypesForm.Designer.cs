namespace CRM_VIEW.Forms
{
	partial class PaymentTypesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentTypesForm));
			CRM_MODEL.CRMDBContext crmdbContext2 = new CRM_MODEL.CRMDBContext();
			this.paymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.paymentTypeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.paymentTypeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.paymentTypeDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.crmdbContextController1 = new CRM_VIEW.CRMDBContextController(this.components);
			((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingNavigator)).BeginInit();
			this.paymentTypeBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.paymentTypeDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// paymentTypeBindingSource
			// 
			this.paymentTypeBindingSource.DataSource = typeof(CRM_MODEL.PaymentType);
			// 
			// paymentTypeBindingNavigator
			// 
			this.paymentTypeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.paymentTypeBindingNavigator.BindingSource = this.paymentTypeBindingSource;
			this.paymentTypeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.paymentTypeBindingNavigator.CountItemFormat = "из {0}";
			this.paymentTypeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.paymentTypeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.paymentTypeBindingNavigatorSaveItem});
			this.paymentTypeBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.paymentTypeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.paymentTypeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.paymentTypeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.paymentTypeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.paymentTypeBindingNavigator.Name = "paymentTypeBindingNavigator";
			this.paymentTypeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.paymentTypeBindingNavigator.Size = new System.Drawing.Size(395, 25);
			this.paymentTypeBindingNavigator.TabIndex = 0;
			this.paymentTypeBindingNavigator.Text = "bindingNavigator1";
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
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
			this.bindingNavigatorCountItem.Text = "из {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
			// 
			// paymentTypeBindingNavigatorSaveItem
			// 
			this.paymentTypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.paymentTypeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentTypeBindingNavigatorSaveItem.Image")));
			this.paymentTypeBindingNavigatorSaveItem.Name = "paymentTypeBindingNavigatorSaveItem";
			this.paymentTypeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.paymentTypeBindingNavigatorSaveItem.Text = "Сохранить данные";
			this.paymentTypeBindingNavigatorSaveItem.Click += new System.EventHandler(this.paymentTypeBindingNavigatorSaveItem_Click);
			// 
			// paymentTypeDataGridView
			// 
			this.paymentTypeDataGridView.AutoGenerateColumns = false;
			this.paymentTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.paymentTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.paymentTypeDataGridView.DataSource = this.paymentTypeBindingSource;
			this.paymentTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.paymentTypeDataGridView.Location = new System.Drawing.Point(0, 25);
			this.paymentTypeDataGridView.Name = "paymentTypeDataGridView";
			this.paymentTypeDataGridView.Size = new System.Drawing.Size(395, 340);
			this.paymentTypeDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Тип платежа";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 97;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// crmdbContextController1
			// 
			this.crmdbContextController1.Context = crmdbContext2;
			// 
			// PaymentTypesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 365);
			this.Controls.Add(this.paymentTypeDataGridView);
			this.Controls.Add(this.paymentTypeBindingNavigator);
			this.Name = "PaymentTypesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Типы платежей";
			((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingNavigator)).EndInit();
			this.paymentTypeBindingNavigator.ResumeLayout(false);
			this.paymentTypeBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.paymentTypeDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource paymentTypeBindingSource;
		private System.Windows.Forms.BindingNavigator paymentTypeBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton paymentTypeBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView paymentTypeDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private CRMDBContextController crmdbContextController1;
	}
}