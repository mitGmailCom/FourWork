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
            this.txbPath = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.treeViewExpl = new System.Windows.Forms.TreeView();
            this.listViewExpl = new System.Windows.Forms.ListView();
            this.richTxbExpl = new System.Windows.Forms.RichTextBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbPath
            // 
            this.txbPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.txbPath.Location = new System.Drawing.Point(0, 24);
            this.txbPath.Name = "txbPath";
            this.txbPath.Size = new System.Drawing.Size(575, 20);
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
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // treeViewExpl
            // 
            this.treeViewExpl.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewExpl.Location = new System.Drawing.Point(0, 44);
            this.treeViewExpl.Name = "treeViewExpl";
            this.treeViewExpl.Size = new System.Drawing.Size(127, 315);
            this.treeViewExpl.TabIndex = 2;
            // 
            // listViewExpl
            // 
            this.listViewExpl.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewExpl.Location = new System.Drawing.Point(127, 44);
            this.listViewExpl.Name = "listViewExpl";
            this.listViewExpl.Size = new System.Drawing.Size(224, 315);
            this.listViewExpl.TabIndex = 3;
            this.listViewExpl.UseCompatibleStateImageBehavior = false;
            // 
            // richTxbExpl
            // 
            this.richTxbExpl.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTxbExpl.Location = new System.Drawing.Point(351, 44);
            this.richTxbExpl.Name = "richTxbExpl";
            this.richTxbExpl.Size = new System.Drawing.Size(224, 315);
            this.richTxbExpl.TabIndex = 4;
            this.richTxbExpl.Text = "";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // formExplorerTreeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 359);
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
    }
}

