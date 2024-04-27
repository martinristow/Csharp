using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRezultat_Click(object sender, EventArgs e)
        {

        }

        private void btnPresmetaj_Click(object sender, EventArgs e)
        {
            string parenindex="";

            for (int i = 0; i < txtString.Text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    parenindex += Char.ToUpper(txtString.Text[i]);
                }
                else
                {
                    parenindex += txtString.Text[i];
                }
            }

            lblRezultat.Text = parenindex;
        }

        private void txtString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
