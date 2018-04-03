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

namespace DZ4
{
    public partial class TextEditor : Form
    {
        string path1 = "newTextFile";
        string path2 = ".txt";
        string fullPath = null;
        private string CopyText { get; set; } = null;
        private int N { get; set; } = 1;

        public TextEditor()
        {
            InitializeComponent();
        }
              
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorFont = new ColorDialog();
            if(colorFont.ShowDialog() == DialogResult.OK)
                txbTextEditor.ForeColor = colorFont.Color;
        }
       
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text_files(*.txt)|*.txt|All_files(*.*)|*.*";
            openFile.FilterIndex = 1;
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                if(!string.IsNullOrWhiteSpace(openFile.FileName))
                {
                    using (StreamReader reader = new StreamReader(openFile.FileName, Encoding.Default))
                    {
                        txbTextEditor.Text = reader.ReadToEnd();
                    }
                }
            }
            this.Text = openFile.FileName;
            fullPath = openFile.FileName;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path1+path2))
            {
                using (FileStream fstream = new FileStream(path1 + path2, FileMode.CreateNew, FileAccess.Write))
                N++;
                fullPath = path1 + path2;
            }
            else
            {
                Recur();
                using (FileStream fstream = new FileStream(path1 + N.ToString() + path2, FileMode.CreateNew, FileAccess.Write))
                fullPath = path1 + N.ToString() + path2;
            }
            txbTextEditor.Text = "";
        }

        private void Recur()
        {
            if (File.Exists(path1 + N.ToString() + path2))
            {
                N++;
                Recur();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (N == 0)
            {
                using (FileStream fstream = new FileStream(fullPath, FileMode.Open, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fstream, Encoding.Unicode))
                    {
                        sw.WriteLine(txbTextEditor.Text);
                    }
                }
            }
           
            else
            {
                using (FileStream fstream = new FileStream(fullPath, FileMode.Open, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fstream, Encoding.Unicode))
                    {
                        sw.WriteLine(txbTextEditor.Text);
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Текстовый файл(*.txt) | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(save.FileName))
                {
                    writer.Write(this.txbTextEditor.Text);
                    writer.Close();
                }
            }
            this.Text = save.FileName;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyText = txbTextEditor.SelectedText;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txbTextEditor.SelectedText = CopyText;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyText = txbTextEditor.SelectedText;
            txbTextEditor.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txbTextEditor.SelectAll();
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog colorBackground = new ColorDialog();
            if (colorBackground.ShowDialog() == DialogResult.OK)
                this.txbTextEditor.BackColor = colorBackground.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
                this.txbTextEditor.Font = font.Font;
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(sender, e);
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem_Click(sender, e);
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem_Click(sender, e);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancelToolStripMenuItem_Click(sender, e);
        }

        private void colorFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorToolStripMenuItem_Click(sender, e);
        }

        private void colorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            colorToolStripMenuItem1_Click(sender, e);
        }

        private void fonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontToolStripMenuItem_Click(sender, e);
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txbTextEditor.Undo();
        }

        private void copyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CopyText = txbTextEditor.SelectedText;
        }

        private void cutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CopyText = txbTextEditor.SelectedText;
            txbTextEditor.SelectedText = "";
        }

        private void pasteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            txbTextEditor.SelectedText = CopyText;
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txbTextEditor.Undo();
        }
    }
}
