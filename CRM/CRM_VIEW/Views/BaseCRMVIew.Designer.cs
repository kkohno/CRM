﻿namespace CRM_VIEW.Views
{
	partial class BaseCRMVIew
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
			this.crmdbContextController = new CRM_VIEW.CRMDBContextController(this.components);
			this.SuspendLayout();
			// 
			// crmdbContextController
			// 
			this.crmdbContextController.ContainerForm = this;
			// 
			// BaseCRMVIew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "BaseCRMVIew";
			this.Load += new System.EventHandler(this.BaseCRMVIew_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private CRMDBContextController crmdbContextController;
	}
}
