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

namespace Latihan1
{
    public partial class Login : Form
    {
        private SqlCommand cmd;
        private SqlDataReader rd;

        Koneksi konn = new Koneksi();
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }
        /*
                private void button1_Click(object sender, EventArgs e)
                {
                    SqlConnection conn = konn.getConn();
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM petugas WHERE username='" + textBox1.Text + "'and password='" + textBox2.Text + "'", conn);
                    rd = cmd.ExecuteReader();
                    rd.Read();
                    if (rd.HasRows)
                    {
                        while () }
                        this.Hide();
                        Form1 from = new Form1();
                        from.Show();
                    }
                    else
                    {
                        MessageBox.Show("Maap nih bro, ente salah");
                    }
                }*/
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.getConn();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM petugas WHERE username =@username AND password =@password", conn);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.HasRows)
                    {
                        rd.Read(); // Read the first row
                        string jabatan = rd["jabatan"].ToString(); // Assuming the column name is 'jabatan'

                        this.Hide();

                        if (jabatan.Equals("admin"))
                        {
                            // Open admin form
                            index fo = new index();
                            fo.Show();
                        }
                        else if (jabatan.Equals("kasir"))
                        {
                            Form1 form = new Form1();
                            form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Unauthorized role");
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Maap nih bro, ente salah🙏");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
