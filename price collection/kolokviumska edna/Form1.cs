using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolokviumska_edna
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            label1.Text = "Rezultat !";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        public void presmetajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int cena;
            //int brojac = 0;
            //int vkupna_cena = 0;
            //for(int i = 0;i<listBox1.Items.Count;i++)
            //{
            //    if (listBox1.GetSelected(i))
            //    {
            //        brojac++;
            //        string proizvod = listBox1.Items[i].ToString();
            //        string[] podeli = proizvod.Split('$');
            //        if (int.TryParse(podeli[1], out cena) )
            //        {
            //            vkupna_cena += cena;
            //            if(brojac==1)
            //            {
            //                label1.Text = "Selektiravte " + brojac + " proizvod i toj cini " + vkupna_cena;
            //            }
            //            else
            //            {
            //                label1.Text = "Selektiravte " + brojac + " proizvodi i tie cinat " + vkupna_cena;
            //            }

            //        }


            //    }
            //}
            int cena;
            int brojac=0;
            int vkupna_cena=0;
            for(int i=0;i<listBox1.Items.Count;i++)
            {
                if(listBox1.GetSelected(i))
                {
                    brojac++;
                    string zemi = listBox1.Items[i].ToString();
                    string[] podeli=zemi.Split('$');
                    if (int.TryParse(podeli[1],out cena))
                    {
                        vkupna_cena += cena;
                        label1.Text = "Selek " + brojac + " cena : " + vkupna_cena;
                    }
                    else
                    {
                        MessageBox.Show("Greska Vnes!");
                    }
                    
                }
            }
           
        }
    }
}

