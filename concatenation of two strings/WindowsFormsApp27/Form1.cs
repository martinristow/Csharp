
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

namespace WindowsFormsApp27
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

        private void txtString1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtString2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPresmetaj_Click(object sender, EventArgs e)
        {
            string str1 = txtString1.Text;//vnesenata vrednost od textbox ja dodeluvame na str1
            string str2 = txtString2.Text;//vnesenata vrednost od textbox ja dodeluvame na str2
            string rezultat = "";//Na pocetok rezultatot go postavuvame da nema nisto

            for (int i = 0; i < str1.Length; i++)//so for ciklus gi proveruvame site stringovi
            {
                rezultat += str1[i];//vrednosta soberija i dodeli ja na rezultatot
                if (i < str2.Length)//ako i e pomalo od dolzinata na stringot od textbox 2 togas soberi ja i dodeli ja na rezultat
                {
                    rezultat += str2[i];
                }
            }

            if (str2.Length > str1.Length)//ako string2 e pogolem od string1 togas soberi i dodeli go stringot2 taka shto toj ke se postavi na stringot kolku sto e dolg stringot 1 
            {
                rezultat += str2.Substring(str1.Length);
            }

            lblRezultat.Text = rezultat;//dobieniot zbor go ispisuvame vo labelata
        }
    }
    }
