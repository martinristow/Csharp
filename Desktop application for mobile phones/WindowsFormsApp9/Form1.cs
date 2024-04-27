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

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            List<string> list1 = new List<string>();
            list1.Add("Da");
            BackColor=Color.Pink;
            label1.Text = "Vnesete Ime i Izberete edno od ponudenite opcii ";
            panel2.Visible = false;
            panel1.BackColor = Color.Green;
            radioButton1.BackColor = Color.Red;
            radioButton2.BackColor = Color.LightBlue;
            radioButton1.Text = "VIP";
            radioButton2.Text = "T-MOBILE";
            button1.BackColor = Color.Cyan;
            button1.ForeColor = Color.Black;
            button1.Text= "FINISH";
            label1.BackColor = Color.LawnGreen;
            label1.Font = new Font("Arial", 14);
            label1.ForeColor = Color.DarkRed;
            textBox1.ForeColor = Color.DarkRed;
            textBox1.BackColor = Color.LemonChiffon;
            button1.Font = new Font("Arial", 12);
            textBox1.Font = new Font("Arial",12);
            textBox1.Multiline = true;
            textBox1.Cursor = Cursors.Hand;
            textBox1.ScrollBars = ScrollBars.Horizontal;          
            listBox1.ForeColor = Color.Black;
            listBox1.BackColor = Color.LemonChiffon;
           listBox1.Visible = false;
            panel1.BorderStyle=System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.BackColor = Color.AliceBlue; panel2.ForeColor= Color.Black;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            label2.Visible = false;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true )
            {
                panel2.Show();
                panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;


            }
            else { panel2.Visible = false; }
            if (radioButton1.Checked)
            {
                radioButton3.Text = "Kupi telefon";
                radioButton4.Text = "Dopolni kredit";
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true )
            {
                panel2.Show();
                panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;


            }
            else { panel2.Visible = false; }
            if (radioButton2.Checked)
            {
                radioButton3.Text = "Telefon";
                radioButton4.Text = "Kredit";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                listBox1.Visible = true;
            }
            else { listBox1.Visible = false; }
            label2.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            label2.Text = "Izbor za plakjanje";
            checkBox1.Text = "Karticka";
            checkBox2.Text = "Kesh";
            if (checkBox1.CheckState == CheckState.Checked)
            {
                if (checkBox2.CheckState == CheckState.Checked) { }
            }
            else if (checkBox2.CheckState==CheckState.Unchecked) { }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true && radioButton3.Checked==true)
                
            {
                DialogResult result = MessageBox.Show("Korisnikot " + textBox1.Text + " izbra  " + radioButton1.Text + " kade shto " + radioButton3.Text, "Proverka", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }
            else if(radioButton1.Checked == true && radioButton4.Checked == true) 
            {
                
                DialogResult result = MessageBox.Show("Korisnikot " + textBox1.Text + " izbra  " + radioButton1.Text + " kade shto " + radioButton4.Text + " vo vrednost od " + listBox1.Text + " denari.", "Proverka", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question); }
            
           else if(radioButton2.Checked==true && radioButton3.Checked==true) 
            {
                DialogResult result = MessageBox.Show("Korisnikot "+textBox1.Text + " izbra  " + radioButton2.Text + " kade shto " + radioButton3.Text, "Proverka", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }
            else { DialogResult result = MessageBox.Show("Korisnikot " + textBox1.Text + " izbra  " + radioButton2.Text + " kade shto  " + radioButton4.Text+" vo vrednost od "+listBox1.Text+" denari.", "Proverka", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question); }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
