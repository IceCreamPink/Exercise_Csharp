using System.Data;
using System.Data.SqlClient;

namespace Latihan1
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;


        Koneksi konn = new Koneksi();

        void Bersihkan()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        void TampilBarang()
        {
            dataGridView1.Rows.Clear();
            SqlConnection conn = konn.getConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM barang", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int i = dataGridView1.Rows.Add();
                        int no = i + 1;
                        DataGridViewRow row = dataGridView1.Rows[i];
                        row.Cells[0].Value = no.ToString();
                        row.Cells[1].Value = dr["nama_barang"].ToString();
                        row.Cells[2].Value = dr["stok"].ToString();
                        row.Cells[3].Value = dr["harga_beli"].ToString();
                        row.Cells[4].Value = dr["harga_jual"].ToString();
                        row.Cells[5].Value = dr["satuan"].ToString();
                        row.Cells[8].Value = dr["id_barang"].ToString();
                    }
                }
                //ds = new DataSet();
                //da = new SqlDataAdapter(cmd);
                //da.Fill(ds, "barang");
                //dataGridView1.DataSource = ds;
                //dataGridView1.DataMember = "barang";
                //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TampilBarang();
            Bersihkan();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap, Silaka cek kembali");
            }
            else
            {
                SqlConnection conn = konn.getConn();
                if (button1.Text == "Send")
                {
                    //simpan
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO barang VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox3.Text + "')", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Isert data Berhasil");
                        TampilBarang();
                        Bersihkan();
                    }
                    catch (Exception X)
                    {
                        MessageBox.Show(X.ToString());
                    }
                }
                else
                {
                    //update
                }

            }
        }

    }
}
