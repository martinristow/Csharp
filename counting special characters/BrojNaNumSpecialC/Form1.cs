using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrojNaNumSpecialC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int length = 0;
            foreach (char c in text)
            {
                if (char.IsDigit(c) || !char.IsLetter(c))
                {
                    length++;
                }
            }
            MessageBox.Show("Length of textbox1.text without alphabetic characters is " + length);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
