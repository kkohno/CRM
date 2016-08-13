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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserView));
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
			this.personPersonView = new CRM_VIEW.Views.PersonView();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(CRM_MODEL.User);
			// 
			// isAdminCheckBox
			// 
			this.isAdminCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.isAdminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userBindingSource, "IsAdmin", true));
			this.isAdminCheckBox.Location = new System.Drawing.Point(62, 82);
			this.isAdminCheckBox.Name = "isAdminCheckBox";
			this.isAdminCheckBox.Size = new System.Drawing.Size(144, 24);
			this.isAdminCheckBox.TabIndex = 2;
			this.isAdminCheckBox.Text = "Админ";
			this.isAdminCheckBox.UseVisualStyleBackColor = true;
			// 
			// personPersonView
			// 
			this.personPersonView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.personPersonView.DataBindings.Add(new System.Windows.Forms.Binding("Person", this.userBindingSource, "Person", true));
			this.personPersonView.Location = new System.Drawing.Point(0, 0);
			this.personPersonView.Name = "personPersonView";
			this.personPersonView.Person = ((CRM_MODEL.Person)(resources.GetObject("personPersonView.Person")));
			this.personPersonView.Size = new System.Drawing.Size(206, 81);
			this.personPersonView.TabIndex = 1;
			// 
			// UserView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.isAdminCheckBox);
			this.Controls.Add(this.personPersonView);
			this.Name = "UserView";
			this.Size = new System.Drawing.Size(206, 109);
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource userBindingSource;
		private System.Windows.Forms.CheckBox isAdminCheckBox;
		private PersonView personPersonView;
	}
}
