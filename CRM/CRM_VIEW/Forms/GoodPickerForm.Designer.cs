namespace CRM_VIEW.Forms
{
	partial class GoodPickerForm
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
			CRM_MODEL.CRMDBContext crmdbContext1 = new CRM_MODEL.CRMDBContext();
			CRM_MODEL.CRMDBContext crmdbContext2 = new CRM_MODEL.CRMDBContext();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.ResetButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.goodsBrowser1 = new CRM_VIEW.Views.GoodsBrowser();
			this.crmdbContextController1 = new CRM_VIEW.CRMDBContextController(this.components);
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.ResetButton);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 269);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(712, 30);
			this.panel1.TabIndex = 1;
			// 
			// button3
			// 
			this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button3.Location = new System.Drawing.Point(191, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Отмена";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// ResetButton
			// 
			this.ResetButton.Location = new System.Drawing.Point(84, 3);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(75, 23);
			this.ResetButton.TabIndex = 1;
			this.ResetButton.Text = "Сброс";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// goodsBrowser1
			// 
			this.goodsBrowser1.Context = crmdbContext1;
			this.goodsBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.goodsBrowser1.Location = new System.Drawing.Point(0, 0);
			this.goodsBrowser1.Name = "goodsBrowser1";
			this.goodsBrowser1.SelectedGood = null;
			this.goodsBrowser1.Size = new System.Drawing.Size(712, 269);
			this.goodsBrowser1.TabIndex = 0;
			this.goodsBrowser1.OnRowDoubleClick += new System.EventHandler(this.goodsBrowser1_OnRowDoubleClick);
			// 
			// crmdbContextController1
			// 
			this.crmdbContextController1.ContainerForm = this;
			this.crmdbContextController1.Context = crmdbContext2;
			// 
			// GoodPickerForm
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 299);
			this.Controls.Add(this.goodsBrowser1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "GoodPickerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Выберите товар";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Views.GoodsBrowser goodsBrowser1;
		private System.Windows.Forms.Panel panel1;
		private CRMDBContextController crmdbContextController1;
		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.Button ResetButton;
		public System.Windows.Forms.Button button3;
	}
}