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

namespace Notepad
{
    public partial class Form1 : Form
    {
        string temp;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Font = new Font("Lucida Console", 12f);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            
            if (pd.ShowDialog() == DialogResult.OK)   
            {

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = new StreamReader(ofd.FileName).ReadToEnd();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "C:/DESKTOP";
            sfd.FileName = "*.txt";
            sfd.Filter = "Text Documents (.txt) | All Files(*.*) | *.*";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                new StreamWriter(sfd.FileName).Write(richTextBox1.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fd.Font;
            }
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(null);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.5.9\nALL RIGHT RESERVED.");
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text != null)
            {
                temp = richTextBox1.Text;
                richTextBox1.Text = null;
            }
            else
            {
                MessageBox.Show("Nothing to cut.");
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null)
            {
                temp = richTextBox1.Text;
            }
            else
            {
                MessageBox.Show("Nothing to copy.");
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(temp != null)
            {
                richTextBox1.Text = temp;
            }
            else
            {
                MessageBox.Show("Nothing to paste.");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length == 0)
            {
                richTextBox1.SelectedText = null;
            }
        }
    }
}
