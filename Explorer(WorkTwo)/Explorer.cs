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
        private bool FlagCopy { get; set; } = false;

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
                    //ListFolderView.Add(item.ToString());
                }
            }
            showItemsListBox();
            
        }

        #region ListBox-listDisk

        // вывод в листБокс
        private void showItemsListBox()
        {
            for (int i = 0; i < listbDisk.Items.Count; i++)
            {
                listbDisk.Text = listbDisk.Items[i].ToString();
                //textBox1.Text = listbDisk.Items[i].ToString();
            }
            textBox1.Text = listbDisk.SelectedItem.ToString();
        }



        // добавление в Items
        private void ShowFolder(string path, int ind)
        {
            textBox1.Text = path;
            int n = 1;
            foreach (string dirs in Directory.GetDirectories(path))
            {
                if (dirs.Contains(path))
                {
                    listbDisk.Items.Insert((ind + n), "   " + dirs);
                    //ListFolderView.Insert((ind + n), "   " + dirs);
                }
            }
        }

        #endregion


        private void ContinueClick(object sender, EventArgs e)
        {
        }
                


        private void listbDisk_Click(object sender, EventArgs e)
        {
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeI++;
        }



        #region Lisbox-listView

        // добавление файлов в Items(listbView)
        private void ShowFilesInView(string path, int ind)
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
                    myImListLarge.Images.Add(files, (Icon)Icon.ExtractAssociatedIcon(files));
                    myImListSmall.Images.Add(files, (Icon)Icon.ExtractAssociatedIcon(files));
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
                    //myImList.Images.Add(dirs, (Icon)Icon.ExtractAssociatedIcon(dirs));
                    listView1.Items.Add(dirs.Substring(path.Length), LinkToImgFolder);
                }
                if (AddDiskToListBoxView == false)
                {
                    //myImList.Images.Add(dirs, (Icon)Icon.ExtractAssociatedIcon(dirs));
                    listView1.Items.Add(dirs.Substring(path.Length + 1), LinkToImgFolder);
                }
            }
        }


        // вывод в текстБокс listbView
        private void showItemsListView()
        {
            
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
            listbDisk.Text = "";
            ShowFolder(SelectIt, selectInd);
            showItemsListBox();


            listView1.Items.Clear();
            bool flagInList = false;
            if (listbDisk.SelectedItem != null)
            {
               
                if (flagInList != true)
                {
                   
                    ShowDirectorysInView(SelectIt, selectInd);
                    ShowFilesInView(SelectIt, selectInd);
                    showItemsListView();
                    textBox1.Text = SelectIt;
                }
            }
            listbDisk.SelectedItem = textBox1.Text;
        }




        private void toolStripBtnCopy_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            if (listView1.SelectedItems.Count == 1)
            {
                PathCopyFile = textBox1.Text + listView1.SelectedItems[0].Text;
                CopyFile = listView1.SelectedItems[0].Text;

                var checkedItems = new ListViewItem[listView1.SelectedItems.Count];
                listView1.SelectedItems.CopyTo(checkedItems, 0);

                Clipboard.SetDataObject(checkedItems, false);
                FlagCopy = true;
            }
        }


        private void toolStripBtnCut_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            if (listView1.SelectedItems.Count == 1)
            {
                PathCopyFile = textBox1.Text + listView1.SelectedItems[0].Text;
                CopyFile = listView1.SelectedItems[0].Text;

                var checkedItems = new ListViewItem[listView1.SelectedItems.Count];
                listView1.SelectedItems.CopyTo(checkedItems, 0);

                Clipboard.SetDataObject(checkedItems, false);
                FlagCopy = false;
            }
        }


        private void toolStripBtnPaste_Click(object sender, EventArgs e)
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

        private void toolStripBtnCreateFolder_Click(object sender, EventArgs e)
        {
            // можно было создать новую форму и через нее получить введеное имя для папки
            string result = Microsoft.VisualBasic.Interaction.InputBox("Введите текст:");
            Directory.CreateDirectory(textBox1.Text + result);
            listView1.Items.Add(result, LinkToImgFolder);
        }



        #region HotKeys

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            listView1_KeyDown(sender, e);
            //if (e.Control && e.KeyValue == 17)
            //{
            //    flagControl = true;
            //}

            //if (flagControl == true)
            //{
            //    if (e.KeyValue == 67)
            //    {
            //        toolStripBtnCopy_Click(sender, e);
            //    }
            //    if (e.KeyValue == 90)
            //        toolStripBtnCut_Click(sender, e);
            //    if (e.KeyValue == 86)
            //        toolStripBtnPaste_Click(sender, e);
            //}
        }

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
                        toolStripBtnCopy_Click(sender, e);
                    }
                    if (e.KeyValue == 90)
                        toolStripBtnCut_Click(sender, e);
            
                }
            }
            if (listView1.SelectedItems.Count == 0)
            {
                if (e.KeyValue == 86)
                    toolStripBtnPaste_Click(sender, e);
            }
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

        #region ChangeIcon

        private void toolStripBtnLargeIc_Click(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.LargeIcon;
            listView1.Invalidate();
        }

        private void toolStripBtnSmallIc_Click(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.SmallIcon;
            listView1.Invalidate();
        }

        private void toolStripBtnList_Click(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.List;
            listView1.Invalidate();
        }

        private void toolStripBtnTable_Click(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.Details;
            listView1.Invalidate();
        }


        #endregion

        #region ChangeView

        private void toolStripBtnFont_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();

            if (font.ShowDialog() == DialogResult.OK)
                listView1.Font = font.Font;
        }

        private void toolStripBtnColorFont_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            if (color.ShowDialog() == DialogResult.OK)
                listView1.ForeColor = color.Color;
        }

        private void toolStripBtnBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog backColor = new ColorDialog();

            if (backColor.ShowDialog() == DialogResult.OK)
                listView1.BackColor = backColor.Color;
        }

        #endregion

       

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripBtnCopy_Click(sender, e);
        }
    }
}
