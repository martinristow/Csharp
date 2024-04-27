
//MARTIN RISTOV 102620

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
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
            string[] zborovi = txtString.Text.Split(' ');//Vnesenata recenica ja razdeluvame na povekje delovi
            int brojnazborovi = zborovi.Length;//broime kolku zborovi imame 
            int posledenindexnakarakter = txtString.Text.Length - 1;//se postavuvame na posledniot index od tekstot
            char posledenkarakter = txtString.Text[posledenindexnakarakter];
            string[] obratnizborovi = new string[brojnazborovi];
            for (int i = 0; i < brojnazborovi; i++)//gi zapisuvame obrnatite zborovi vo niza
            {
                obratnizborovi[i] = zborovi[brojnazborovi - i - 1];
            }
            string obrnataRecenica = string.Join(" ", obratnizborovi) + posledenkarakter;//gi spojuvame zborovite koj sto prethodno gi obrnavme so komandata Join
            lblRezultat.Text = obrnataRecenica;//Ja pecatime obrnatata recenica vo lblRezultat
        }
    }
    }

