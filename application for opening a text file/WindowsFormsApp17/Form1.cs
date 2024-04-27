using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.W;
            toolStripMenuItem2.ShortcutKeys=Keys.Alt | Keys.I;
            openToolStripMenuItem.ShortcutKeys=Keys.Alt | Keys.O;
            saveProjectToolStripMenuItem.ShortcutKeys= Keys.Alt | Keys.S;
            if ((textBox1.Text).Length > 0)
            {
                saveProjectToolStripMenuItem.Enabled = true;
            }
            else
            {
                saveProjectToolStripMenuItem.Enabled = false;
            }
           
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter= "Text File (*.txt)|*.txt | Site fajlovi(*.*)|*.* ";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.Title = "Zdravo";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                this.Text = openFileDialog1.FileName;
                System.IO.StreamReader test =new System.IO.StreamReader(openFileDialog1.FileName);
                textBox1.Text = test.ReadToEnd();
                test.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text).Length > 0)
            {
                saveProjectToolStripMenuItem.Enabled = true;
            }
            else
            {
                saveProjectToolStripMenuItem.Enabled = false;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
