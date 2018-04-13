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
        ImageList largeIcon;
        ImageList smallIcon;
        public formExplorerTreeview()
        {
            InitializeComponent();
        }

        // sozdat "myComp"
        // zagruzit "myComp"
        // zagruzit metod (diski);
        private void formExplorerTreeview_Load(object sender, EventArgs e)
        {
            largeIcon = new ImageList();
            largeIcon.ImageSize = new Size(32, 32);
            largeIcon.ColorDepth = ColorDepth.Depth32Bit;
            smallIcon = new ImageList();
            smallIcon.ImageSize = new Size(16, 16);
            smallIcon.ColorDepth = ColorDepth.Depth32Bit;

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
                    logicD.Text = item.Name.TrimEnd('\\');
                    logicD.Remove();
                    root.Nodes.Add(logicD);

                    LoadDirectory(logicD.Text + "\\", logicD, 0);
                }
            }
        }

        // Directory
        private void LoadDirectory(string path, TreeNode parent, int level)
        {
            foreach (var item in Directory.GetDirectories(path))
            {
                level++; // uvelichivaem kol-vo vlogenih elementov
                if (level > 30)
                    return;
                TreeNode subDir = new TreeNode();
                DirectoryInfo dir = new DirectoryInfo(item);
                if (dir.GetType().IsVisible)
                {
                   try
                    {
                        subDir.Text = dir.Name;
                        parent.Nodes.Add(subDir);
                        LoadDirectory(dir.FullName, subDir, level);
                    }
                    catch
                    {
                    }
                }
            }
        }


        // Vivod Puti v txbPath
        private void treeViewExpl_AfterSelect(object sender, TreeViewEventArgs e)
        {
            bool flagIfDisk = false;
            listViewExpl.Items.Clear();
            try
            {
                if (treeViewExpl.SelectedNode.FullPath == root.FullPath) // esli vibrali "My_computer"
                    IfSelectedMyComp(e, flagIfDisk);
                

                if (treeViewExpl.SelectedNode.FullPath != root.FullPath) // esli vibrali ne "My_computer"
                    IfNotSelectedMyComp(e, flagIfDisk);
            }
            catch { }
            
        }



        private bool IsDisk(TreeViewEventArgs e)
        {
            bool tempFlag = false;
            foreach (var logicDrive in Directory.GetLogicalDrives())
            {
                if (logicDrive.TrimEnd('\\') == e.Node.Text)
                    return tempFlag = true;
            }

            return tempFlag;
        }



        private void IfSelectedMyComp(TreeViewEventArgs e, bool flagIfDisk)
        {
            txbPath.Text = e.Node.FullPath.Substring(root.FullPath.Length);
            flagIfDisk = IsDisk(e);
            if (flagIfDisk == false)
            {
                foreach (var item in Directory.GetDirectories(e.Node.FullPath.Substring(root.FullPath.Length)))
                {
                    DirectoryInfo dir = new DirectoryInfo(item);
                    listViewExpl.Items.Add(dir.Name);
                }

                foreach (var item1 in Directory.GetFiles(e.Node.FullPath.Substring(root.FullPath.Length)))
                {
                    DirectoryInfo dir = new DirectoryInfo(item1);
                    listViewExpl.Items.Add(dir.Name);
                }
            }
            else if (flagIfDisk == true)
            {
                foreach (var item in Directory.GetDirectories(e.Node.FullPath.Substring(root.FullPath.Length) + "\\"))
                {
                    DirectoryInfo dir = new DirectoryInfo(item);
                    listViewExpl.Items.Add(dir.Name);
                }

                foreach (var item1 in Directory.GetFiles(e.Node.FullPath.Substring(root.FullPath.Length) + "\\"))
                {
                    DirectoryInfo dir = new DirectoryInfo(item1);
                    listViewExpl.Items.Add(dir.Name);
                }
            }
        }


        private void IfNotSelectedMyComp(TreeViewEventArgs e, bool flagIfDisk)
        {
            txbPath.Text = e.Node.FullPath.Substring(root.FullPath.Length + 1);

            flagIfDisk = IsDisk(e);

            if (flagIfDisk == false)
            {
                foreach (var item in Directory.GetDirectories(e.Node.FullPath.Substring(root.FullPath.Length + 1)))
                {
                    DirectoryInfo dir = new DirectoryInfo(item);
                    largeIcon.Images.Add(dir.Name + "Key", Icon.ExtractAssociatedIcon(dir.FullName));
                    listViewExpl.Items.Add(dir.Name);
                }

                foreach (var item1 in Directory.GetFiles(e.Node.FullPath.Substring(root.FullPath.Length + 1)))
                {
                    FileInfo file = new FileInfo(item1);
                    largeIcon.Images.Add(file.Name + "Key", Icon.ExtractAssociatedIcon(file.FullName));
                    listViewExpl.Items.Add(file.Name);
                }
            }

            else if (flagIfDisk == true)
            {
                foreach (var item in Directory.GetDirectories(e.Node.FullPath.Substring(root.FullPath.Length + 1) + "\\"))
                {
                    DirectoryInfo dir = new DirectoryInfo(item);
                    //largeIcon.Images.Add(dir.Name + "Key", Icon.ExtractAssociatedIcon(dir.FullName));
                    listViewExpl.Items.Add(dir.Name);
                }

                foreach (var item1 in Directory.GetFiles(e.Node.FullPath.Substring(root.FullPath.Length + 1) + "\\"))
                {
                    FileInfo file = new FileInfo(item1);
                    largeIcon.Images.Add(file.Name, (Icon)Icon.ExtractAssociatedIcon(file.FullName));
                    listViewExpl.Items.Add(file.Name, file.Name);
                }
            }
        }


        

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewExpl.View = View.List;
            listViewExpl.SmallImageList = smallIcon;
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewExpl.View = View.LargeIcon;
            listViewExpl.LargeImageList = largeIcon;
        }

        private void smallIconToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listViewExpl.View = View.SmallIcon;
            listViewExpl.SmallImageList = smallIcon;
        }
    }
}
