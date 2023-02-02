using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog(); 
            dlg.Title = "Open";
            dlg.ShowDialog();

            string fName = dlg.FileName;
            StreamReader sr = new StreamReader(fName); 
            richTextBox1.Text = sr.ReadToEnd(); 
            sr.Close();


        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fName = saveFileDialog1.FileName; 
            StreamWriter sw = new StreamWriter(fName); 
            sw.Write(richTextBox1.Text);
            sw.Flush();
            sw.Close();

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog(); 
            fd.Font = richTextBox1.SelectionFont;
            fd.Color = richTextBox1.SelectionColor; 
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font; 
                richTextBox1.SelectionColor = fd.Color;
            }


        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Name : Kkrishna Saxena"+Environment.NewLine+"Email: saxena.kkrishna@gmail.com";
            string title = "About Us";
            MessageBox.Show(message, title); 
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }
    }
}
