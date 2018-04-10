namespace Explorer_WorkTwo_
{
    partial class Explorer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explorer));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnCreateFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownBtnEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.CtrlcToolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlzToolStripMenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlvToolStripMenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemColorFont = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.крупныеЗначкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мелкиеЗначкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listbDisk = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.удалитьDelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.Main.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.View.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Main);
            this.tabControl1.Controls.Add(this.View);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 57);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.toolStrip1);
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(832, 31);
            this.Main.TabIndex = 0;
            this.Main.Text = "Главная";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownBtnEdit,
            this.toolStripSeparator9,
            this.toolStripBtnCreateFolder});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(826, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnCreateFolder
            // 
            this.toolStripBtnCreateFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnCreateFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCreateFolder.Image")));
            this.toolStripBtnCreateFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCreateFolder.Name = "toolStripBtnCreateFolder";
            this.toolStripBtnCreateFolder.Size = new System.Drawing.Size(89, 22);
            this.toolStripBtnCreateFolder.Text = "Создать папку";
            this.toolStripBtnCreateFolder.Click += new System.EventHandler(this.toolStripBtnCreateFolder_Click);
            // 
            // toolStripDropDownBtnEdit
            // 
            this.toolStripDropDownBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownBtnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtrlcToolStripMenuItemCopy,
            this.CtrlzToolStripMenuItemCut,
            this.CtrlvToolStripMenuItemPaste,
            this.удалитьDelToolStripMenuItem});
            this.toolStripDropDownBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownBtnEdit.Image")));
            this.toolStripDropDownBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownBtnEdit.Name = "toolStripDropDownBtnEdit";
            this.toolStripDropDownBtnEdit.Size = new System.Drawing.Size(100, 22);
            this.toolStripDropDownBtnEdit.Text = "Редактировать";
            // 
            // CtrlcToolStripMenuItemCopy
            // 
            this.CtrlcToolStripMenuItemCopy.Name = "CtrlcToolStripMenuItemCopy";
            this.CtrlcToolStripMenuItemCopy.Size = new System.Drawing.Size(175, 22);
            this.CtrlcToolStripMenuItemCopy.Text = "Копировать Ctrl+c";
            this.CtrlcToolStripMenuItemCopy.Click += new System.EventHandler(this.CtrlcToolStripMenuItemCopy_Click);
            // 
            // CtrlzToolStripMenuItemCut
            // 
            this.CtrlzToolStripMenuItemCut.Name = "CtrlzToolStripMenuItemCut";
            this.CtrlzToolStripMenuItemCut.Size = new System.Drawing.Size(175, 22);
            this.CtrlzToolStripMenuItemCut.Text = "Вырезать Ctrl+z";
            this.CtrlzToolStripMenuItemCut.Click += new System.EventHandler(this.CtrlzToolStripMenuItemCut_Click);
            // 
            // CtrlvToolStripMenuItemPaste
            // 
            this.CtrlvToolStripMenuItemPaste.Name = "CtrlvToolStripMenuItemPaste";
            this.CtrlvToolStripMenuItemPaste.Size = new System.Drawing.Size(175, 22);
            this.CtrlvToolStripMenuItemPaste.Text = "Вставить Ctrl+v";
            this.CtrlvToolStripMenuItemPaste.Click += new System.EventHandler(this.CtrlvToolStripMenuItemPaste_Click);
            // 
            // View
            // 
            this.View.Controls.Add(this.toolStrip2);
            this.View.Location = new System.Drawing.Point(4, 22);
            this.View.Name = "View";
            this.View.Padding = new System.Windows.Forms.Padding(3);
            this.View.Size = new System.Drawing.Size(832, 31);
            this.View.TabIndex = 1;
            this.View.Text = "Вид";
            this.View.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripSeparator4,
            this.toolStripDropDownButton1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(826, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFont,
            this.ToolStripMenuItemColorFont,
            this.ToolStripMenuItemBackColor});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(116, 22);
            this.toolStripDropDownButton1.Text = "Форматирование";
            // 
            // ToolStripMenuItemFont
            // 
            this.ToolStripMenuItemFont.Name = "ToolStripMenuItemFont";
            this.ToolStripMenuItemFont.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemFont.Text = "Шрифт";
            this.ToolStripMenuItemFont.Click += new System.EventHandler(this.ToolStripMenuItemFont_Click);
            // 
            // ToolStripMenuItemColorFont
            // 
            this.ToolStripMenuItemColorFont.Name = "ToolStripMenuItemColorFont";
            this.ToolStripMenuItemColorFont.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemColorFont.Text = "Цвет шрифта";
            this.ToolStripMenuItemColorFont.Click += new System.EventHandler(this.ToolStripMenuItemColorFont_Click);
            // 
            // ToolStripMenuItemBackColor
            // 
            this.ToolStripMenuItemBackColor.Name = "ToolStripMenuItemBackColor";
            this.ToolStripMenuItemBackColor.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemBackColor.Text = "Фон";
            this.ToolStripMenuItemBackColor.Click += new System.EventHandler(this.ToolStripMenuItemBackColor_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.крупныеЗначкиToolStripMenuItem,
            this.мелкиеЗначкиToolStripMenuItem,
            this.списокToolStripMenuItem,
            this.таблицаToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(60, 22);
            this.toolStripDropDownButton2.Text = "Значки";
            // 
            // крупныеЗначкиToolStripMenuItem
            // 
            this.крупныеЗначкиToolStripMenuItem.Name = "крупныеЗначкиToolStripMenuItem";
            this.крупныеЗначкиToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.крупныеЗначкиToolStripMenuItem.Text = "Крупные значки";
            this.крупныеЗначкиToolStripMenuItem.Click += new System.EventHandler(this.крупныеЗначкиToolStripMenuItem_Click);
            // 
            // мелкиеЗначкиToolStripMenuItem
            // 
            this.мелкиеЗначкиToolStripMenuItem.Name = "мелкиеЗначкиToolStripMenuItem";
            this.мелкиеЗначкиToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.мелкиеЗначкиToolStripMenuItem.Text = "Мелкие значки";
            this.мелкиеЗначкиToolStripMenuItem.Click += new System.EventHandler(this.мелкиеЗначкиToolStripMenuItem_Click);
            // 
            // списокToolStripMenuItem
            // 
            this.списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            this.списокToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.списокToolStripMenuItem.Text = "Список";
            this.списокToolStripMenuItem.Click += new System.EventHandler(this.списокToolStripMenuItem_Click);
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.таблицаToolStripMenuItem.Text = "Таблица";
            this.таблицаToolStripMenuItem.Click += new System.EventHandler(this.таблицаToolStripMenuItem_Click);
            // 
            // listbDisk
            // 
            this.listbDisk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listbDisk.FormattingEnabled = true;
            this.listbDisk.Location = new System.Drawing.Point(0, 83);
            this.listbDisk.Name = "listbDisk";
            this.listbDisk.Size = new System.Drawing.Size(215, 290);
            this.listbDisk.TabIndex = 1;
            this.listbDisk.DoubleClick += new System.EventHandler(this.listbDisk_DoubleClick);
            this.listbDisk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listbDisk_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(836, 21);
            this.textBox1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 114);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Location = new System.Drawing.Point(218, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(617, 290);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // удалитьDelToolStripMenuItem
            // 
            this.удалитьDelToolStripMenuItem.Name = "удалитьDelToolStripMenuItem";
            this.удалитьDelToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.удалитьDelToolStripMenuItem.Text = "Удалить del";
            this.удалитьDelToolStripMenuItem.Click += new System.EventHandler(this.удалитьDelToolStripMenuItem_Click);
            // 
            // Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 375);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listbDisk);
            this.Controls.Add(this.tabControl1);
            this.Name = "Explorer";
            this.Text = "Проводник";
            this.Load += new System.EventHandler(this.Explorer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Explorer_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.View.ResumeLayout(false);
            this.View.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabPage View;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ListBox listbDisk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton toolStripBtnCreateFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownBtnEdit;
        private System.Windows.Forms.ToolStripMenuItem CtrlcToolStripMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem CtrlzToolStripMenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem CtrlvToolStripMenuItemPaste;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFont;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemColorFont;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBackColor;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem крупныеЗначкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мелкиеЗначкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьDelToolStripMenuItem;
    }
}

