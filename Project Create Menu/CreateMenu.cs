using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Create_Menu
{
    public partial class FormCreateMenu : Form
    {
        MenuStrip menu;

        public FormCreateMenu()
        {
            InitializeComponent();
        }

        private void FormCreateMenu_Load(object sender, EventArgs e)
        {
            menu = new MenuStrip();
        }


        private void btnAddTopLevelMenu_Click(object sender, EventArgs e)
        {
            if (txbAddTopLevelMenu.Text != null)
            {
                ToolStripMenuItem topLvlMenu = (ToolStripMenuItem)menu.Items.Add($"{txbAddTopLevelMenu.Text}");
                topLvlMenu.Name = txbAddTopLevelMenu.Text;
                this.MainMenuStrip = menu;
                this.Controls.Add(menu);
            }
        }

        private void btnAddSubItem_Click(object sender, EventArgs e)
        {
            if (txbAddSubItem.Text != null)
            {
                if (txbAddTopLevelMenu.Text != null)
                {
                    foreach (var item in menu.Items)
                    {
                        if(txbAddTopLevelMenu.Text == ((ToolStripMenuItem)item).Name)
                        {
                            ToolStripMenuItem subIt = ((ToolStripMenuItem)item);
                            subIt.DropDownItems.Add($"{txbAddSubItem.Text}");
                        }
                    }
                    
                }

            }
        }
    }
}
