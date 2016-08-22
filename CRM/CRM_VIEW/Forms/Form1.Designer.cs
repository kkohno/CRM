namespace CRM_VIEW
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
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.типыТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оформитьПродажуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.рекламаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.типыРекламыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.типыПлатежейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.платежиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.людиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.подключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.crmController1 = new CRM_VIEW.CRMController(this.components);
			this.рекламаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторизацияToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.рекламаToolStripMenuItem,
            this.выплатыToolStripMenuItem,
            this.администрированиеToolStripMenuItem,
            this.настройкиToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(604, 24);
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
			this.входToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.входToolStripMenuItem.Text = "Вход";
			this.входToolStripMenuItem.Click += new System.EventHandler(this.входToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 6);
			// 
			// регистрацияToolStripMenuItem
			// 
			this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
			this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.регистрацияToolStripMenuItem.Text = "Регистрация";
			this.регистрацияToolStripMenuItem.Click += new System.EventHandler(this.регистрацияToolStripMenuItem_Click);
			// 
			// справочникиToolStripMenuItem
			// 
			this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типыТоваровToolStripMenuItem,
            this.toolStripMenuItem3,
            this.поставщикиToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.toolStripMenuItem4,
            this.складToolStripMenuItem,
            this.toolStripMenuItem2,
            this.продажиToolStripMenuItem,
            this.оформитьПродажуToolStripMenuItem});
			this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
			this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.справочникиToolStripMenuItem.Text = "Торговля";
			// 
			// типыТоваровToolStripMenuItem
			// 
			this.типыТоваровToolStripMenuItem.Name = "типыТоваровToolStripMenuItem";
			this.типыТоваровToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.типыТоваровToolStripMenuItem.Text = "Типы товаров";
			this.типыТоваровToolStripMenuItem.Click += new System.EventHandler(this.типыТоваровToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 6);
			// 
			// поставщикиToolStripMenuItem
			// 
			this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
			this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.поставщикиToolStripMenuItem.Text = "Поставщики";
			this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
			// 
			// товарыToolStripMenuItem
			// 
			this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
			this.товарыToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.товарыToolStripMenuItem.Text = "Товары";
			this.товарыToolStripMenuItem.Click += new System.EventHandler(this.товарыToolStripMenuItem_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 6);
			// 
			// складToolStripMenuItem
			// 
			this.складToolStripMenuItem.Name = "складToolStripMenuItem";
			this.складToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.складToolStripMenuItem.Text = "Склад";
			this.складToolStripMenuItem.Click += new System.EventHandler(this.складToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 6);
			// 
			// продажиToolStripMenuItem
			// 
			this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
			this.продажиToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.продажиToolStripMenuItem.Text = "Продажи";
			this.продажиToolStripMenuItem.Click += new System.EventHandler(this.продажиToolStripMenuItem_Click);
			// 
			// оформитьПродажуToolStripMenuItem
			// 
			this.оформитьПродажуToolStripMenuItem.Name = "оформитьПродажуToolStripMenuItem";
			this.оформитьПродажуToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.оформитьПродажуToolStripMenuItem.Text = "Оформить продажу";
			this.оформитьПродажуToolStripMenuItem.Click += new System.EventHandler(this.оформитьПродажуToolStripMenuItem_Click);
			// 
			// рекламаToolStripMenuItem
			// 
			this.рекламаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типыРекламыToolStripMenuItem,
            this.рекламаToolStripMenuItem1});
			this.рекламаToolStripMenuItem.Name = "рекламаToolStripMenuItem";
			this.рекламаToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.рекламаToolStripMenuItem.Text = "Реклама";
			// 
			// типыРекламыToolStripMenuItem
			// 
			this.типыРекламыToolStripMenuItem.Name = "типыРекламыToolStripMenuItem";
			this.типыРекламыToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.типыРекламыToolStripMenuItem.Text = "Типы рекламы";
			this.типыРекламыToolStripMenuItem.Click += new System.EventHandler(this.типыРекламыToolStripMenuItem_Click);
			// 
			// выплатыToolStripMenuItem
			// 
			this.выплатыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типыПлатежейToolStripMenuItem,
            this.платежиToolStripMenuItem});
			this.выплатыToolStripMenuItem.Name = "выплатыToolStripMenuItem";
			this.выплатыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.выплатыToolStripMenuItem.Text = "Выплаты";
			// 
			// типыПлатежейToolStripMenuItem
			// 
			this.типыПлатежейToolStripMenuItem.Name = "типыПлатежейToolStripMenuItem";
			this.типыПлатежейToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.типыПлатежейToolStripMenuItem.Text = "Типы платежей";
			this.типыПлатежейToolStripMenuItem.Click += new System.EventHandler(this.типыПлатежейToolStripMenuItem_Click);
			// 
			// платежиToolStripMenuItem
			// 
			this.платежиToolStripMenuItem.Name = "платежиToolStripMenuItem";
			this.платежиToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.платежиToolStripMenuItem.Text = "Платежи";
			this.платежиToolStripMenuItem.Click += new System.EventHandler(this.платежиToolStripMenuItem_Click);
			// 
			// администрированиеToolStripMenuItem
			// 
			this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.людиToolStripMenuItem});
			this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
			this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
			this.администрированиеToolStripMenuItem.Text = "Администрирование";
			// 
			// людиToolStripMenuItem
			// 
			this.людиToolStripMenuItem.Name = "людиToolStripMenuItem";
			this.людиToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.людиToolStripMenuItem.Text = "Люди";
			this.людиToolStripMenuItem.Click += new System.EventHandler(this.людиToolStripMenuItem_Click);
			// 
			// настройкиToolStripMenuItem
			// 
			this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеToolStripMenuItem});
			this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
			this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.настройкиToolStripMenuItem.Text = "Настройки";
			// 
			// подключениеToolStripMenuItem
			// 
			this.подключениеToolStripMenuItem.Name = "подключениеToolStripMenuItem";
			this.подключениеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.подключениеToolStripMenuItem.Text = "Подключение";
			this.подключениеToolStripMenuItem.Click += new System.EventHandler(this.подключениеToolStripMenuItem_Click);
			// 
			// crmController1
			// 
			this.crmController1.User = null;
			this.crmController1.OnAuthorized += new System.EventHandler<CRM_MODEL.User>(this.crmController1_OnAuthorized);
			this.crmController1.OnLogout += new System.EventHandler<CRM_MODEL.User>(this.crmController1_OnLogout);
			// 
			// рекламаToolStripMenuItem1
			// 
			this.рекламаToolStripMenuItem1.Name = "рекламаToolStripMenuItem1";
			this.рекламаToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
			this.рекламаToolStripMenuItem1.Text = "Реклама";
			this.рекламаToolStripMenuItem1.Click += new System.EventHandler(this.рекламаToolStripMenuItem1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 52);
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
		private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem типыТоваровToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem оформитьПродажуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem подключениеToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem людиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выплатыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem типыПлатежейToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem платежиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem рекламаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem типыРекламыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem рекламаToolStripMenuItem1;
	}
}
