using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 2000;//interval e postaveno na 2000 i toa oznacuva deka na sekoj 2 sekundi kje se slucuva nekakvo 
            //namaluvanje ili nakacuvanje , vo nashiot slucaj kje bide so namaluvanje 
            label1.Visible = false;//ovaa labela ja postavuvame na pocetok da bide nevidliva , potocno taa kje se pojavi koga 
            //brojot vo textbox kje se namali do 0 i ke ne izvesti deka kje mozime povtorno da vneseme nekoj drug broj vo textbox
            label2.Text = "Martin Ristov - 102620";//Informacija za kreatorot :D
            label2.Font = new Font("Arial", 12, FontStyle.Bold);//postavuvanje na fontot Arial , so golema 12ka i tekstot da bide boldiran
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int broj;//deklarirame edna promenliva broj kade sto kje ni sluzi da vneseme samo broj pomegju 10 i 20 
            if (int.TryParse(textBox1.Text, out broj) && broj >= 10 && broj <= 20)// so if kje proverime na pocetok dali vnesenite
                //karakteri vo textboxot se brojki i ako se brojki potoa se proveruvaat dali vneseniot broj e pomegju 10 i 20
                //ako e ispolnet ispolnet uslovot kje vlezeme vnatre vo if delot i textbox kje go postavime da bide nedostapen
                //potocno da ne mozeme da go menuvame dodeka trae samata operacija i slicno.Svojstvoto Enabled kaj timer1 
                //mora da bide na true za istiot da bide ovozmozen i da moze da pocne da odbrojuva
            {
                textBox1.Enabled = false;//objasneto pogore
                timer1.Enabled = true;//objasneto pogore
                timer1.Start();
            }
            else//ako ne e ispolnet uslovot togas vleguvame vo delot else i karakterite sto sme gi vnele kje gi izbriseme
                //i kje dozvolime povtorno da vnesime od novo broj pomegju 10 i 20 a brisenjeto moze da go napravime vaka 
                //so textbox1.Clear i textBox1.Text=string.Empty vo ovoj slucaj jas ke ja upotrebam textBox1.Text = string.Empty, malku za promena
                
            {
                //textBox1.Clear(); objasneto pogore
                textBox1.Text = string.Empty;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)//ja selektirame timer1 i odime kaj nastani kade shto go izbirame 
            //edinstveniot nastan a toa e nastanot Tick
        {
            int brojac1 = 0;//na pocetok brojacot go inicijalizirame na vrednost 0
            string dodeli = (string)textBox1.Text;//vrednosta od textboxot ja dodeluvame na promenlivata dodeli ovde upotrebiv
            //(string)textBox1.Text a istoto mozev da go napravam i so textBox1.Text.ToString()                                       
            brojac1 = int.Parse(dodeli);//tekstot koj shto e vnesen vo stringot kje go pretvorime(konvertirame) vo brojki 
            //so pomos na funkcijata int.Parse i istiot kje go dodelima na brojac1
            brojac1--;//otkako sme ja dodelile vrednosta , sega sledno e da go namalime brojacot za 1(-1) kade sto toa ke se pravi
            //se dodeka ne stigne do vrednost nula
            textBox1.Text=brojac1.ToString();//vrednosta na brojac ja ispisuvame vo textbox1
            if(brojac1 == 0)//ako brojac1 stigne do brojot 0 togas timer1 zastanuva potocno ne prodolzuva ponatuvamu
            {
                timer1.Stop();
                label1.Visible = true;//labelata ja pravime vidliva
                label1.Text = "Sega mozete povtorno da vnesete broj pomegju 10 i 20 !";//go ispisuvame ovoj tekst so cel da go 
                //izvestime korisnikot deka kje moze povtorno da vnese drugi brojki i da ja sprovede istata akcija
                label1.Font = new Font("Tahoma", 9, FontStyle.Bold);//ime na font , golema i boldiran text.
                textBox1.Enabled=true;//textbox ja postavuvame na dostapna potocno dozvoluvame da se vnese nova vrednost vo poleto 
                
            }                                   
        }
    }
}
