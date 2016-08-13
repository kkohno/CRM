namespace CRM_VIEW.Views
{
	partial class ContextSettingsView
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
			System.Windows.Forms.Label catalogLabel;
			System.Windows.Forms.Label passwordLabel;
			System.Windows.Forms.Label sourceLabel;
			System.Windows.Forms.Label userLabel;
			this.catalogTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.sourceTextBox = new System.Windows.Forms.TextBox();
			this.userTextBox = new System.Windows.Forms.TextBox();
			this.contextSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			catalogLabel = new System.Windows.Forms.Label();
			passwordLabel = new System.Windows.Forms.Label();
			sourceLabel = new System.Windows.Forms.Label();
			userLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.contextSettingsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// catalogLabel
			// 
			catalogLabel.AutoSize = true;
			catalogLabel.Location = new System.Drawing.Point(2, 32);
			catalogLabel.Name = "catalogLabel";
			catalogLabel.Size = new System.Drawing.Size(46, 13);
			catalogLabel.TabIndex = 1;
			catalogLabel.Text = "Catalog:";
			// 
			// catalogTextBox
			// 
			this.catalogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.catalogTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contextSettingsBindingSource, "Catalog", true));
			this.catalogTextBox.Location = new System.Drawing.Point(64, 29);
			this.catalogTextBox.Name = "catalogTextBox";
			this.catalogTextBox.Size = new System.Drawing.Size(108, 20);
			this.catalogTextBox.TabIndex = 2;
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Location = new System.Drawing.Point(2, 84);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new System.Drawing.Size(56, 13);
			passwordLabel.TabIndex = 3;
			passwordLabel.Text = "Password:";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contextSettingsBindingSource, "Password", true));
			this.passwordTextBox.Location = new System.Drawing.Point(64, 81);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(108, 20);
			this.passwordTextBox.TabIndex = 4;
			// 
			// sourceLabel
			// 
			sourceLabel.AutoSize = true;
			sourceLabel.Location = new System.Drawing.Point(2, 6);
			sourceLabel.Name = "sourceLabel";
			sourceLabel.Size = new System.Drawing.Size(44, 13);
			sourceLabel.TabIndex = 5;
			sourceLabel.Text = "Source:";
			// 
			// sourceTextBox
			// 
			this.sourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sourceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contextSettingsBindingSource, "Source", true));
			this.sourceTextBox.Location = new System.Drawing.Point(64, 3);
			this.sourceTextBox.Name = "sourceTextBox";
			this.sourceTextBox.Size = new System.Drawing.Size(108, 20);
			this.sourceTextBox.TabIndex = 6;
			// 
			// userLabel
			// 
			userLabel.AutoSize = true;
			userLabel.Location = new System.Drawing.Point(2, 58);
			userLabel.Name = "userLabel";
			userLabel.Size = new System.Drawing.Size(32, 13);
			userLabel.TabIndex = 7;
			userLabel.Text = "User:";
			// 
			// userTextBox
			// 
			this.userTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contextSettingsBindingSource, "User", true));
			this.userTextBox.Location = new System.Drawing.Point(64, 55);
			this.userTextBox.Name = "userTextBox";
			this.userTextBox.Size = new System.Drawing.Size(108, 20);
			this.userTextBox.TabIndex = 8;
			// 
			// contextSettingsBindingSource
			// 
			this.contextSettingsBindingSource.DataSource = typeof(CRM_MODEL.ContextSettings);
			// 
			// ContextSettingsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(catalogLabel);
			this.Controls.Add(this.catalogTextBox);
			this.Controls.Add(passwordLabel);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(sourceLabel);
			this.Controls.Add(this.sourceTextBox);
			this.Controls.Add(userLabel);
			this.Controls.Add(this.userTextBox);
			this.Name = "ContextSettingsView";
			this.Size = new System.Drawing.Size(175, 104);
			((System.ComponentModel.ISupportInitialize)(this.contextSettingsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource contextSettingsBindingSource;
		private System.Windows.Forms.TextBox catalogTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox sourceTextBox;
		private System.Windows.Forms.TextBox userTextBox;
	}
}
