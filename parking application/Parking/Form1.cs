using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.BackColor = Color.Green;
            label4.BackColor = Color.Red;
            label4.Text = string.Empty;
            label3.Text=string.Empty;
            label1.Text = "Registracija XX-XXXX-XX";
            label2.Text = "VREME : CC:MM:SS";
            button1.Text = "VLEZ";
            button2.Text = "CENA";
            button3.Text = "IZLEZ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//VLEZ
        {
            string text;
            text = textBox1.Text;
            string[] texxt = text.Split('-');
            if ((text.Length == 10) && (text[2] == '-') && (text[7]=='-'))
            {
                if (int.TryParse(texxt[0], out int broj) && int.TryParse(texxt[1], out int broj1) && int.TryParse(texxt[2], out int broj2))
                {
                    if(!textBox3.Text.Contains(textBox1.Text))
                    {
                        textBox2.Clear();
                        string tek = (broj + "-" + broj1 + "-" + broj2).ToString();
                        //textBox3.Text.Insert(4, tek);
                        //textBox3.Text=textBox3.Text.Replace("00", tek);
                        textBox3.Text = String.Format("{0} - {1} - {2} ", broj, broj1, broj2);
                        
                    }
                    else
                    {
                        textBox2.Text = "Vekje e parkirano";
                    }
                    
                }
            } 
            else
            {
                textBox2.Text = "Nevaliden vnes";
            }

            
        }

        private void button2_Click(object sender, EventArgs e)//CENA
        {
            string cas=textBox2.Text.ToString();
            string[] podelba = cas.Split(':');
            if (cas.Length == 8 && cas[2] == ':' && cas[5]==':')
            {
                if (int.TryParse(podelba[0],out int broj1) && int.TryParse(podelba[1],out int broj2) && int.TryParse(podelba[2],out int broj3))
                {

                    if (((broj1 < 0 && broj1 > 24) || (broj2 < 0 && broj2 > 60) || (broj3 < 0 && broj3 > 60)))
                    {

                        textBox3.Text=String.Format("{0}:{1}:{2}",broj1,broj2, broj3);
                    }

                }
            }
            else
            {
                textBox1.Text = "Nevaliden vnes";
            }
        }

        private void button3_Click(object sender, EventArgs e)//IZLEZ
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) && char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar)))
            { e.Handled = true; }
        }
    }
}
