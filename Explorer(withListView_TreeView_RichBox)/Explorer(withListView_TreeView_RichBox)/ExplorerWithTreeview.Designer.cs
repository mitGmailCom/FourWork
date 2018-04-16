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
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewExpl = new System.Windows.Forms.TreeView();
            this.listViewExpl = new System.Windows.Forms.ListView();
            this.richTxbExpl = new System.Windows.Forms.RichTextBox();
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.txbPath.Size = new System.Drawing.Size(771, 20);
            this.txbPath.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.tableToolStripMenuItem,
            this.titleToolStripMenuItem});
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
            // treeViewExpl
            // 
            this.treeViewExpl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewExpl.Location = new System.Drawing.Point(0, 44);
            this.treeViewExpl.Name = "treeViewExpl";
            this.treeViewExpl.Size = new System.Drawing.Size(189, 315);
            this.treeViewExpl.TabIndex = 2;
            this.treeViewExpl.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewExpl_AfterSelect);
            // 
            // listViewExpl
            // 
            this.listViewExpl.Location = new System.Drawing.Point(189, 44);
            this.listViewExpl.Name = "listViewExpl";
            this.listViewExpl.Size = new System.Drawing.Size(310, 201);
            this.listViewExpl.TabIndex = 3;
            this.listViewExpl.UseCompatibleStateImageBehavior = false;
            this.listViewExpl.SelectedIndexChanged += new System.EventHandler(this.listViewExpl_SelectedIndexChanged);
            this.listViewExpl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewExpl_MouseDown);
            // 
            // richTxbExpl
            // 
            this.richTxbExpl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxbExpl.Location = new System.Drawing.Point(498, 44);
            this.richTxbExpl.Name = "richTxbExpl";
            this.richTxbExpl.Size = new System.Drawing.Size(273, 315);
            this.richTxbExpl.TabIndex = 4;
            this.richTxbExpl.Text = "";
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.titleToolStripMenuItem.Text = "Title";
            this.titleToolStripMenuItem.Click += new System.EventHandler(this.titleToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(191, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(191, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(191, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(191, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(191, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(191, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(191, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label8.Location = new System.Drawing.Point(306, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 15);
            this.label8.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label9.Location = new System.Drawing.Point(306, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 15);
            this.label9.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label10.Location = new System.Drawing.Point(306, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 15);
            this.label10.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label11.Location = new System.Drawing.Point(306, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 15);
            this.label11.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label12.Location = new System.Drawing.Point(306, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 15);
            this.label12.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label13.Location = new System.Drawing.Point(306, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 15);
            this.label13.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label14.Location = new System.Drawing.Point(306, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 15);
            this.label14.TabIndex = 25;
            // 
            // formExplorerTreeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 359);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.TreeView treeViewExpl;
        private System.Windows.Forms.ListView listViewExpl;
        private System.Windows.Forms.RichTextBox richTxbExpl;
        private System.Windows.Forms.ToolStripMenuItem showIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

