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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.getConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM pegawai WHERE username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                Form1 from = new Form1();
                from.Show();
            }
            else
            {
                MessageBox.Show("Maap nih bro, ente salah");
            }
        }
    }
}
