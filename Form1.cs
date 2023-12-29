using System.Data;
using System.Data.SqlClient;

namespace Latihan1
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;


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
            SqlConnection conn = konn.getConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM barang", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "barang");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "barang";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            if(textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap, Silaka cek kembali");
            }
            else
            {
                SqlConnection conn = konn.getConn();
                try
                {
                    cmd = new SqlCommand("INSERT INTO barang VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", conn);
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
        }
    }
}
