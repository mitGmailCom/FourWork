namespace DZ4
{
    partial class TextEditor
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.menuStripTextEditor = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextEditor = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.colorFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txbTextEditor = new System.Windows.Forms.TextBox();
            this.contextMenuStripTextEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTextEditor.SuspendLayout();
            this.toolStripTextEditor.SuspendLayout();
            this.contextMenuStripTextEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTextEditor
            // 
            this.menuStripTextEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.settingsEditorToolStripMenuItem});
            this.menuStripTextEditor.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStripTextEditor.Location = new System.Drawing.Point(0, 0);
            this.menuStripTextEditor.Name = "menuStripTextEditor";
            this.menuStripTextEditor.Size = new System.Drawing.Size(704, 23);
            this.menuStripTextEditor.TabIndex = 0;
            this.menuStripTextEditor.Text = "menuStripTextEditor";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // settingsEditorToolStripMenuItem
            // 
            this.settingsEditorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.colorToolStripMenuItem1,
            this.fontToolStripMenuItem});
            this.settingsEditorToolStripMenuItem.Name = "settingsEditorToolStripMenuItem";
            this.settingsEditorToolStripMenuItem.Size = new System.Drawing.Size(92, 19);
            this.settingsEditorToolStripMenuItem.Text = "SettingsEditor";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.colorToolStripMenuItem.Text = "Color Font";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem1
            // 
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.colorToolStripMenuItem1.Text = "Color Background";
            this.colorToolStripMenuItem1.Click += new System.EventHandler(this.colorToolStripMenuItem1_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // toolStripTextEditor
            // 
            this.toolStripTextEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonFile,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStripTextEditor.Location = new System.Drawing.Point(0, 23);
            this.toolStripTextEditor.Name = "toolStripTextEditor";
            this.toolStripTextEditor.Size = new System.Drawing.Size(704, 25);
            this.toolStripTextEditor.TabIndex = 1;
            this.toolStripTextEditor.Text = "toolStripTextEditor";
            // 
            // toolStripDropDownButtonFile
            // 
            this.toolStripDropDownButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.newToolStripMenuItem1});
            this.toolStripDropDownButtonFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFile.Image")));
            this.toolStripDropDownButtonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFile.Name = "toolStripDropDownButtonFile";
            this.toolStripDropDownButtonFile.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButtonFile.Text = "toolStripFile";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem1.Image")));
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem1.Image")));
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem1.Image")));
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.cutToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.undoToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem1.Image")));
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem1.Image")));
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.cutToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem1.Image")));
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorFontToolStripMenuItem,
            this.colorToolStripMenuItem2,
            this.fonToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton3.Text = "toolStripDropDownButton3";
            // 
            // colorFontToolStripMenuItem
            // 
            this.colorFontToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorFontToolStripMenuItem.Image")));
            this.colorFontToolStripMenuItem.Name = "colorFontToolStripMenuItem";
            this.colorFontToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.colorFontToolStripMenuItem.Text = "Color Font";
            this.colorFontToolStripMenuItem.Click += new System.EventHandler(this.colorFontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem2
            // 
            this.colorToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("colorToolStripMenuItem2.Image")));
            this.colorToolStripMenuItem2.Name = "colorToolStripMenuItem2";
            this.colorToolStripMenuItem2.Size = new System.Drawing.Size(170, 22);
            this.colorToolStripMenuItem2.Text = "Color Background";
            this.colorToolStripMenuItem2.Click += new System.EventHandler(this.colorToolStripMenuItem2_Click);
            // 
            // fonToolStripMenuItem
            // 
            this.fonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fonToolStripMenuItem.Image")));
            this.fonToolStripMenuItem.Name = "fonToolStripMenuItem";
            this.fonToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fonToolStripMenuItem.Text = "Font";
            this.fonToolStripMenuItem.Click += new System.EventHandler(this.fonToolStripMenuItem_Click);
            // 
            // txbTextEditor
            // 
            this.txbTextEditor.ContextMenuStrip = this.contextMenuStripTextEditor;
            this.txbTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbTextEditor.Location = new System.Drawing.Point(0, 48);
            this.txbTextEditor.Multiline = true;
            this.txbTextEditor.Name = "txbTextEditor";
            this.txbTextEditor.Size = new System.Drawing.Size(704, 350);
            this.txbTextEditor.TabIndex = 2;
            // 
            // contextMenuStripTextEditor
            // 
            this.contextMenuStripTextEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem2,
            this.cutToolStripMenuItem2,
            this.pasteToolStripMenuItem2,
            this.undoToolStripMenuItem1});
            this.contextMenuStripTextEditor.Name = "contextMenuStrip1";
            this.contextMenuStripTextEditor.Size = new System.Drawing.Size(104, 92);
            // 
            // copyToolStripMenuItem2
            // 
            this.copyToolStripMenuItem2.Name = "copyToolStripMenuItem2";
            this.copyToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem2.Text = "Copy";
            this.copyToolStripMenuItem2.Click += new System.EventHandler(this.copyToolStripMenuItem2_Click);
            // 
            // cutToolStripMenuItem2
            // 
            this.cutToolStripMenuItem2.Name = "cutToolStripMenuItem2";
            this.cutToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem2.Text = "Cut";
            this.cutToolStripMenuItem2.Click += new System.EventHandler(this.cutToolStripMenuItem2_Click);
            // 
            // pasteToolStripMenuItem2
            // 
            this.pasteToolStripMenuItem2.Name = "pasteToolStripMenuItem2";
            this.pasteToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem2.Text = "Paste";
            this.pasteToolStripMenuItem2.Click += new System.EventHandler(this.pasteToolStripMenuItem2_Click);
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem1.Text = "Undo";
            this.undoToolStripMenuItem1.Click += new System.EventHandler(this.undoToolStripMenuItem1_Click);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 398);
            this.Controls.Add(this.txbTextEditor);
            this.Controls.Add(this.toolStripTextEditor);
            this.Controls.Add(this.menuStripTextEditor);
            this.Name = "TextEditor";
            this.Text = "Editor";
            this.menuStripTextEditor.ResumeLayout(false);
            this.menuStripTextEditor.PerformLayout();
            this.toolStripTextEditor.ResumeLayout(false);
            this.toolStripTextEditor.PerformLayout();
            this.contextMenuStripTextEditor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTextEditor;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripTextEditor;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem colorFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fonToolStripMenuItem;
        private System.Windows.Forms.TextBox txbTextEditor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTextEditor;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
    }
}

