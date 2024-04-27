
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

namespace WindowsFormsApp26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblRezultat_Click(object sender, EventArgs e)
        {

        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPresmetaj_Click(object sender, EventArgs e)
        {
            
            string[] zborovi = txtString.Text.Split(' ');//go delime zborot na podzborovi 

            Dictionary<string, int> brojnaZborovi = new Dictionary<string, int>();//kreirame recnik

            foreach (string zbor in zborovi)//prebaruvame vo recnikot
            {
                string malibukvi = zbor.ToLower();//zborovite gi pravime da bidat so mali bukvi

                if (brojnaZborovi.ContainsKey(malibukvi))
                {
                    brojnaZborovi[malibukvi]++;//zgolemuvanje
                }
                else
                {
                    brojnaZborovi.Add(malibukvi, 1);
                }
            }

            int broj = 0;//broj go postavuvame da ima pocetna vrednost nula
            string najgolemopojavuvanjenazbor = "";//stringot da nema nikakva pocetna vrednost

            foreach (KeyValuePair<string, int> pair in brojnaZborovi)//prebaruvame
            {
                if (pair.Value > broj)//ako vrednosta e pogolema od broj togas vrednosta da se dodeli na broj i klucot da se dodeli na najgolemopojavuvanje na zborot
                {
                    broj = pair.Value;
                    najgolemopojavuvanjenazbor = pair.Key;
                }
            }

            lblRezultat.Text = najgolemopojavuvanjenazbor.ToUpper();//zborot so najgolemo pojavuvanje da se ispecati so golemi bukvi
        }
    }
}
