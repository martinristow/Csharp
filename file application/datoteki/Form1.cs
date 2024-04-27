using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace datoteki
{
    public partial class Form1 : Form
    {
        List<string> lista = new List<string> { "O da da", "Partizane", " najboli si ti" };
        public Form1()
        {
            //trackBar1.TickStyle =TickStyle.TopLeft;
            //trackBar1.Minimum = 0;
            //trackBar1.Maximum = 100;
            //trackBar1.TickFrequency = 1/2;
            InitializeComponent();
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            panel1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            checkBox1.Text = "VIP1";
            checkBox2.Text = "T-MOBILE";
            button1.Text = "PRODOLZI";
            button1.Size = new System.Drawing.Size(80, 50);
            label1.Text = "IZBERETE JA FILIJALATA KADE STO STE CLEN!";
            label1.Font = new System.Drawing.Font("Arial", 8,System.Drawing.FontStyle.Bold);
            listBox1.Visible = false;
            comboBox1.Visible = false;
            label2.Visible = false;
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Otvori belo lence vrata (*.txt)|*.txt";
            openFileDialog.FilterIndex = 0;
            openFileDialog.Title = "Otvori me be";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string datotekicka=openFileDialog.FileName;
                try
                {
                    //string[] lines = File.ReadAllLines(datotekicka);
                    //comboBox1.Items.Clear();
                    //comboBox1.Items.AddRange(lines);
                    using (StreamReader sr = new StreamReader(datotekicka))
                    {
                        string[] dodeligu =File.ReadAllLines(datotekicka);
                        comboBox1.Items.AddRange(dodeligu);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Greska" + ex.Message);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Datoteka(*.txt)|*.txt";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.Title = "Martin";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string datoteka=saveFileDialog.FileName;
                try
                {
                    using(StreamWriter da=new StreamWriter(datoteka))
                    {
                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            if (listBox1.GetSelected(i) == true)
                            {
                                string selektirani = listBox1.Items[i].ToString();
                                da.Write(selektirani+"\n");
                            }
                        }
                       
                    }
                    Process.Start("notepad.exe", datoteka);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ZNACI PRVO PROVERUVAMO SO INDEX 0 I EDEN KOJ ELEMENT E IZBRANO OD LISTBOXO
            //POSLE ZNACI AKO E IZBRANO SO INDEX 0 ELEMENTITE GI POKAZUVAMO U COMBOBOX ISTO I OD INDEX1 I TAKA POSLE GI PRAVEMO 
            //DRUGITE POTREBNI OPERACII
            if (listBox1.SelectedIndex == 0)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    MessageBox.Show("Vnesete tip na pretplata");
                }
                else
                {
                    MessageBox.Show("Vnesete mala pretplata");
                }
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    List<string> list = new List<string>();
                    label2.Visible = true;
                    label2.Text = "Vnesete go imeto i prezimeto na korisnikot!";
                    string[] iminja = { "Martin Ristov", "Filip Tane", "Tane Natasha", "Natasha Ristova" };
                    list.AddRange(iminja);
                    string ime_od_korisnik=textBox1.Text;
                    string[] proveri_korisnik=ime_od_korisnik.Split(' ');

                    if ((int.TryParse(proveri_korisnik[0], out int broj)) || (int.TryParse(proveri_korisnik[1], out int broj1)))
                    {
                        MessageBox.Show("VNESOVTE I BROJKI A TREBA SAMO TEKST");
                    }
                    else
                    {
                        if(list.Contains(textBox1.Text))
                        {
                            MessageBox.Show("Korisnikot " + textBox1.Text + " e uspesno odstranet");
                           list.RemoveAt(textBox1.Text.Length);
                            foreach(string s in list)
                            {
                                MessageBox.Show("Ostanati se" + s);
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Takov korisnik ne postoi");
                        }
                        //  iminja.Contains == textBox1.Text.ToString();
                        
                       
                    }

                }
                   // MessageBox.Show("Korisnikot e uspesno izbrisan");
                }
            }
           


            //if(comboBox1.Text=="Martin")
            //{
            //    listBox1.SelectedItem=null;
            //    listBox1.SelectedIndex = 0;
            //}
            //switch(listBox1.SelectedIndex)
            //{
            //    case 0:
            //        comboBox1.SelectedIndex = 0; MessageBox.Show("Vnesete pogolema pretplata");
            //        //listBox1.SelectedItem = null; 

            //        break;
            //    case 1://listBox1.SelectedItem = null; 
            //        comboBox1.SelectedIndex = 1;MessageBox.Show("Da");
            //        break;
            //    case 2:
            //       // listBox1.SelectedItem = null;
            //        comboBox1.SelectedIndex = 2; MessageBox.Show("DA");
            //        break;
            //        default: //listBox1.SelectedItem = null;
            //                 listBox1.SelectedIndex = 3; break;
            //}
            //if (comboBox1.SelectedIndex == 0)
            //{

            //}

        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState==CheckState.Checked)
            {
                checkBox2.Checked = false;
                listBox1.Items.Clear();
            }
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                checkBox1.Checked = false;
                listBox1.Items.Clear();
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach(string elementi in lista)
            //{
            //    MessageBox.Show(elementi+"\n");
            //}
            for(int i=0;i<lista.Count;i++)
            {
                MessageBox.Show(lista[i]);
            }
            if (checkBox1.CheckState == CheckState.Checked)
            {
                panel1.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton1.Text = "Pretplata";
                radioButton2.Text = "Telefon";
                
                //  listBox1.Visible = true;
                //comboBox1.Visible = true;
                // MessageBox.Show("Cao mali " + checkBox1.Text);
            }
            else if(checkBox2.CheckState == CheckState.Checked)
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                panel1.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton3.Text = "Telefon";
                radioButton4.Text = "Pretplata";
                
                // listBox1.Visible = true;
                // comboBox1.Visible = true;
                //  MessageBox.Show("Cao mali " + checkBox2.Text);
            }
            else
            {
                MessageBox.Show("Mora da izberete nekoj od ponudenite opcii","Greska",MessageBoxButtons.OK,MessageBoxIcon.Error);
                panel1.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                listBox1.Visible = true;
                comboBox1.Visible = true;
                listBox1.BackColor = Color.IndianRed;
                string[] iminja = { "Azuriraj pretplata", "Otstrani pretplatnik" };
                listBox1.SelectionMode = SelectionMode.One;
                listBox1.Items.AddRange(iminja);
              

            }
            else
            {
                listBox1.Items.Clear();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                listBox1.Visible = true;
                comboBox1.Visible = true;
                listBox1.BackColor = Color.IndianRed;
                listBox1.Items.Clear();
                string[] iminja = { "Ipad", "Telefon" };
                listBox1.SelectionMode = SelectionMode.One;
                listBox1.Items.AddRange(iminja);
            }
            else
            {
                listBox1.Items.Clear();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                listBox1.Visible = true;
                comboBox1.Visible = true;
                listBox1.BackColor = Color.Cyan;
                
                string[] iminja = { "Promeni pretplata", "Otkazi pretplata" };
               listBox1.SelectionMode = SelectionMode.One;
                listBox1.Items.AddRange(iminja);
               
            }
            else
            {
                listBox1.Items.Clear();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                listBox1.Visible = true;
                comboBox1.Visible = true;
                listBox1.BackColor = Color.Cyan;
                string[] iminja = { "Telefon", "Ipad" };
                listBox1.SelectionMode = SelectionMode.One;
                listBox1.Items.AddRange(iminja);
                
            }
            else
            {
                listBox1.Items.Clear();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            if (listBox1.SelectedIndex == 0)
            {
                string[] raboti = { "Pogolema pretplata", "Pomala pretplata" };
                comboBox1.Items.AddRange(raboti);
            }
            else if(listBox1.SelectedIndex == 1)
            {
                string[] raboti = { "Izbrisi korisnik" };
                comboBox1.Items.AddRange(raboti);
                
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsDigit(e.KeyChar)||char.IsPunctuation(e.KeyChar))
            //{ e.Handled = true; }
        }
    }
}
