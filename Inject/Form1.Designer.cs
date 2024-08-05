namespace Inject
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
            if (disposing && (components != null))
            {
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
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ruNetSearcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.росПоискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.платформаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шортсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вКонтактеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.почтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.браузерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.впередToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перезагрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсыВалютToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.юаньРубльToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рубльЮаньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рИАНовостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAILRUНовостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lENTAНовостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.телевидениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.первыйКаналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.россия1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.россия24ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нТВToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.рЕНТВToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тНТToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тНТToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 24);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(851, 576);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            this.webView21.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.webView21_NavigationStarting);
            this.webView21.WebMessageReceived += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs>(this.webView21_WebMessageReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ruNetSearcherToolStripMenuItem,
            this.браузерToolStripMenuItem,
            this.курсыВалютToolStripMenuItem,
            this.новостиToolStripMenuItem,
            this.телевидениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ruNetSearcherToolStripMenuItem
            // 
            this.ruNetSearcherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.росПоискToolStripMenuItem,
            this.платформаToolStripMenuItem,
            this.вКонтактеToolStripMenuItem,
            this.почтаToolStripMenuItem});
            this.ruNetSearcherToolStripMenuItem.Name = "ruNetSearcherToolStripMenuItem";
            this.ruNetSearcherToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ruNetSearcherToolStripMenuItem.Text = "RuNet";
            this.ruNetSearcherToolStripMenuItem.Click += new System.EventHandler(this.ruNetSearcherToolStripMenuItem_Click);
            // 
            // росПоискToolStripMenuItem
            // 
            this.росПоискToolStripMenuItem.Name = "росПоискToolStripMenuItem";
            this.росПоискToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.росПоискToolStripMenuItem.Text = "РосПоиск";
            this.росПоискToolStripMenuItem.Click += new System.EventHandler(this.росПоискToolStripMenuItem_Click);
            // 
            // платформаToolStripMenuItem
            // 
            this.платформаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шортсыToolStripMenuItem});
            this.платформаToolStripMenuItem.Name = "платформаToolStripMenuItem";
            this.платформаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.платформаToolStripMenuItem.Text = "Платформа";
            this.платформаToolStripMenuItem.Click += new System.EventHandler(this.платформаToolStripMenuItem_Click);
            // 
            // шортсыToolStripMenuItem
            // 
            this.шортсыToolStripMenuItem.Name = "шортсыToolStripMenuItem";
            this.шортсыToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.шортсыToolStripMenuItem.Text = "Шортсы";
            this.шортсыToolStripMenuItem.Click += new System.EventHandler(this.шортсыToolStripMenuItem_Click);
            // 
            // вКонтактеToolStripMenuItem
            // 
            this.вКонтактеToolStripMenuItem.Name = "вКонтактеToolStripMenuItem";
            this.вКонтактеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вКонтактеToolStripMenuItem.Text = "ВКонтакте";
            this.вКонтактеToolStripMenuItem.Click += new System.EventHandler(this.вКонтактеToolStripMenuItem_Click);
            // 
            // почтаToolStripMenuItem
            // 
            this.почтаToolStripMenuItem.Name = "почтаToolStripMenuItem";
            this.почтаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.почтаToolStripMenuItem.Text = "Почта Mail.Ru";
            this.почтаToolStripMenuItem.Click += new System.EventHandler(this.почтаToolStripMenuItem_Click);
            // 
            // браузерToolStripMenuItem
            // 
            this.браузерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem,
            this.впередToolStripMenuItem,
            this.перезагрузитьToolStripMenuItem});
            this.браузерToolStripMenuItem.Name = "браузерToolStripMenuItem";
            this.браузерToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.браузерToolStripMenuItem.Text = "Браузер";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // впередToolStripMenuItem
            // 
            this.впередToolStripMenuItem.Name = "впередToolStripMenuItem";
            this.впередToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.впередToolStripMenuItem.Text = "Вперед";
            this.впередToolStripMenuItem.Click += new System.EventHandler(this.впередToolStripMenuItem_Click);
            // 
            // перезагрузитьToolStripMenuItem
            // 
            this.перезагрузитьToolStripMenuItem.Name = "перезагрузитьToolStripMenuItem";
            this.перезагрузитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.перезагрузитьToolStripMenuItem.Text = "Перезагрузить";
            this.перезагрузитьToolStripMenuItem.Click += new System.EventHandler(this.перезагрузитьToolStripMenuItem_Click);
            // 
            // курсыВалютToolStripMenuItem
            // 
            this.курсыВалютToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.юаньРубльToolStripMenuItem,
            this.рубльЮаньToolStripMenuItem});
            this.курсыВалютToolStripMenuItem.Name = "курсыВалютToolStripMenuItem";
            this.курсыВалютToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.курсыВалютToolStripMenuItem.Text = "Курсы валют";
            // 
            // юаньРубльToolStripMenuItem
            // 
            this.юаньРубльToolStripMenuItem.Name = "юаньРубльToolStripMenuItem";
            this.юаньРубльToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.юаньРубльToolStripMenuItem.Text = "Юань-Рубль";
            this.юаньРубльToolStripMenuItem.Click += new System.EventHandler(this.юаньРубльToolStripMenuItem_Click);
            // 
            // рубльЮаньToolStripMenuItem
            // 
            this.рубльЮаньToolStripMenuItem.Name = "рубльЮаньToolStripMenuItem";
            this.рубльЮаньToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.рубльЮаньToolStripMenuItem.Text = "Рубль-Юань";
            this.рубльЮаньToolStripMenuItem.Click += new System.EventHandler(this.рубльЮаньToolStripMenuItem_Click);
            // 
            // новостиToolStripMenuItem
            // 
            this.новостиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рИАНовостиToolStripMenuItem,
            this.mAILRUНовостиToolStripMenuItem,
            this.lENTAНовостиToolStripMenuItem});
            this.новостиToolStripMenuItem.Name = "новостиToolStripMenuItem";
            this.новостиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.новостиToolStripMenuItem.Text = "Новости";
            // 
            // рИАНовостиToolStripMenuItem
            // 
            this.рИАНовостиToolStripMenuItem.Name = "рИАНовостиToolStripMenuItem";
            this.рИАНовостиToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.рИАНовостиToolStripMenuItem.Text = "РИА Новости";
            this.рИАНовостиToolStripMenuItem.Click += new System.EventHandler(this.рИАНовостиToolStripMenuItem_Click);
            // 
            // mAILRUНовостиToolStripMenuItem
            // 
            this.mAILRUНовостиToolStripMenuItem.Name = "mAILRUНовостиToolStripMenuItem";
            this.mAILRUНовостиToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.mAILRUНовостиToolStripMenuItem.Text = "MAIL.RU Новости";
            this.mAILRUНовостиToolStripMenuItem.Click += new System.EventHandler(this.mAILRUНовостиToolStripMenuItem_Click);
            // 
            // lENTAНовостиToolStripMenuItem
            // 
            this.lENTAНовостиToolStripMenuItem.Name = "lENTAНовостиToolStripMenuItem";
            this.lENTAНовостиToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.lENTAНовостиToolStripMenuItem.Text = "LENTA Новости";
            this.lENTAНовостиToolStripMenuItem.Click += new System.EventHandler(this.lENTAНовостиToolStripMenuItem_Click);
            // 
            // телевидениеToolStripMenuItem
            // 
            this.телевидениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.первыйКаналToolStripMenuItem,
            this.россия1ToolStripMenuItem,
            this.россия24ToolStripMenuItem,
            this.нТВToolStripMenuItem,
            this.toolStripMenuItem1,
            this.рЕНТВToolStripMenuItem,
            this.мирToolStripMenuItem,
            this.тНТToolStripMenuItem,
            this.тНТToolStripMenuItem1});
            this.телевидениеToolStripMenuItem.Name = "телевидениеToolStripMenuItem";
            this.телевидениеToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.телевидениеToolStripMenuItem.Text = "Телевидение";
            // 
            // первыйКаналToolStripMenuItem
            // 
            this.первыйКаналToolStripMenuItem.Name = "первыйКаналToolStripMenuItem";
            this.первыйКаналToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.первыйКаналToolStripMenuItem.Text = "Первый канал";
            this.первыйКаналToolStripMenuItem.Click += new System.EventHandler(this.первыйКаналToolStripMenuItem_Click);
            // 
            // россия1ToolStripMenuItem
            // 
            this.россия1ToolStripMenuItem.Name = "россия1ToolStripMenuItem";
            this.россия1ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.россия1ToolStripMenuItem.Text = "Россия 1";
            this.россия1ToolStripMenuItem.Click += new System.EventHandler(this.россия1ToolStripMenuItem_Click);
            // 
            // россия24ToolStripMenuItem
            // 
            this.россия24ToolStripMenuItem.Name = "россия24ToolStripMenuItem";
            this.россия24ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.россия24ToolStripMenuItem.Text = "Россия 24";
            this.россия24ToolStripMenuItem.Click += new System.EventHandler(this.россия24ToolStripMenuItem_Click);
            // 
            // нТВToolStripMenuItem
            // 
            this.нТВToolStripMenuItem.Name = "нТВToolStripMenuItem";
            this.нТВToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.нТВToolStripMenuItem.Text = "НТВ";
            this.нТВToolStripMenuItem.Click += new System.EventHandler(this.нТВToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem1.Text = "Пятый канал";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // рЕНТВToolStripMenuItem
            // 
            this.рЕНТВToolStripMenuItem.Name = "рЕНТВToolStripMenuItem";
            this.рЕНТВToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.рЕНТВToolStripMenuItem.Text = "РЕН-ТВ";
            this.рЕНТВToolStripMenuItem.Click += new System.EventHandler(this.рЕНТВToolStripMenuItem_Click);
            // 
            // мирToolStripMenuItem
            // 
            this.мирToolStripMenuItem.Name = "мирToolStripMenuItem";
            this.мирToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.мирToolStripMenuItem.Text = "Пятница";
            this.мирToolStripMenuItem.Click += new System.EventHandler(this.мирToolStripMenuItem_Click);
            // 
            // тНТToolStripMenuItem
            // 
            this.тНТToolStripMenuItem.Name = "тНТToolStripMenuItem";
            this.тНТToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.тНТToolStripMenuItem.Text = "Мир";
            this.тНТToolStripMenuItem.Click += new System.EventHandler(this.тНТToolStripMenuItem_Click);
            // 
            // тНТToolStripMenuItem1
            // 
            this.тНТToolStripMenuItem1.Name = "тНТToolStripMenuItem1";
            this.тНТToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.тНТToolStripMenuItem1.Text = "ТНТ";
            this.тНТToolStripMenuItem1.Click += new System.EventHandler(this.тНТToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 600);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "РуНет Браузер (Made In China)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ruNetSearcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem росПоискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem платформаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вКонтактеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem почтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шортсыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem браузерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem впередToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перезагрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсыВалютToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem юаньРубльToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рубльЮаньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рИАНовостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAILRUНовостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lENTAНовостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem телевидениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem первыйКаналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem россия1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem россия24ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нТВToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem рЕНТВToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тНТToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тНТToolStripMenuItem1;
    }
}

