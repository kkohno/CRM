﻿namespace CRM_VIEW
{
	partial class Form1
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.авторизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.crmController1 = new CRM_VIEW.CRMController(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторизацияToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// авторизацияToolStripMenuItem
			// 
			this.авторизацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.toolStripMenuItem1,
            this.регистрацияToolStripMenuItem});
			this.авторизацияToolStripMenuItem.Name = "авторизацияToolStripMenuItem";
			this.авторизацияToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
			this.авторизацияToolStripMenuItem.Text = "Пользователь";
			// 
			// входToolStripMenuItem
			// 
			this.входToolStripMenuItem.Name = "входToolStripMenuItem";
			this.входToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.входToolStripMenuItem.Text = "Вход";
			this.входToolStripMenuItem.Click += new System.EventHandler(this.входToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// crmController1
			// 
			this.crmController1.User = null;
			this.crmController1.OnAuthorized += new System.EventHandler<CRM_MODEL.User>(this.crmController1_OnAuthorized);
			this.crmController1.OnLogout += new System.EventHandler<CRM_MODEL.User>(this.crmController1_OnLogout);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
			// 
			// регистрацияToolStripMenuItem
			// 
			this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
			this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.регистрацияToolStripMenuItem.Text = "Регистрация";
			this.регистрацияToolStripMenuItem.Click += new System.EventHandler(this.регистрацияToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Главная";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CRMController crmController1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem авторизацияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem входToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
	}
}
