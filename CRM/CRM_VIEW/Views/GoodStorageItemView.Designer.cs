
namespace CRM_VIEW.Views
{
	partial class GoodStorageItemView
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.goodStorageItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.nullableDateTimePicker1 = new CRM_VIEW.Controllers.NullableDateTimePicker(this.components);
			this.nullableDateTimePicker2 = new CRM_VIEW.Controllers.NullableDateTimePicker(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.goodStorageItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Товар";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Количество";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Цена закупки";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Дата получения";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Годен до";
			// 
			// goodStorageItemBindingSource
			// 
			this.goodStorageItemBindingSource.DataSource = typeof(CRM_MODEL.GoodStorageItem);
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodStorageItemBindingSource, "PurchasePrice", true));
			this.textBox2.Location = new System.Drawing.Point(97, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(212, 20);
			this.textBox2.TabIndex = 7;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.goodStorageItemBindingSource, "Count", true));
			this.numericUpDown1.Location = new System.Drawing.Point(97, 31);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(212, 20);
			this.numericUpDown1.TabIndex = 10;
			this.numericUpDown1.ThousandsSeparator = true;
			// 
			// nullableDateTimePicker1
			// 
			this.nullableDateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nullableDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("NullableValue", this.goodStorageItemBindingSource, "ReceivingDate", true));
			this.nullableDateTimePicker1.Location = new System.Drawing.Point(97, 82);
			this.nullableDateTimePicker1.Name = "nullableDateTimePicker1";
			this.nullableDateTimePicker1.NullableValue = new System.DateTime(2016, 7, 31, 23, 34, 54, 311);
			this.nullableDateTimePicker1.ShowCheckBox = true;
			this.nullableDateTimePicker1.Size = new System.Drawing.Size(211, 20);
			this.nullableDateTimePicker1.TabIndex = 11;
			this.nullableDateTimePicker1.Value = new System.DateTime(2016, 7, 31, 23, 34, 54, 311);
			// 
			// nullableDateTimePicker2
			// 
			this.nullableDateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nullableDateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("NullableValue", this.goodStorageItemBindingSource, "ShelfLife", true));
			this.nullableDateTimePicker2.Location = new System.Drawing.Point(97, 108);
			this.nullableDateTimePicker2.Name = "nullableDateTimePicker2";
			this.nullableDateTimePicker2.NullableValue = new System.DateTime(2016, 7, 31, 23, 34, 54, 315);
			this.nullableDateTimePicker2.ShowCheckBox = true;
			this.nullableDateTimePicker2.Size = new System.Drawing.Size(211, 20);
			this.nullableDateTimePicker2.TabIndex = 12;
			this.nullableDateTimePicker2.Value = new System.DateTime(2016, 7, 31, 23, 34, 54, 315);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(282, 1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(27, 23);
			this.button1.TabIndex = 13;
			this.button1.Text = "^";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodStorageItemBindingSource, "Good", true));
			this.textBox1.Location = new System.Drawing.Point(97, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(179, 20);
			this.textBox1.TabIndex = 14;
			// 
			// GoodStorageItemView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.nullableDateTimePicker2);
			this.Controls.Add(this.nullableDateTimePicker1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "GoodStorageItemView";
			this.Size = new System.Drawing.Size(312, 131);
			this.ReloadAll += new System.EventHandler(this.GoodStorageItemView_ReloadAll);
			((System.ComponentModel.ISupportInitialize)(this.goodStorageItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private Controllers.NullableDateTimePicker nullableDateTimePicker1;
		private Controllers.NullableDateTimePicker nullableDateTimePicker2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.BindingSource goodStorageItemBindingSource;
	}
}
