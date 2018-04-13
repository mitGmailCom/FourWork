namespace Explorer_withListView_TreeView_RichBox_
{
    partial class formExplorerTreeview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formExplorerTreeview));
            this.txbPath = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewExpl = new System.Windows.Forms.TreeView();
            this.listViewExpl = new System.Windows.Forms.ListView();
            this.richTxbExpl = new System.Windows.Forms.RichTextBox();
            this.imageList1Large = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbPath
            // 
            this.txbPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPath.Location = new System.Drawing.Point(0, 24);
            this.txbPath.Name = "txbPath";
            this.txbPath.Size = new System.Drawing.Size(718, 20);
            this.txbPath.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showIconToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showIconToolStripMenuItem
            // 
            this.showIconToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem,
            this.smallIconToolStripMenuItem1,
            this.listToolStripMenuItem,
            this.tableToolStripMenuItem});
            this.showIconToolStripMenuItem.Name = "showIconToolStripMenuItem";
            this.showIconToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showIconToolStripMenuItem.Text = "ShowIcon";
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.largeIconToolStripMenuItem.Text = "Large";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // smallIconToolStripMenuItem1
            // 
            this.smallIconToolStripMenuItem1.Name = "smallIconToolStripMenuItem1";
            this.smallIconToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.smallIconToolStripMenuItem1.Text = "Small";
            this.smallIconToolStripMenuItem1.Click += new System.EventHandler(this.smallIconToolStripMenuItem1_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tableToolStripMenuItem.Text = "Table";
            this.tableToolStripMenuItem.Click += new System.EventHandler(this.tableToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // treeViewExpl
            // 
            this.treeViewExpl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewExpl.Location = new System.Drawing.Point(0, 44);
            this.treeViewExpl.Name = "treeViewExpl";
            this.treeViewExpl.Size = new System.Drawing.Size(189, 315);
            this.treeViewExpl.TabIndex = 2;
            this.treeViewExpl.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewExpl_AfterSelect);
            // 
            // listViewExpl
            // 
            this.listViewExpl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewExpl.Location = new System.Drawing.Point(189, 44);
            this.listViewExpl.Name = "listViewExpl";
            this.listViewExpl.Size = new System.Drawing.Size(250, 315);
            this.listViewExpl.TabIndex = 3;
            this.listViewExpl.UseCompatibleStateImageBehavior = false;
            // 
            // richTxbExpl
            // 
            this.richTxbExpl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxbExpl.Location = new System.Drawing.Point(439, 44);
            this.richTxbExpl.Name = "richTxbExpl";
            this.richTxbExpl.Size = new System.Drawing.Size(279, 315);
            this.richTxbExpl.TabIndex = 4;
            this.richTxbExpl.Text = "";
            // 
            // imageList1Large
            // 
            this.imageList1Large.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1Large.ImageStream")));
            this.imageList1Large.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1Large.Images.SetKeyName(0, "bltinmic.ico");
            // 
            // formExplorerTreeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 359);
            this.Controls.Add(this.richTxbExpl);
            this.Controls.Add(this.listViewExpl);
            this.Controls.Add(this.treeViewExpl);
            this.Controls.Add(this.txbPath);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formExplorerTreeview";
            this.Text = "Explorer";
            this.Load += new System.EventHandler(this.formExplorerTreeview_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.TreeView treeViewExpl;
        private System.Windows.Forms.ListView listViewExpl;
        private System.Windows.Forms.RichTextBox richTxbExpl;
        private System.Windows.Forms.ToolStripMenuItem showIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1Large;
    }
}

