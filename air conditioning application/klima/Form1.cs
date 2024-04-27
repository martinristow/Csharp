using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace klima
{
    public partial class Form1 : Form
    {
        float aktuelna_temperatura = 22.0f;
        float zgolemi=0.5f;
        float namali = 0.5f;
        bool pocetna_sostojba_na_klima;
        public Form1()
        {
            InitializeComponent();
            this.Text = "KLIMA";
            pocetna_sostojba_na_klima= false;
            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "ON";
            button4.Text = "OFF";
            button1.Enabled = false;
            button2.Enabled = false;
            textBox1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (aktuelna_temperatura<33.0f)
            {
                aktuelna_temperatura += zgolemi;
                textBox1.Text = aktuelna_temperatura.ToString("0.0") +" C";
            }
            else
            {
                aktuelna_temperatura = 33.0f;
                textBox1.Text = aktuelna_temperatura + " C";
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(aktuelna_temperatura>15.0f)
            {
                aktuelna_temperatura -= namali;
                textBox1.Text = aktuelna_temperatura.ToString("0.0") + " C";
            }
            else
            {
                aktuelna_temperatura = 15.0f;
                textBox1.Text = aktuelna_temperatura + " C";
            }
           
        }

        private void button3_Click(object sender, EventArgs e)//ON
        {

            if (pocetna_sostojba_na_klima == false)
            {
                textBox1.Text = aktuelna_temperatura.ToString("0.0") + " C";
                button1.Enabled = true;
                button2.Enabled = true;
                textBox1.Visible = true;
            }  
                    
        }

        private void button4_Click(object sender, EventArgs e)//OFF
        {
            button1.Enabled = false;
            button2.Enabled = false;
            textBox1.Visible = false;
            MessageBox.Show("Klimata e izgasena");    
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar)||char.IsControl(e.KeyChar)|| char.IsSymbol(e.KeyChar)||char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
