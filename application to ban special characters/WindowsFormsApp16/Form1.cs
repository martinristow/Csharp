using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        private bool broj = true;//go postavuvame na true
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Cyan;//Postavuvanje na boja na samata forma
            label1.Text="Vnesi tekst , koj ke sodrzi samo bukvi (brojki i specijalni znaci se zabraneti) !";//labela so tekst
            label1.Font = new Font("Arial", 10);//Menuvanje na fontot i goleminata na tekstot od labelata
            label1.ForeColor = Color.Black;//bojata na tekstot od labelata
            textBox1.BackColor = Color.White;//pozadinskata boja na samiot textbox
            label2.BackColor = Color.OrangeRed;
            label2.Text = "MARTIN RISTOV - 102620";
            label2.Font = new Font("Tahoma", 14);
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//TextBox 
        {
            if (broj == true)//se proveruva dali promenlivata broj ima true vrednost , ako e vistina togas 

            {
                e.Handled = true;//ova znaci deka site broevi i del od specijalnite znaci se zabranuvaat 
            }
            if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/' || e.KeyChar == '-' || e.KeyChar == '=' || e.KeyChar == '`' || e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == ';' || e.KeyChar == ']' || e.KeyChar == '[' || e.KeyChar == ':' || e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '?' || e.KeyChar == '"' || e.KeyChar == '|' || e.KeyChar == '{' || e.KeyChar == '}' || e.KeyChar == '_' || e.KeyChar == '+' || e.KeyChar == '~')//dokolku e pretisnato nekoj od ovie znaci , toa znachi deka nema da dozvoli nivno vnesuvanje
            {
                e.Handled = true;//ova znaci deka ovie znaci shto gi navedovme vo pogorniot if ke bidat zabraneti
            }


            //********DRUG NACIN ZA ZABRANA NA SPECIJALNITE ZNACI *******

            //if (char.IsControl(e.KeyChar)==false && char.IsDigit(e.KeyChar)==false && char.IsLetter(e.KeyChar)==false && e.KeyChar != ' ')
            //{
            //    e.Handled = true;
            //}
            //else
            //{ e.Handled = false; }
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)//TextBox
        {
            broj = true;//promenlivata broj ja postavuvame na true vrednost
            if(e.KeyCode<Keys.D0||e.KeyCode>Keys.D9)//proveruvame dali e stistanato nekakvo kopce vo opseg pomegju broevite od 
                //do 9 od normalnata tastatura i dokolku e stistanoto istoto nema da bide registrirano vo textboxot
            {
                if(e.KeyCode<Keys.NumPad0||e.KeyCode>Keys.NumPad9)//proverka dali e stisnato nekakvo kopce od numerickata tastatura
                {
                    broj = false;
                }
               
            }
        }
        private void button1_Click(object sender, EventArgs e)//Kopce
        {
            int broj = textBox1.Text.Length;
            if (broj < 1)
            {
                
                MessageBox.Show("Vnesete zbor ili recenica","Prepravi",buttons:MessageBoxButtons.OK,MessageBoxIcon.Error);

               
            }
            else {
                MessageBox.Show("Dolzinata na zborot e " + textBox1.TextLength.ToString() + " i vneseniot zbor e " + textBox1.Text,"Aplikacija",buttons:MessageBoxButtons.OK);//Prikazuvanje na tekstot so ShowBox kade sto vo nego ke imame informacii za dolzinata na vneseniot zbor i koj zbor sme go vnesile
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
