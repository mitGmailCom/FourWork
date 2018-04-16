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
        private TreeNode root;
        private List<TreeNode> listTreeNodes;
        private ImageList largeIcon;
        private ImageList smallIcon;
        private ImageList stateIcon;
        private string ImgKeyFolder = "folder";
        private bool FlagLargeImgList { get; set; } = true;
        TreeViewEventArgs tempE;
        bool flagIfDisk = false;

        public formExplorerTreeview()
        {
            InitializeComponent();
        }

        // sozdat "myComp", zagruzit "myComp", zagruzit metod (diski);
        private void formExplorerTreeview_Load(object sender, EventArgs e)
        {
            //textBox1.Text = $"Name - {temDir.Name}\nCreationTime - {temDir.CreationTime}\nLastAccessTime - {temDir.LastAccessTime}\nLastWriteTime - {temDir.LastWriteTime}\nAttributes - {temDir.Attributes}\nCountDirectories - {countDirectories}\nCountFiles - {countFiles}";
            label7.Text = "Name";
            label1.Text = "CreationTime";
            label2.Text = "LastAccessTime";
            label3.Text = "LastWriteTime";
            label4.Text = "Attributes";
            label5.Text = "CountDirectories";
            label6.Text = "CountFiles";
            this.richTxbExpl.AllowDrop = true;
            this.richTxbExpl.DragEnter += RichTxbExpl_DragEnter;
            this.richTxbExpl.DragDrop += RichTxbExpl_DragDrop;
            Bitmap bmp = new Bitmap("Generic_36503.png");
            largeIcon = new ImageList();
            largeIcon.ImageSize = new Size(24, 24);
            largeIcon.ColorDepth = ColorDepth.Depth32Bit;
            smallIcon = new ImageList();
            smallIcon.ImageSize = new Size(16, 16);
            smallIcon.ColorDepth = ColorDepth.Depth32Bit;
            stateIcon = new ImageList();
            stateIcon.ImageSize = new Size(32, 32);
            stateIcon.ColorDepth = ColorDepth.Depth32Bit;

            largeIcon.Images.Add(ImgKeyFolder, bmp);
            smallIcon.Images.Add(ImgKeyFolder, bmp);
            stateIcon.Images.Add(ImgKeyFolder, bmp);

            root = new TreeNode("My_computer");
            treeViewExpl.Nodes.Add(root);
            listTreeNodes = new List<TreeNode>();
            LoadDisk();
        }

        

        // Diski load in TreeView
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


        // Directory load in TreeView
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
            listViewExpl.Items.Clear();
            //ShowDirectoryfromTreeView(sender, e);
            try
            {
                // Vibran "My_comp"
                if (treeViewExpl.SelectedNode.FullPath == root.FullPath && treeViewExpl.SelectedNode.FullPath != null) // esli vibrali "My_computer"
                    IfSelectedMyComp(e, flagIfDisk);

                // Ne vibran "My_comp"
                if (treeViewExpl.SelectedNode.FullPath != root.FullPath && treeViewExpl.SelectedNode.FullPath != null) // esli vibrali ne "My_computer"
                    IfNotSelectedMyComp(e, flagIfDisk);
            }
            catch { }
        }


        //flag na  Proverku Vibran li Disk
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
            richTxbExpl.Text = "My Computer";
        }


        private void IfNotSelectedMyComp(TreeViewEventArgs e, bool flagIfDisk)
        {
            if (FlagLargeImgList == true)
                LargeImgList(e, flagIfDisk);

            else if (FlagLargeImgList == false)
                SmallImgList(e, flagIfDisk);
        }




        private void LargeImgList(TreeViewEventArgs e, bool flagIfDisk)
        {
            
            txbPath.Text = e.Node.FullPath.Substring(root.FullPath.Length + 1);

            flagIfDisk = IsDisk(e);



            if (listViewExpl.LargeImageList == null)
            {
                FlagLargeImgList = true;
                listViewExpl.View = View.LargeIcon;

                listViewExpl.LargeImageList = largeIcon;
                listViewExpl.EndUpdate();
            }



            if (flagIfDisk == false)
            {
                foreach (var item in Directory.GetDirectories(e.Node.FullPath.Substring(root.FullPath.Length + 1)))
                {
                    DirectoryInfo dir = new DirectoryInfo(item);
                    listViewExpl.Items.Add(dir.Name, "folder");
                }

                foreach (var item1 in Directory.GetFiles(e.Node.FullPath.Substring(root.FullPath.Length + 1)))
                {
                    FileInfo file = new FileInfo(item1);
                    largeIcon.Images.Add(file.Name + "Key", Icon.ExtractAssociatedIcon(file.FullName));
                    listViewExpl.Items.Add(file.Name, file.Name + "Key");
                }
                tempE = new TreeViewEventArgs(e.Node);
            }


            else if (flagIfDisk == true)
            {
                foreach (var item in Directory.GetDirectories(e.Node.FullPath.Substring(root.FullPath.Length + 1) + "\\"))
                {
                    DirectoryInfo dir = new DirectoryInfo(item);
                    listViewExpl.Items.Add(dir.Name, "folder");
                }

                foreach (var item1 in Directory.GetFiles(e.Node.FullPath.Substring(root.FullPath.Length + 1) + "\\"))
                {
                    FileInfo file = new FileInfo(item1);
                    largeIcon.Images.Add(file.Name + "Key", (Icon)Icon.ExtractAssociatedIcon(file.FullName));
                    listViewExpl.Items.Add(file.Name, file.Name + "Key");
                }
                tempE = new TreeViewEventArgs(e.Node);
            }
        }


        private void SmallImgList(TreeViewEventArgs e, bool flagIfDisk)
        {
            txbPath.Text = e.Node.FullPath.Substring(root.FullPath.Length + 1);

            flagIfDisk = IsDisk(e);

            if (listViewExpl.SmallImageList == null)
            {
                listViewExpl.BeginUpdate();
                FlagLargeImgList = false;
                listViewExpl.View = View.SmallIcon;

                listViewExpl.SmallImageList = smallIcon;
                listViewExpl.EndUpdate();
            }
            if (flagIfDisk == false)
            {
                foreach (var item in Directory.GetDirectories(e.Node.FullPath.Substring(root.FullPath.Length + 1)))
                {
                    DirectoryInfo dir = new DirectoryInfo(item);
                    listViewExpl.Items.Add(dir.Name, "folder");
                }

                foreach (var item1 in Directory.GetFiles(e.Node.FullPath.Substring(root.FullPath.Length + 1)))
                {
                    FileInfo file = new FileInfo(item1);
                    smallIcon.Images.Add(file.Name + "Key", Icon.ExtractAssociatedIcon(file.FullName));
                    listViewExpl.Items.Add(file.Name, file.Name + "Key");
                }
                tempE = new TreeViewEventArgs(e.Node);
            }


            else if (flagIfDisk == true)
            {
                Icon iconForFile = SystemIcons.WinLogo;

                foreach (var item in Directory.GetDirectories(e.Node.FullPath.Substring(root.FullPath.Length + 1) + "\\"))
                {
                    DirectoryInfo dir = new DirectoryInfo(item);
                    listViewExpl.Items.Add(dir.Name, "folder");
                }

                foreach (var item1 in Directory.GetFiles(e.Node.FullPath.Substring(root.FullPath.Length + 1) + "\\"))
                {
                    FileInfo file = new FileInfo(item1);
                    smallIcon.Images.Add(file.Name + "Key", (Icon)Icon.ExtractAssociatedIcon(file.FullName));
                    listViewExpl.Items.Add(file.Name, file.Name + "Key");
                }
                tempE = new TreeViewEventArgs(e.Node);
            }
        }


        private void stateImgList(TreeViewEventArgs e, bool flagIfDisk)
        {
            txbPath.Text = e.Node.FullPath.Substring(root.FullPath.Length + 1);

            flagIfDisk = IsDisk(e);

            if (listViewExpl.SmallImageList == null)
            {
                listViewExpl.BeginUpdate();
                FlagLargeImgList = true;
                listViewExpl.View = View.Tile;

                listViewExpl.SmallImageList = stateIcon;
                listViewExpl.EndUpdate();
            }
            if (flagIfDisk == false)
            {
                foreach (var item in Directory.GetDirectories(e.Node.FullPath.Substring(root.FullPath.Length + 1)))
                {
                    DirectoryInfo dir = new DirectoryInfo(item);
                    listViewExpl.Items.Add(dir.Name, "folder");
                }

                foreach (var item1 in Directory.GetFiles(e.Node.FullPath.Substring(root.FullPath.Length + 1)))
                {
                    FileInfo file = new FileInfo(item1);
                    stateIcon.Images.Add(file.Name + "Key", Icon.ExtractAssociatedIcon(file.FullName));
                    listViewExpl.Items.Add(file.Name, file.Name + "Key");
                }
                tempE = new TreeViewEventArgs(e.Node);
            }


            else if (flagIfDisk == true)
            {
                Icon iconForFile = SystemIcons.WinLogo;

                foreach (var item in Directory.GetDirectories(e.Node.FullPath.Substring(root.FullPath.Length + 1) + "\\"))
                {
                    DirectoryInfo dir = new DirectoryInfo(item);
                    listViewExpl.Items.Add(dir.Name, "folder");
                }

                foreach (var item1 in Directory.GetFiles(e.Node.FullPath.Substring(root.FullPath.Length + 1) + "\\"))
                {
                    FileInfo file = new FileInfo(item1);
                    stateIcon.Images.Add(file.Name + "Key", (Icon)Icon.ExtractAssociatedIcon(file.FullName));
                    listViewExpl.Items.Add(file.Name, file.Name + "Key");
                }
                tempE = new TreeViewEventArgs(e.Node);
            }
        }




        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewExpl.BeginUpdate();
            FlagLargeImgList = false;
            listViewExpl.View = View.List;
            listViewExpl.SmallImageList = smallIcon;
            listViewExpl.EndUpdate();
            listViewExpl.Items.Clear();
            SmallImgList(tempE, flagIfDisk);
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewExpl.Columns.Clear();
            string[] masDirectory = Directory.GetDirectories(txbPath.Text+"\\");
            List<string> masFiles = new List<string>();

            foreach (var file in Directory.GetFiles(txbPath.Text+"\\"))
                masFiles.Add(file);

            listViewExpl.View = System.Windows.Forms.View.Details;
            listViewExpl.Columns.Add("Имя");
            listViewExpl.Columns.Add("Дата изменения");
            listViewExpl.Columns.Add("Тип");
            listViewExpl.Columns.Add("Размер");

            for (int i = 0; i < listViewExpl.Columns.Count; i++)
            {
                if (i == 2)
                {
                    listViewExpl.Columns[i].Width = 48;
                    continue;
                }
                listViewExpl.Columns[i].Width = 80;
            }

            listViewExpl.BeginUpdate();
            FlagLargeImgList = false;
            listViewExpl.View = View.Details;
            listViewExpl.SmallImageList = smallIcon;

            listViewExpl.EndUpdate();
            ShowDetails(masDirectory, masFiles);
        }

        private void ShowDetails(string[] masDirectory, List<string> masFiles)
        {
            int n = 0;
            foreach (ListViewItem item in listViewExpl.Items)
            {
                if (item.Index < masDirectory.Length)
                {
                    item.SubItems.Add($"{ Directory.GetLastWriteTime(item.Text)}");
                    item.SubItems.Add("Папка");
                    item.SubItems.Add("");
                    string tt = item.Text;
                    int t = item.Index;
                }


                if (item.Index >= masDirectory.Length)
                {
                    FileInfo fInfo = new FileInfo(masFiles[n]);
                    item.SubItems.Add($"{File.GetLastWriteTime(masFiles[n])}");
                    item.SubItems.Add($"{fInfo.Extension}");
                    item.SubItems.Add($"{fInfo.Length} b");
                    n++;
                }
            }
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewExpl.BeginUpdate();
            FlagLargeImgList = true;
            listViewExpl.View = View.LargeIcon;
            listViewExpl.LargeImageList = largeIcon;
            listViewExpl.EndUpdate();
            listViewExpl.Items.Clear();
            LargeImgList(tempE, flagIfDisk);
        }

        private void smallIconToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listViewExpl.BeginUpdate();
            FlagLargeImgList = false;
            listViewExpl.View = View.SmallIcon;
            listViewExpl.SmallImageList = smallIcon;
            listViewExpl.EndUpdate();
            listViewExpl.Items.Clear();
            SmallImgList(tempE, flagIfDisk);
        }




        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewExpl.BeginUpdate();
            FlagLargeImgList = true;
            listViewExpl.View = View.Tile;
            listViewExpl.LargeImageList = stateIcon;
            listViewExpl.EndUpdate();
            listViewExpl.Items.Clear();
            stateImgList(tempE, flagIfDisk);
        }


        private void listViewExpl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int countFiles = 0;
            int countDirectories = 0;
            if (listViewExpl.SelectedItems != null)
            {
                ListView.SelectedListViewItemCollection tt = listViewExpl.SelectedItems;
                foreach (ListViewItem item in tt)
                {
                    try
                    {
                        DirectoryInfo temDir = new DirectoryInfo(txbPath.Text + "\\" + item.Text);
                        string p = txbPath.Text + "\\" + temDir.Name;
                        
                        // esli Papka
                        if (p.IndexOf('.') == -1)
                        {
                            foreach (var tSubdir in Directory.GetDirectories(txbPath.Text + "\\" + temDir.Name))
                            {
                                countDirectories++;
                            }

                            foreach (var tSubdir in Directory.GetFiles(txbPath.Text + "\\" + temDir.Name))
                            {
                                countFiles++;
                            }
                        }

                        // esli Fayli
                        if (p.IndexOf('.') != -1)
                            countFiles = 0;

                        label8.Text = temDir.Name;
                        label9.Text = temDir.CreationTime.ToString();
                        label10.Text = temDir.LastAccessTime.ToString();
                        label11.Text = temDir.LastWriteTime.ToString();
                        label12.Text = temDir.Attributes.ToString();
                        label13.Text = countDirectories.ToString();
                        label14.Text = countFiles.ToString();
                    }
                    catch { }
                }
            }
        }


        private void listViewExpl_MouseDown(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection lstViewIt = listViewExpl.SelectedItems;
            foreach (ListViewItem tempListIt in lstViewIt)
            {
                try
                {
                    string p = txbPath.Text + "\\" + tempListIt.Text;
                    // esli file
                    if (p.IndexOf('.') != -1)
                        listViewExpl.DoDragDrop(p, DragDropEffects.Move);
                }
                catch { }
            }
        }


        private void RichTxbExpl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }


        private void RichTxbExpl_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(e.Data.GetData(DataFormats.Text).ToString(), Encoding.Default))
                {
                    richTxbExpl.Text = sr.ReadToEnd();
                }
            }
            catch { }
        }
    }
}
