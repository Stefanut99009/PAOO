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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-NQ0QJUP\\SQLEXPRESS;Initial Catalog=pentrupaoo;Integrated Security=True;TrustServerCertificate = true");

            connectionString.Open();
            SqlCommand cmd = new SqlCommand("Select email,password from logare where email=@email and password=@password;", connectionString);
            cmd.Parameters.AddWithValue("@email", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            
            cmd.ExecuteNonQuery();
            connectionString.Close();
            Form1 dc = new Form1();
            dc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
