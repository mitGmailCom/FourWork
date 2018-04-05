using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer_WorkTwo_
{
    public partial class Explorer : Form
    {
        ToolStrip OpenDrive = new ToolStrip();
        private string NumberDrive { get; set; } = "drive"; //
        private int Ndrive { get; set; } = 1; // 
        List<DriveInfo> driveInfo = new List<DriveInfo>(); // список дисков
        List<string> ListFolderView = new List<string>(); // список для отображения в листбокс View
        private int TimeI { get; set; } = 0;//
        private bool Flagtimer { get; set; } = false; // флаг запущен таймер
        private string SelectIt { get; set; } = null; // выделеная строка
        private bool AddDiskToListBoxView { get; set; } = false; // 

        public Explorer()
        {
            InitializeComponent();
        }

        private void Explorer_Load(object sender, EventArgs e)
        {
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

        #region ListBox-listDisk

        // вывод в листБокс
        private void showItemsListBox()
        {
            for (int i = 0; i < listbDisk.Items.Count; i++)
            {
                listbDisk.Text = listbDisk.Items[i].ToString();
                textBox1.Text = listbDisk.Items[i].ToString();
            }
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
                    ListFolderView.Insert((ind + n), "   " + dirs);
                }
            }
        }

        #endregion


        private void ContinueClick(object sender, EventArgs e)
        {
            if (Flagtimer == true & TimeI <= 10)
            {
                listbDisk_DoubleClick(sender, e);
            }

            listbDisk.Text = "";
            ShowFolder(listbDisk.SelectedItem.ToString(), listbDisk.SelectedIndex);
            showItemsListBox();

            if(SelectIt == listbDisk.SelectedItem.ToString())
                Flagtimer = true;

            SelectIt = listbDisk.SelectedItem.ToString();
        }

                


        private void listbDisk_Click(object sender, EventArgs e)
        {
            if (listbDisk.SelectedItem != null & listbDisk.SelectedItem.ToString() != SelectIt)
            {
                if (Flagtimer == false)
                {
                    this.timer1.Enabled = true;
                    this.timer1.Interval = 50;
                    TimeI++;
                    this.timer1.Start();
                }
            }

            if (SelectIt == listbDisk.SelectedItem.ToString())
            {
                Flagtimer = true;
                ContinueClick(sender, e);
            }

                SelectIt = listbDisk.SelectedItem.ToString();
        }



        #region Lisbox-listView

        // добавление файлов в Items(listbView)
        private void ShowFilesInView(string path, int ind)
        {
            int n = 1;
            for (int j = 0; j < listbView.Items.Count; j++)
            {
                if (listbView.Items[j].ToString() == path)
                {
                    foreach (string dirs in Directory.GetFiles(path))
                    {
                        listbView.Items.Insert(j + n, "   " + dirs);
                    }
                }
            }
        }

        // добавление папок в Items(listbView)
        private void ShowDirectorysInView(string path, int ind)
        {
            int n = 1;
            for (int j = 0; j < listbView.Items.Count; j++)
            {
                if (listbView.Items[j].ToString() == path)
                {
                    foreach (string dirs in Directory.GetDirectories(path))
                    {
                       listbView.Items.Insert(j + n, "   " + dirs);
                    }
                }
            }
            //foreach (string dirs in Directory.GetDirectories(path))
            //{
            //    if(listbView.Items.ToString() == path)
            //    {
            //        listbView.Items.Insert(listbView.Items. n, "  " + dirs);
            //    }
        }



        // вывод в текстБокс listbView
        private void showItemsListBoxView()
        {
            for (int i = 0; i < listbView.Items.Count; i++)
            {
                listbView.Text = listbView.Items[i].ToString();
            }
        }

        #endregion


        private void listbDisk_DoubleClick(object sender, EventArgs e)
        {
            bool flagInList = false;
            if(listbDisk.SelectedItem != null)
            {
                for (int i = 0; i < driveInfo.Count; i++)
                {
                    if (listbDisk.SelectedItem == driveInfo[i])
                        flagInList = true;
                }
                if(flagInList != true)
                {
                    if (AddDiskToListBoxView == false)
                    {
                        foreach (string item in ListFolderView)
                        {
                            listbView.Items.Add(item);
                        }
                        AddDiskToListBoxView = true;
                    }
                    ShowDirectorysInView(listbDisk.SelectedItem.ToString(), listbDisk.SelectedIndex);
                    ShowFilesInView(listbDisk.SelectedItem.ToString(), listbDisk.SelectedIndex);
                    showItemsListBoxView();
                }
            }
        }
    }
}
