using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login_Bazi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ime, password;
            ime = textBox1.Text;
            password = textBox2.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SCTCCJQ\SQLEXPRESS;Initial Catalog=MartinRistov;Integrated Security=True");


            string query = "SELECT * FROM Login_new WHERE UserName = @UserName AND PassWord = @Password";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.Parameters.AddWithValue("@UserName", ime);
            sda.SelectCommand.Parameters.AddWithValue("@Password", password);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            if (textBox1.Text == string.Empty&& textBox2.Text == string.Empty)
            {
                MessageBox.Show("Fale vi ime ime i prezime");
            }
            else
                if (textBox1.Text==string.Empty)
            {
                MessageBox.Show("Fale vi ime");
            }
            else if(textBox2.Text==string.Empty)
            {
                MessageBox.Show("Fale vi password");
            }
          else
                if(dataTable.Rows.Count > 0 )
                {
                 
                    MenuForma forma2= new MenuForma();
                    forma2.Show();
                    this.Hide();
                }
                else
                {
                MessageBox.Show("Takov korisnik ne e pronajden");
                }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
