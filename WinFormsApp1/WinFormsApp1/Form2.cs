using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 dc = new Form3();
            dc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-NQ0QJUP\\SQLEXPRESS;Initial Catalog=pentrupaoo;Integrated Security=True;TrustServerCertificate = true");
           
            
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text=="")
            {
                

            }
            else if (textBox2.Text==textBox3.Text)
            {
                connectionString.Open();
                SqlCommand cmd = new SqlCommand("Insert into logare values (@email,@password);", connectionString);
                cmd.Parameters.AddWithValue("@email", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                cmd.ExecuteNonQuery();
                connectionString.Close();
                Form3 dc = new Form3();
            dc.Show();

            }
        }
    }
}
