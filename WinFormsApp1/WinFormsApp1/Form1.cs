using Microsoft.Data.SqlClient;
using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;
using System.Threading.Tasks;
using ClosedXML.Excel;
using ExcelDataReader;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-NQ0QJUP\\SQLEXPRESS;Initial Catalog=pentrupaoo;Integrated Security=True;TrustServerCertificate = true");
            DateTime ceva = dateTimePicker1.Value;
            DateTime cevb = dateTimePicker2.Value;
            connectionString.Open();
            SqlCommand cmd = new SqlCommand("Insert into pentrupaoo values (@den_p,@val_spec,@den_s,@den_c,@cant_p,@suma_f,@data_f,@nume_a,@functie_a,@locatie_a,@data_p,@nr_ore_po,@loc_cli,@adresa_cli);", connectionString);
            cmd.Parameters.AddWithValue("@den_p", textBox1.Text);
            cmd.Parameters.AddWithValue("@val_spec", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@den_s", textBox2.Text);
            cmd.Parameters.AddWithValue("@den_c", textBox3.Text);
            cmd.Parameters.AddWithValue("@cant_p", numericUpDown2.Value);
            cmd.Parameters.AddWithValue("@suma_f", numericUpDown3.Value);
            cmd.Parameters.AddWithValue("@data_f", ceva);
            cmd.Parameters.AddWithValue("@nume_a", textBox4.Text);
            cmd.Parameters.AddWithValue("@functie_a", textBox5.Text);
            cmd.Parameters.AddWithValue("@locatie_a", textBox6.Text);
            cmd.Parameters.AddWithValue("@data_p", cevb);
            cmd.Parameters.AddWithValue("@nr_ore_po", numericUpDown4.Value);
            cmd.Parameters.AddWithValue("@loc_cli", textBox7.Text);
            cmd.Parameters.AddWithValue("@adresa_cli", textBox8.Text);
            cmd.ExecuteNonQuery();
            connectionString.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-NQ0QJUP\\SQLEXPRESS;Initial Catalog=pentrupaoo;Integrated Security=True;TrustServerCertificate = true");
            DateTime ceva = dateTimePicker1.Value;
            DateTime cevb = dateTimePicker2.Value;
            connectionString.Open();
            SqlCommand cmd = new SqlCommand("update pentrupaoo set val_spec=@val_spec,den_s=@den_s,cant_p=@cant_p,suma_f=@suma_f,data_f=@data_f,nume_a=@nume_a,functie_a=@functie_a,locatie_a=@locatie_a,data_p=@data_p,nr_ore_po=@nr_ore_po,loc_cli=@loc_cli,adresa_cli=@adresa_cli where den_p=@den_p and den_c=@den_c;", connectionString);
            cmd.Parameters.AddWithValue("@den_p", textBox1.Text);
            cmd.Parameters.AddWithValue("@val_spec", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@den_s", textBox2.Text);
            cmd.Parameters.AddWithValue("@den_c", textBox3.Text);
            cmd.Parameters.AddWithValue("@cant_p", numericUpDown2.Value);
            cmd.Parameters.AddWithValue("@suma_f", numericUpDown3.Value);
            cmd.Parameters.AddWithValue("@data_f", ceva);
            cmd.Parameters.AddWithValue("@nume_a", textBox4.Text);
            cmd.Parameters.AddWithValue("@functie_a", textBox5.Text);
            cmd.Parameters.AddWithValue("@locatie_a", textBox6.Text);
            cmd.Parameters.AddWithValue("@data_p", cevb);
            cmd.Parameters.AddWithValue("@nr_ore_po", numericUpDown4.Value);
            cmd.Parameters.AddWithValue("@loc_cli", textBox7.Text);
            cmd.Parameters.AddWithValue("@adresa_cli", textBox8.Text);
            cmd.ExecuteNonQuery();
            connectionString.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-NQ0QJUP\\SQLEXPRESS;Initial Catalog=pentrupaoo;Integrated Security=True;TrustServerCertificate = true");

            connectionString.Open();
            SqlCommand cmd = new SqlCommand("delete pentrupaoo where val_spec=@val_spec or den_s=@den_s  or suma_f=@suma_f  or nume_a=@nume_a or functie_a=@functie_a or locatie_a=@locatie_a or loc_cli=@loc_cli or adresa_cli=@adresa_cli or den_p=@den_p or den_c=@den_c;", connectionString);
            cmd.Parameters.AddWithValue("@den_p", textBox1.Text);
            cmd.Parameters.AddWithValue("@val_spec", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@den_s", textBox2.Text);
            cmd.Parameters.AddWithValue("@den_c", textBox3.Text);

            cmd.Parameters.AddWithValue("@suma_f", numericUpDown3.Value);

            cmd.Parameters.AddWithValue("@nume_a", textBox4.Text);
            cmd.Parameters.AddWithValue("@functie_a", textBox5.Text);
            cmd.Parameters.AddWithValue("@locatie_a", textBox6.Text);


            cmd.Parameters.AddWithValue("@loc_cli", textBox7.Text);
            cmd.Parameters.AddWithValue("@adresa_cli", textBox8.Text);
            cmd.ExecuteNonQuery();
            connectionString.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-NQ0QJUP\\SQLEXPRESS;Initial Catalog=pentrupaoo;Integrated Security=True;TrustServerCertificate = true");

            connectionString.Open();
            SqlCommand cmd = new SqlCommand("Select * from pentrupaoo;", connectionString);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connectionString.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-NQ0QJUP\\SQLEXPRESS;Initial Catalog=pentrupaoo;Integrated Security=True;TrustServerCertificate = true");

            connectionString.Open();
            SqlCommand cmd = new SqlCommand("Select * from pentrupaoo ORDER BY suma_f ASC;", connectionString);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connectionString.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-NQ0QJUP\\SQLEXPRESS;Initial Catalog=pentrupaoo;Integrated Security=True;TrustServerCertificate = true");

            connectionString.Open();
            SqlCommand cmd = new SqlCommand("Select * from pentrupaoo ORDER BY suma_f DESC;", connectionString);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connectionString.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-NQ0QJUP\\SQLEXPRESS;Initial Catalog=pentrupaoo;Integrated Security=True;TrustServerCertificate = true");

            connectionString.Open();
            SqlCommand cmd = new SqlCommand("Select * from pentrupaoo ORDER BY den_p ASC;", connectionString);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connectionString.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-NQ0QJUP\\SQLEXPRESS;Initial Catalog=pentrupaoo;Integrated Security=True;TrustServerCertificate = true");

            connectionString.Open();
            SqlCommand cmd = new SqlCommand("Select * from pentrupaoo ORDER BY den_p DESC;", connectionString);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connectionString.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-NQ0QJUP\\SQLEXPRESS;Initial Catalog=pentrupaoo;Integrated Security=True;TrustServerCertificate = true");

            connectionString.Open();
            SqlCommand cmd = new SqlCommand("Select * from pentrupaoo;", connectionString);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel files (*.xlsx)|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(dt, "pentrupaoo");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Succesfully exported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }








        private void button10_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel files (*.xlsx)|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string connectionString = "Data Source=DESKTOP-NQ0QJUP\\SQLEXPRESS;Initial Catalog=pentrupaoo;Integrated Security=True;TrustServerCertificate = true";

                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                        {
                            IXLWorksheet worksheet = workbook.Worksheet(1); // Assuming data is in the first worksheet

                            string query = "Insert into pentrupaoo values (@den_p,@val_spec,@den_s,@den_c,@cant_p,@suma_f,@data_f,@nume_a,@functie_a,@locatie_a,@data_p,@nr_ore_po,@loc_cli,@adresa_cli);";
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                SqlCommand cmd = new SqlCommand(query, connection);
                                // Assuming your Excel columns are named Column1, Column2, and Column3. Adjust the column names as per your actual data.
                                foreach (IXLRow row in worksheet.RowsUsed().Skip(1)) // Skip the header row
                                {
                                    DateTime ceva = row.Cell(8).Value;
                                    DateTime cevb = row.Cell(12).Value;

                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@den_p", row.Cell(2).Value.ToString());
                                    cmd.Parameters.AddWithValue("@val_spec", row.Cell(3).Value.GetNumber());
                                    cmd.Parameters.AddWithValue("@den_s", row.Cell(4).Value.ToString());
                                    cmd.Parameters.AddWithValue("@den_c", row.Cell(5).Value.ToString());
                                    cmd.Parameters.AddWithValue("@cant_p", row.Cell(6).Value.GetNumber());
                                    cmd.Parameters.AddWithValue("@suma_f", row.Cell(7).Value.GetNumber());
                                    cmd.Parameters.AddWithValue("@data_f", ceva);
                                    cmd.Parameters.AddWithValue("@nume_a", row.Cell(9).Value.ToString());
                                    cmd.Parameters.AddWithValue("@functie_a", row.Cell(10).Value.ToString());
                                    cmd.Parameters.AddWithValue("@locatie_a", row.Cell(11).Value.ToString());
                                    cmd.Parameters.AddWithValue("@data_p", cevb);
                                    cmd.Parameters.AddWithValue("@nr_ore_po", row.Cell(13).Value.GetNumber());
                                    cmd.Parameters.AddWithValue("@loc_cli", row.Cell(14).Value.ToString());
                                    cmd.Parameters.AddWithValue("@adresa_cli", row.Cell(15).Value.ToString());

                                    cmd.ExecuteNonQuery();
                                }
                                connection.Close();
                            }
                        }

                        MessageBox.Show("Data inserted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}