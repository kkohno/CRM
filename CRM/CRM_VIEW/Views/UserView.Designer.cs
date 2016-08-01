namespace CRM_VIEW.Views
{
	partial class UserView
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
			System.Windows.Forms.Label name1Label;
			System.Windows.Forms.Label name2Label;
			System.Windows.Forms.Label name3Label;
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.name1TextBox = new System.Windows.Forms.TextBox();
			this.name2TextBox = new System.Windows.Forms.TextBox();
			this.name3TextBox = new System.Windows.Forms.TextBox();
			this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
			name1Label = new System.Windows.Forms.Label();
			name2Label = new System.Windows.Forms.Label();
			name3Label = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// name1Label
			// 
			name1Label.AutoSize = true;
			name1Label.Location = new System.Drawing.Point(3, 6);
			name1Label.Name = "name1Label";
			name1Label.Size = new System.Drawing.Size(59, 13);
			name1Label.TabIndex = 1;
			name1Label.Text = "Фамилия:";
			// 
			// name2Label
			// 
			name2Label.AutoSize = true;
			name2Label.Location = new System.Drawing.Point(3, 32);
			name2Label.Name = "name2Label";
			name2Label.Size = new System.Drawing.Size(32, 13);
			name2Label.TabIndex = 2;
			name2Label.Text = "Имя:";
			// 
			// name3Label
			// 
			name3Label.AutoSize = true;
			name3Label.Location = new System.Drawing.Point(3, 58);
			name3Label.Name = "name3Label";
			name3Label.Size = new System.Drawing.Size(57, 13);
			name3Label.TabIndex = 4;
			name3Label.Text = "Отчество:";
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(CRM_MODEL.User);
			// 
			// name1TextBox
			// 
			this.name1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.name1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name1", true));
			this.name1TextBox.Location = new System.Drawing.Point(66, 3);
			this.name1TextBox.Name = "name1TextBox";
			this.name1TextBox.Size = new System.Drawing.Size(162, 20);
			this.name1TextBox.TabIndex = 2;
			// 
			// name2TextBox
			// 
			this.name2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.name2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name2", true));
			this.name2TextBox.Location = new System.Drawing.Point(66, 29);
			this.name2TextBox.Name = "name2TextBox";
			this.name2TextBox.Size = new System.Drawing.Size(162, 20);
			this.name2TextBox.TabIndex = 3;
			// 
			// name3TextBox
			// 
			this.name3TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.name3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name3", true));
			this.name3TextBox.Location = new System.Drawing.Point(66, 55);
			this.name3TextBox.Name = "name3TextBox";
			this.name3TextBox.Size = new System.Drawing.Size(162, 20);
			this.name3TextBox.TabIndex = 5;
			// 
			// isAdminCheckBox
			// 
			this.isAdminCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.isAdminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userBindingSource, "IsAdmin", true));
			this.isAdminCheckBox.Location = new System.Drawing.Point(66, 81);
			this.isAdminCheckBox.Name = "isAdminCheckBox";
			this.isAdminCheckBox.Size = new System.Drawing.Size(159, 24);
			this.isAdminCheckBox.TabIndex = 7;
			this.isAdminCheckBox.Text = "Админ";
			this.isAdminCheckBox.UseVisualStyleBackColor = true;
			// 
			// UserView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.isAdminCheckBox);
			this.Controls.Add(name3Label);
			this.Controls.Add(this.name3TextBox);
			this.Controls.Add(name2Label);
			this.Controls.Add(this.name2TextBox);
			this.Controls.Add(name1Label);
			this.Controls.Add(this.name1TextBox);
			this.Name = "UserView";
			this.Size = new System.Drawing.Size(228, 103);
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource userBindingSource;
		private System.Windows.Forms.TextBox name1TextBox;
		private System.Windows.Forms.TextBox name2TextBox;
		private System.Windows.Forms.TextBox name3TextBox;
		private System.Windows.Forms.CheckBox isAdminCheckBox;
	}
}
