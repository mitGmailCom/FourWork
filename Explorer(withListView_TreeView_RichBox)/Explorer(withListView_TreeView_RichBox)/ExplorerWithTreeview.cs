using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer_withListView_TreeView_RichBox_
{
    public partial class formExplorerTreeview : Form
    {
        TreeNode root;
        List<TreeNode> listTreeNodes;
        public formExplorerTreeview()
        {
            InitializeComponent();
        }

        // sozdat "myComp"
        // zagruzit "myComp"
        // zagruzit metod (diski);
        private void formExplorerTreeview_Load(object sender, EventArgs e)
        {
            root = new TreeNode("My_computer");
            treeViewExpl.Nodes.Add(root);
            listTreeNodes = new List<TreeNode>();
            LoadDisk();
        }

        // Diski
        private void LoadDisk()
        {
            
            foreach (var item in DriveInfo.GetDrives())
            {
                TreeNode logicD = new TreeNode();
                if (item.IsReady)
                {
                    logicD.Text = item.Name;/*.TrimEnd('\\');*/
                    //logicD.Name = item.Name;
                    logicD.Remove();
                    root.Nodes.Add(logicD);
                    LoadDirectory(logicD.Text, logicD, 0);
                }
            }
        }

        // Directory
        private void LoadDirectory(string path, TreeNode parent, int level)
        {
            //level++;
            //if (level > 4)
            //    return;
            foreach (var item in Directory.GetDirectories(path))
            {
                //level++;
                //if (level > 50)
                //    return;
                TreeNode subDir = new TreeNode();
                DirectoryInfo dir = new DirectoryInfo(item);
                if (dir.GetType().IsVisible)
                {
                   try
                    {
                        subDir.Text = dir.Name;
                        parent.Nodes.Add(subDir);
                        LoadDirectory(dir.FullName, subDir, 0);
                    }
                    catch
                    {
                        
                    }
    
                }
            }
        }


    }
}
