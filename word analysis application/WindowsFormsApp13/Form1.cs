using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            label1.Text = "Ова е програма за анализа на текст";
            label1.Font = new Font("Arial", 14);// menuvanje na font i golemina 
            label2.Text = "Внесете текст во полето подолу";
            label2.Font = new Font("Tahoma", 9);
            label3.Text = "Фрекфенција на зборови";
            label3.Font = new Font("New Times Roman", 9);
            button1.Text = "Процесирај >>";
            textBox2.Multiline = true;// dozvoluvame da pisuvame tekst vo povekje redovi
            textBox1.Multiline = true;
            button1.Width= 100;// shirina na dugmeto
            button1.Height = 25;// visina na dugmeto
            textBox1.Height = 150;
            textBox1.Width = 200;
            textBox2.Width = 150;
            textBox2.Height= 150;
            
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string text = textBox1.Text.ToString();
            text =text.ToLower();// go pravime tekstot da bide no case sensitive
            string[] podelba = text.Split(' '); // Podelba na zborovite(podelbata se pravi koga ke naide na prazno mesto)
            Dictionary<string, int> Recnik = new Dictionary<string, int>();//kreiranje na recnik za zacuvuvanje na zborovite i nivnite vrednosti
            foreach(string zbor in podelba)
            {
                if (!string.IsNullOrEmpty(zbor))
                {
                    if (Recnik.ContainsKey(zbor))
                    {
                        Recnik[zbor]++;
                    }
                    else
                    {
                        Recnik[zbor] = 1;
                    }
                
            }
            }
            foreach (KeyValuePair<string, int> pair in Recnik)
            {
                if (pair.Value > 1)
                {
                    textBox2.AppendText(pair.Key + " - " + pair.Value.ToString() + Environment.NewLine);
                }
            }





        }
    }
}
