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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                        textBox1.Text = reader.ReadToEnd();
                    }
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
