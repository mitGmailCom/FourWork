namespace Project_Create_Menu
{
    partial class FormCreateMenu
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
            this.lblAddTopLevelMenu = new System.Windows.Forms.Label();
            this.lblAddSubItem = new System.Windows.Forms.Label();
            this.txbAddSubItem = new System.Windows.Forms.TextBox();
            this.txbAddTopLevelMenu = new System.Windows.Forms.TextBox();
            this.btnAddTopLevelMenu = new System.Windows.Forms.Button();
            this.btnAddSubItem = new System.Windows.Forms.Button();
            this.grbAddTopLevelMenu = new System.Windows.Forms.GroupBox();
            this.grbAddSubItem = new System.Windows.Forms.GroupBox();
            this.grbAddTopLevelMenu.SuspendLayout();
            this.grbAddSubItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddTopLevelMenu
            // 
            this.lblAddTopLevelMenu.AutoSize = true;
            this.lblAddTopLevelMenu.Location = new System.Drawing.Point(30, 29);
            this.lblAddTopLevelMenu.Name = "lblAddTopLevelMenu";
            this.lblAddTopLevelMenu.Size = new System.Drawing.Size(98, 13);
            this.lblAddTopLevelMenu.TabIndex = 0;
            this.lblAddTopLevelMenu.Text = "AddTopLevelMenu";
            // 
            // lblAddSubItem
            // 
            this.lblAddSubItem.AutoSize = true;
            this.lblAddSubItem.Location = new System.Drawing.Point(50, 29);
            this.lblAddSubItem.Name = "lblAddSubItem";
            this.lblAddSubItem.Size = new System.Drawing.Size(65, 13);
            this.lblAddSubItem.TabIndex = 1;
            this.lblAddSubItem.Text = "AddSubItem";
            // 
            // txbAddSubItem
            // 
            this.txbAddSubItem.Location = new System.Drawing.Point(6, 52);
            this.txbAddSubItem.Name = "txbAddSubItem";
            this.txbAddSubItem.Size = new System.Drawing.Size(152, 20);
            this.txbAddSubItem.TabIndex = 2;
            // 
            // txbAddTopLevelMenu
            // 
            this.txbAddTopLevelMenu.Location = new System.Drawing.Point(6, 52);
            this.txbAddTopLevelMenu.Name = "txbAddTopLevelMenu";
            this.txbAddTopLevelMenu.Size = new System.Drawing.Size(152, 20);
            this.txbAddTopLevelMenu.TabIndex = 3;
            // 
            // btnAddTopLevelMenu
            // 
            this.btnAddTopLevelMenu.Location = new System.Drawing.Point(6, 99);
            this.btnAddTopLevelMenu.Name = "btnAddTopLevelMenu";
            this.btnAddTopLevelMenu.Size = new System.Drawing.Size(152, 41);
            this.btnAddTopLevelMenu.TabIndex = 4;
            this.btnAddTopLevelMenu.Text = "AddTopLevelMenu";
            this.btnAddTopLevelMenu.UseVisualStyleBackColor = true;
            this.btnAddTopLevelMenu.Click += new System.EventHandler(this.btnAddTopLevelMenu_Click);
            // 
            // btnAddSubItem
            // 
            this.btnAddSubItem.Location = new System.Drawing.Point(6, 99);
            this.btnAddSubItem.Name = "btnAddSubItem";
            this.btnAddSubItem.Size = new System.Drawing.Size(152, 41);
            this.btnAddSubItem.TabIndex = 5;
            this.btnAddSubItem.Text = "AddSubItem";
            this.btnAddSubItem.UseVisualStyleBackColor = true;
            // 
            // grbAddTopLevelMenu
            // 
            this.grbAddTopLevelMenu.Controls.Add(this.lblAddTopLevelMenu);
            this.grbAddTopLevelMenu.Controls.Add(this.txbAddTopLevelMenu);
            this.grbAddTopLevelMenu.Controls.Add(this.btnAddTopLevelMenu);
            this.grbAddTopLevelMenu.Location = new System.Drawing.Point(3, 32);
            this.grbAddTopLevelMenu.Name = "grbAddTopLevelMenu";
            this.grbAddTopLevelMenu.Size = new System.Drawing.Size(164, 146);
            this.grbAddTopLevelMenu.TabIndex = 6;
            this.grbAddTopLevelMenu.TabStop = false;
            this.grbAddTopLevelMenu.Text = "AddTopLevelMenu";
            // 
            // grbAddSubItem
            // 
            this.grbAddSubItem.Controls.Add(this.lblAddSubItem);
            this.grbAddSubItem.Controls.Add(this.txbAddSubItem);
            this.grbAddSubItem.Controls.Add(this.btnAddSubItem);
            this.grbAddSubItem.Location = new System.Drawing.Point(178, 32);
            this.grbAddSubItem.Name = "grbAddSubItem";
            this.grbAddSubItem.Size = new System.Drawing.Size(164, 146);
            this.grbAddSubItem.TabIndex = 7;
            this.grbAddSubItem.TabStop = false;
            this.grbAddSubItem.Text = "AddSubItem";
            // 
            // FormCreateMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 201);
            this.Controls.Add(this.grbAddSubItem);
            this.Controls.Add(this.grbAddTopLevelMenu);
            this.Name = "FormCreateMenu";
            this.Text = "Create Menu";
            this.Load += new System.EventHandler(this.FormCreateMenu_Load);
            this.grbAddTopLevelMenu.ResumeLayout(false);
            this.grbAddTopLevelMenu.PerformLayout();
            this.grbAddSubItem.ResumeLayout(false);
            this.grbAddSubItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAddTopLevelMenu;
        private System.Windows.Forms.Label lblAddSubItem;
        private System.Windows.Forms.TextBox txbAddSubItem;
        private System.Windows.Forms.TextBox txbAddTopLevelMenu;
        private System.Windows.Forms.Button btnAddTopLevelMenu;
        private System.Windows.Forms.Button btnAddSubItem;
        private System.Windows.Forms.GroupBox grbAddTopLevelMenu;
        private System.Windows.Forms.GroupBox grbAddSubItem;
    }
}

