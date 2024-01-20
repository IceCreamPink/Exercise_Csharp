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
    public partial class Petugas : Form
    {
        private SqlCommand cmd;
        private SqlDataReader rd;

        static Koneksi konn = new Koneksi();
        private SqlConnection conn = konn.getConn();
        public Petugas()
        {
            InitializeComponent();
        }

        private void Petugas_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index ind = new index();
            this.Close();
            ind.Show();
            
        }
    }
}
