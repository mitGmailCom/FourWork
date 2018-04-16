using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace Explorer_WorkTwo_
{
    public partial class Explorer : Form
    {
        ToolStrip OpenDrive = new ToolStrip();
        List<DriveInfo> driveInfo = new List<DriveInfo>(); // список дисков
        List<string> ListFolderView = new List<string>(); // список для отображения в листбокс View
        private int TimeI { get; set; } = 0;//
        private bool Flagtimer { get; set; } = false; // флаг запущен таймер
        private string SelectIt { get; set; } = null; // выделеная строка
        private int selectInd { get; set; } = 0;
        private bool AddDiskToListBoxView { get; set; } = false; // флаг для первой загрузки дисков в листбокс View
        bool flagControl = false;
        string CopyFile { get; set; } = null; // имя скопированого файла
        string PathCopyFile { get; set; } = null; // путь скопированого файла
        ImageList myImListLarge;
        ImageList myImListSmall;
        ImageList myImListVerySmall;
        string LinkToImgFolder { get; set; } = null; // ключ к изображению папки
        private bool FlagCopy { get; set; } = false; //
        bool flagInMasDisk = false; // флаг для формирования пути к объекту(если не диск, то добавляется '\' между диском и остальным адресом)
        enum checkImageList { large, small, verySmall};
        string FlagImgList { get; set; } = null; // flag dlya ImgList

        public Explorer()
        {
            InitializeComponent();
        }

        private void Explorer_Load(object sender, EventArgs e)
        {
            LinkToImgFolder = "folder";
            myImListLarge = new ImageList();
            myImListSmall = new ImageList();
            myImListVerySmall = new ImageList();

            listView1.LargeImageList = myImListLarge;
            listView1.SmallImageList = myImListSmall;
            listView1.StateImageList = myImListVerySmall;

            myImListLarge.ImageSize = new Size(32, 32);
            myImListSmall.ImageSize = new Size(16, 16);
            myImListVerySmall.ImageSize = new Size(12, 12);
            
            myImListLarge.ColorDepth = ColorDepth.Depth32Bit;
            myImListSmall.ColorDepth = ColorDepth.Depth32Bit;
            myImListVerySmall.ColorDepth = ColorDepth.Depth32Bit;

            Bitmap bmp = new Bitmap("Generic_36503.png");

            myImListLarge.Images.Add(LinkToImgFolder, bmp);
            myImListSmall.Images.Add(LinkToImgFolder, bmp);
            myImListVerySmall.Images.Add(LinkToImgFolder, bmp);

            foreach (DriveInfo item in DriveInfo.GetDrives())
            {
                if (item.IsReady == true)
                {
                    listbDisk.Items.Add(item);
                    driveInfo.Add(item);
                    ListFolderView.Add(item.ToString());
                }
            }
            showItemsListBox();
        }




        private void InvalidateImgList(object sender, EventArgs e)
        {
            if (FlagImgList == checkImageList.large.ToString())
                крупныеЗначкиToolStripMenuItem_Click(sender, e);
            if (FlagImgList == checkImageList.small.ToString())
                мелкиеЗначкиToolStripMenuItem_Click(sender, e);
            if (FlagImgList == checkImageList.verySmall.ToString())
                списокToolStripMenuItem_Click(sender, e);
        }




        #region ListBox-listDisk

        // вывод в листБокс
        private void showItemsListBox()
        {
            for (int i = 0; i < listbDisk.Items.Count; i++)
            {
                listbDisk.Text = listbDisk.Items[i].ToString();
            }
        }



        // добавление в Items
        private void ShowFolder(string path, int ind, object sender, EventArgs e)
        {
            textBox1.Text = path;
            int n = 1;
            int inMass = 0;
          

            foreach (string dirs in Directory.GetDirectories(path))
            {
                foreach (var item in ListFolderView)
                {
                    string temp2 = dirs.Trim();
                    string temp = item.Trim();
                    if (temp == temp2)
                    {
                        inMass = 1;
                        break;
                    }
                }
            }
            if (inMass == 0)
            {
                foreach (string dirs in Directory.GetDirectories(path))
                {
                    listbDisk.Items.Insert((ind + n), "   " + dirs);
                    ListFolderView.Insert((ind + n), "   " + dirs);
                }
            }
        }

        #endregion


        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeI++;
        }



        #region listView

        // добавление файлов в Items(listbView)
        private void ShowFilesInView(string path, int ind, object sender, EventArgs e)
        {

            AddDiskToListBoxView = false;
            foreach (string files in Directory.GetFiles(path))
            {
                if (AddDiskToListBoxView == false)
                {
                    for (int i = 0; i < driveInfo.Count; i++)
                    {
                        if (path == driveInfo[i].ToString())
                            AddDiskToListBoxView = true;
                    }
                }
                if (AddDiskToListBoxView == true)
                {
                    Icon LargeIcon = SystemIcons.WinLogo;
                    LargeIcon = Icon.ExtractAssociatedIcon(files);
                    myImListLarge.Images.Add(files, LargeIcon);
                    myImListSmall.Images.Add(files, Icon.ExtractAssociatedIcon(files));
                    myImListVerySmall.Images.Add(files, (Icon)Icon.ExtractAssociatedIcon(files));
                    listView1.Items.Add(files.Substring(path.Length), files);
                }
                if (AddDiskToListBoxView == false)
                {
                    myImListLarge.Images.Add(files, (Icon)Icon.ExtractAssociatedIcon(files));
                    myImListSmall.Images.Add(files, (Icon)Icon.ExtractAssociatedIcon(files));
                    myImListVerySmall.Images.Add(files, (Icon)Icon.ExtractAssociatedIcon(files));
                    listView1.Items.Add(files.Substring(path.Length + 1), files);
                }
            }
        }

        // добавление папок в Items(listbView)
        private void ShowDirectorysInView(string path, int ind)
        {
            AddDiskToListBoxView = false;
            foreach (string dirs in Directory.GetDirectories(path))
            {
                if (AddDiskToListBoxView == false)
                {
                    for (int i = 0; i < driveInfo.Count; i++)
                    {
                        if (path == driveInfo[i].ToString())
                            AddDiskToListBoxView = true;
                    }
                }
                if (AddDiskToListBoxView == true)
                {
                    listView1.Items.Add(dirs.Substring(path.Length), LinkToImgFolder);
                }
                if (AddDiskToListBoxView == false)
                {
                    listView1.Items.Add(dirs.Substring(path.Length + 1), LinkToImgFolder);
                }
            }
        }


        // вывод в текстБокс listbView
        private void showItemsListView(object sender, EventArgs e)
        {
            InvalidateImgList(sender, e);
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Text = listView1.Items[i].ToString();
            }
        }

        #endregion


        private void listbDisk_DoubleClick(object sender, EventArgs e)
        {
            SelectIt = listbDisk.SelectedItem.ToString();
            selectInd = listbDisk.SelectedIndex;
            listbDisk.Text = null;
            ShowFolder(SelectIt, selectInd, sender, e); // добавление в колекцию для дерева дисков
            showItemsListBox(); // вывод в дереве дисков


            listView1.Items.Clear();
            bool flagInList = false;
            if (listbDisk.SelectedItem != null)
            {

             Debug.Assert(flagInList != true);
             if (flagInList != true)
                {
                    ShowDirectorysInView(SelectIt, selectInd);
                    ShowFilesInView(SelectIt, selectInd, sender, e);
                    showItemsListView(sender, e);
                    textBox1.Text = SelectIt;
                }
            }
            listbDisk.SelectedItem = textBox1.Text;
        }



        #region HotKeys

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                if (e.Control && e.KeyValue == 17)
                {
                    flagControl = true;
                }

                if (flagControl == true)
                {
                    if (e.KeyValue == 67)
                    {
                        CtrlcToolStripMenuItemCopy_Click(sender, e);
                    }
                    if (e.KeyValue == 88)
                        CtrlzToolStripMenuItemCut_Click(sender, e);
                    if (e.KeyValue == 46)
                        удалитьDelToolStripMenuItem_Click(sender, e);
                }
            }

            if (listView1.SelectedItems.Count == 0)
            {
                if (e.KeyValue == 86)
                    CtrlvToolStripMenuItemPaste_Click(sender, e);
                
            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            listView1_KeyDown(sender, e);
        }

        private void Explorer_KeyDown(object sender, KeyEventArgs e)
        {
            listView1_KeyDown(sender, e);
        }

        private void listbDisk_KeyDown(object sender, KeyEventArgs e)
        {
            listView1_KeyDown(sender, e);
        }


        #endregion

        #region Edit

        private void CheckFlagInMasDisk(string fP)
        {
            foreach (var item in driveInfo)
            {
                if (item.ToString() == fP + "\\")
                {
                    flagInMasDisk = true;
                    break;
                }
            }
        }

        private void CtrlcToolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            if (listView1.SelectedItems.Count == 1)
            {
                if (flagInMasDisk == false)
                    PathCopyFile = textBox1.Text + "\\" + listView1.SelectedItems[0].Text;
                if (flagInMasDisk == true)
                    PathCopyFile = textBox1.Text + listView1.SelectedItems[0].Text;
                CopyFile = listView1.SelectedItems[0].Text;

                var checkedItems = new ListViewItem[listView1.SelectedItems.Count];
                listView1.SelectedItems.CopyTo(checkedItems, 0);

                Clipboard.SetDataObject(checkedItems, false);
                FlagCopy = true;
            }
        }

        private void CtrlzToolStripMenuItemCut_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            if (listView1.SelectedItems.Count == 1)
            {
                CheckFlagInMasDisk(textBox1.Text);
                if (flagInMasDisk == false)
                    PathCopyFile = textBox1.Text + "\\" + listView1.SelectedItems[0].Text;
                if (flagInMasDisk == true)
                    PathCopyFile = textBox1.Text + listView1.SelectedItems[0].Text;
                CopyFile = listView1.SelectedItems[0].Text;

                var checkedItems = new ListViewItem[listView1.SelectedItems.Count];
                listView1.SelectedItems.CopyTo(checkedItems, 0);

                Clipboard.SetDataObject(checkedItems, false);
                FlagCopy = false;
            }
        }
       

        private void CtrlvToolStripMenuItemPaste_Click(object sender, EventArgs e)
        {
            
            var checkedItems = Clipboard.GetDataObject().GetData(typeof(ListViewItem[])) as ListViewItem[];

            if (checkedItems == null)
                return;

            listView1.Items.AddRange(checkedItems);

            if (FlagCopy == true)
                File.Copy(PathCopyFile, textBox1.Text + "\\" + CopyFile);
            if (FlagCopy == false)
                File.Move(PathCopyFile, textBox1.Text + "\\" + CopyFile);
                
            FlagCopy = false;
        }

        private void удалитьDelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                string tempIt = listView1.SelectedItems[0].Text.ToString();
                listView1.Items.Remove(listView1.SelectedItems[0]);
                tempIt = textBox1.Text + "\\" + tempIt;
                File.Delete(tempIt);
            }
        }


        private void toolStripBtnCreateFolder_Click(object sender, EventArgs e)
        {
            // можно было создать новую форму и через нее получить введеное имя для папки
            string result = Microsoft.VisualBasic.Interaction.InputBox("Введите текст:");
            Directory.CreateDirectory(textBox1.Text + result);
            listView1.Items.Add(result, LinkToImgFolder);
        }
        #endregion

        #region Font

        private void ToolStripMenuItemFont_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();

            if (font.ShowDialog() == DialogResult.OK)
                listView1.Font = font.Font;
        }

        private void ToolStripMenuItemColorFont_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            if (color.ShowDialog() == DialogResult.OK)
                listView1.ForeColor = color.Color;
        }

        private void ToolStripMenuItemBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog backColor = new ColorDialog();

            if (backColor.ShowDialog() == DialogResult.OK)
                listView1.BackColor = backColor.Color;
        }
        #endregion

        #region ChangeIcon

        private void крупныеЗначкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.LargeIcon;
            FlagImgList = Enum.GetName(typeof(checkImageList),checkImageList.large);
            listView1.Invalidate();
        }

        private void мелкиеЗначкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.SmallIcon;
            FlagImgList = Enum.GetName(typeof(checkImageList), checkImageList.small);
            listView1.Invalidate();
        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.List;
            FlagImgList = Enum.GetName(typeof(checkImageList), checkImageList.verySmall);
            listView1.Invalidate();
        }

        private void таблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = 0;
            string[] masDirectory = Directory.GetDirectories(textBox1.Text);
            List<string> masFiles = new List<string>();

            foreach (var file in Directory.GetFiles(textBox1.Text))
                masFiles.Add(file);

            listView1.View = System.Windows.Forms.View.Details;
            listView1.Columns.Add("Имя");
            listView1.Columns.Add("Дата изменения");
            listView1.Columns.Add("Тип");
            listView1.Columns.Add("Размер");

            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                listView1.Columns[i].Width = 150;
            }

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Index < masDirectory.Length)
                {
                    item.SubItems.Add($"{ Directory.GetLastWriteTime(textBox1.Text)}");
                    item.SubItems.Add("Папка с файлами");
                    item.SubItems.Add("");
                    string tt = item.Text;
                    int t = item.Index;
                }


                if (item.Index >= masDirectory.Length)
                {
                        FileInfo fInfo = new FileInfo(masFiles[n]);
                        item.SubItems.Add($"{File.GetLastWriteTime(masFiles[n])}");
                        item.SubItems.Add($"{fInfo.Extension}");
                        item.SubItems.Add($"{fInfo.Length} байт");
                        n++;
                }
            }
            listView1.Invalidate();
        }
        #endregion
       
    }
}
