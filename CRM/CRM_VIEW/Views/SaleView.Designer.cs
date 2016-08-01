namespace CRM_VIEW.Views
{
	partial class SaleView
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label goodLabel;
			System.Windows.Forms.Label sellingPriceLabel;
			System.Windows.Forms.Label countLabel;
			System.Windows.Forms.Label dateLabel;
			this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.goodComboBox = new System.Windows.Forms.ComboBox();
			this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sellingPriceTextBox = new System.Windows.Forms.TextBox();
			this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.dateNullableDateTimePicker = new CRM_VIEW.Controllers.NullableDateTimePicker(this.components);
			goodLabel = new System.Windows.Forms.Label();
			sellingPriceLabel = new System.Windows.Forms.Label();
			countLabel = new System.Windows.Forms.Label();
			dateLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// goodLabel
			// 
			goodLabel.AutoSize = true;
			goodLabel.Location = new System.Drawing.Point(3, 6);
			goodLabel.Name = "goodLabel";
			goodLabel.Size = new System.Drawing.Size(41, 13);
			goodLabel.TabIndex = 1;
			goodLabel.Text = "Товар:";
			// 
			// sellingPriceLabel
			// 
			sellingPriceLabel.AutoSize = true;
			sellingPriceLabel.Location = new System.Drawing.Point(3, 33);
			sellingPriceLabel.Name = "sellingPriceLabel";
			sellingPriceLabel.Size = new System.Drawing.Size(83, 13);
			sellingPriceLabel.TabIndex = 3;
			sellingPriceLabel.Text = "Цена продажи:";
			// 
			// countLabel
			// 
			countLabel.AutoSize = true;
			countLabel.Location = new System.Drawing.Point(3, 58);
			countLabel.Name = "countLabel";
			countLabel.Size = new System.Drawing.Size(69, 13);
			countLabel.TabIndex = 5;
			countLabel.Text = "Количество:";
			// 
			// saleBindingSource
			// 
			this.saleBindingSource.DataSource = typeof(CRM_MODEL.Sale);
			// 
			// goodComboBox
			// 
			this.goodComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.goodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.saleBindingSource, "Good", true));
			this.goodComboBox.DataSource = this.goodBindingSource;
			this.goodComboBox.FormattingEnabled = true;
			this.goodComboBox.Location = new System.Drawing.Point(91, 3);
			this.goodComboBox.Name = "goodComboBox";
			this.goodComboBox.Size = new System.Drawing.Size(263, 21);
			this.goodComboBox.TabIndex = 2;
			// 
			// goodBindingSource
			// 
			this.goodBindingSource.DataSource = typeof(CRM_MODEL.Good);
			// 
			// sellingPriceTextBox
			// 
			this.sellingPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sellingPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "SellingPrice", true));
			this.sellingPriceTextBox.Location = new System.Drawing.Point(92, 30);
			this.sellingPriceTextBox.Name = "sellingPriceTextBox";
			this.sellingPriceTextBox.Size = new System.Drawing.Size(262, 20);
			this.sellingPriceTextBox.TabIndex = 4;
			// 
			// countNumericUpDown
			// 
			this.countNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.countNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.saleBindingSource, "Count", true));
			this.countNumericUpDown.Location = new System.Drawing.Point(92, 56);
			this.countNumericUpDown.Name = "countNumericUpDown";
			this.countNumericUpDown.Size = new System.Drawing.Size(262, 20);
			this.countNumericUpDown.TabIndex = 6;
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Location = new System.Drawing.Point(3, 88);
			dateLabel.Name = "dateLabel";
			dateLabel.Size = new System.Drawing.Size(36, 13);
			dateLabel.TabIndex = 6;
			dateLabel.Text = "Дата:";
			// 
			// dateNullableDateTimePicker
			// 
			this.dateNullableDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateNullableDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("NullableValue", this.saleBindingSource, "Date", true));
			this.dateNullableDateTimePicker.Location = new System.Drawing.Point(92, 82);
			this.dateNullableDateTimePicker.Name = "dateNullableDateTimePicker";
			this.dateNullableDateTimePicker.NullableValue = new System.DateTime(2016, 8, 1, 22, 30, 49, 632);
			this.dateNullableDateTimePicker.ShowCheckBox = true;
			this.dateNullableDateTimePicker.Size = new System.Drawing.Size(262, 20);
			this.dateNullableDateTimePicker.TabIndex = 7;
			// 
			// SaleView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(dateLabel);
			this.Controls.Add(this.dateNullableDateTimePicker);
			this.Controls.Add(countLabel);
			this.Controls.Add(this.countNumericUpDown);
			this.Controls.Add(sellingPriceLabel);
			this.Controls.Add(this.sellingPriceTextBox);
			this.Controls.Add(goodLabel);
			this.Controls.Add(this.goodComboBox);
			this.Name = "SaleView";
			this.Size = new System.Drawing.Size(357, 105);
			this.ReloadAll += new System.EventHandler(this.SaleView_ReloadAll);
			((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource saleBindingSource;
		private System.Windows.Forms.ComboBox goodComboBox;
		private System.Windows.Forms.TextBox sellingPriceTextBox;
		private System.Windows.Forms.NumericUpDown countNumericUpDown;
		private System.Windows.Forms.BindingSource goodBindingSource;
		private Controllers.NullableDateTimePicker dateNullableDateTimePicker;
	}
}
