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
            this.toolStripBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnCreateFolder = new System.Windows.Forms.ToolStripButton();
            this.View = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnLargeIc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnSmallIc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnColorFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnBackColor = new System.Windows.Forms.ToolStripButton();
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
            this.tabControl1.Size = new System.Drawing.Size(628, 57);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.toolStrip1);
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(620, 31);
            this.Main.TabIndex = 0;
            this.Main.Text = "Главная";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnCopy,
            this.toolStripSeparator7,
            this.toolStripBtnCut,
            this.toolStripSeparator10,
            this.toolStripBtnPaste,
            this.toolStripSeparator9,
            this.toolStripBtnCreateFolder});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(614, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnCopy
            // 
            this.toolStripBtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCopy.Image")));
            this.toolStripBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCopy.Name = "toolStripBtnCopy";
            this.toolStripBtnCopy.Size = new System.Drawing.Size(112, 22);
            this.toolStripBtnCopy.Text = "Копировать Ctrl+c";
            this.toolStripBtnCopy.Click += new System.EventHandler(this.toolStripBtnCopy_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnCut
            // 
            this.toolStripBtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCut.Image")));
            this.toolStripBtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCut.Name = "toolStripBtnCut";
            this.toolStripBtnCut.Size = new System.Drawing.Size(97, 22);
            this.toolStripBtnCut.Text = "Вырезать Ctrl+z";
            this.toolStripBtnCut.Click += new System.EventHandler(this.toolStripBtnCut_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnPaste
            // 
            this.toolStripBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPaste.Image")));
            this.toolStripBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPaste.Name = "toolStripBtnPaste";
            this.toolStripBtnPaste.Size = new System.Drawing.Size(95, 22);
            this.toolStripBtnPaste.Text = "Вставить Ctrl+v";
            this.toolStripBtnPaste.Click += new System.EventHandler(this.toolStripBtnPaste_Click);
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
            // View
            // 
            this.View.Controls.Add(this.toolStrip2);
            this.View.Location = new System.Drawing.Point(4, 22);
            this.View.Name = "View";
            this.View.Padding = new System.Windows.Forms.Padding(3);
            this.View.Size = new System.Drawing.Size(620, 31);
            this.View.TabIndex = 1;
            this.View.Text = "Вид";
            this.View.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnLargeIc,
            this.toolStripSeparator2,
            this.toolStripBtnSmallIc,
            this.toolStripSeparator3,
            this.toolStripBtnList,
            this.toolStripSeparator6,
            this.toolStripBtnTable,
            this.toolStripSeparator1,
            this.toolStripBtnFont,
            this.toolStripSeparator4,
            this.toolStripBtnColorFont,
            this.toolStripSeparator5,
            this.toolStripBtnBackColor});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(614, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripBtnLargeIc
            // 
            this.toolStripBtnLargeIc.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBtnLargeIc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripBtnLargeIc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnLargeIc.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLargeIc.Image")));
            this.toolStripBtnLargeIc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLargeIc.Name = "toolStripBtnLargeIc";
            this.toolStripBtnLargeIc.Size = new System.Drawing.Size(101, 22);
            this.toolStripBtnLargeIc.Text = "Крупные значки";
            this.toolStripBtnLargeIc.Click += new System.EventHandler(this.toolStripBtnLargeIc_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnSmallIc
            // 
            this.toolStripBtnSmallIc.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBtnSmallIc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnSmallIc.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSmallIc.Image")));
            this.toolStripBtnSmallIc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSmallIc.Name = "toolStripBtnSmallIc";
            this.toolStripBtnSmallIc.Size = new System.Drawing.Size(95, 22);
            this.toolStripBtnSmallIc.Text = "Мелкие значки";
            this.toolStripBtnSmallIc.Click += new System.EventHandler(this.toolStripBtnSmallIc_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnList
            // 
            this.toolStripBtnList.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBtnList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnList.Image")));
            this.toolStripBtnList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnList.Name = "toolStripBtnList";
            this.toolStripBtnList.Size = new System.Drawing.Size(52, 22);
            this.toolStripBtnList.Text = "Список";
            this.toolStripBtnList.Click += new System.EventHandler(this.toolStripBtnList_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnTable
            // 
            this.toolStripBtnTable.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBtnTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnTable.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnTable.Image")));
            this.toolStripBtnTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnTable.Name = "toolStripBtnTable";
            this.toolStripBtnTable.Size = new System.Drawing.Size(58, 22);
            this.toolStripBtnTable.Text = "Таблица";
            this.toolStripBtnTable.Click += new System.EventHandler(this.toolStripBtnTable_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnFont
            // 
            this.toolStripBtnFont.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBtnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnFont.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnFont.Image")));
            this.toolStripBtnFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnFont.Name = "toolStripBtnFont";
            this.toolStripBtnFont.Size = new System.Drawing.Size(50, 22);
            this.toolStripBtnFont.Text = "Шрифт";
            this.toolStripBtnFont.Click += new System.EventHandler(this.toolStripBtnFont_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnColorFont
            // 
            this.toolStripBtnColorFont.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBtnColorFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnColorFont.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnColorFont.Image")));
            this.toolStripBtnColorFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnColorFont.Name = "toolStripBtnColorFont";
            this.toolStripBtnColorFont.Size = new System.Drawing.Size(85, 22);
            this.toolStripBtnColorFont.Text = "Цвет шрифта";
            this.toolStripBtnColorFont.Click += new System.EventHandler(this.toolStripBtnColorFont_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnBackColor
            // 
            this.toolStripBtnBackColor.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBtnBackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnBackColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnBackColor.Image")));
            this.toolStripBtnBackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBackColor.Name = "toolStripBtnBackColor";
            this.toolStripBtnBackColor.Size = new System.Drawing.Size(34, 22);
            this.toolStripBtnBackColor.Text = "Фон";
            this.toolStripBtnBackColor.Click += new System.EventHandler(this.toolStripBtnBackColor_Click);
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
            this.textBox1.Size = new System.Drawing.Size(624, 21);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 136);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
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
            this.listView1.Size = new System.Drawing.Size(405, 290);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 375);
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
        private System.Windows.Forms.ToolStripButton toolStripBtnCopy;
        private System.Windows.Forms.ToolStripButton toolStripBtnCut;
        private System.Windows.Forms.ToolStripButton toolStripBtnPaste;
        private System.Windows.Forms.ToolStripButton toolStripBtnCreateFolder;
        private System.Windows.Forms.ToolStripButton toolStripBtnLargeIc;
        private System.Windows.Forms.ToolStripButton toolStripBtnSmallIc;
        private System.Windows.Forms.ToolStripButton toolStripBtnList;
        private System.Windows.Forms.ToolStripButton toolStripBtnTable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnFont;
        private System.Windows.Forms.ToolStripButton toolStripBtnColorFont;
        private System.Windows.Forms.ToolStripButton toolStripBtnBackColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
    }
}

