using System.Data;
using System.Data.SqlClient;

namespace Latihan1
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private SqlDataReader dr;


        static Koneksi konn = new Koneksi();

        private SqlConnection conn = konn.getConn();

        void combobox()
        {
            comboBox1.Items.Add("pcs");
            comboBox1.Items.Add("unit");
            comboBox1.Items.Add("box");
            comboBox1.Items.Add("lembar");
            comboBox1.Items.Add("buah");
        }
        void Bersihkan()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            button1.Text = "Send";
            button2.Visible = false;
            label6.Text = "Insert Kolom";
        }

        public Form1()
        {
            InitializeComponent();
        }

       public void TampilBarang()
        {
            dataGridView1.Rows.Clear();
            try
            {
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
                dr.Close();
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
            }
        }
        public void CariBarang()
        {
            dataGridView1.Rows.Clear();
            try
            {
                cmd = new SqlCommand("SELECT * FROM barang WHERE nama_barang LIKE '%' + @namaBarang + '%'", conn);
                cmd.Parameters.AddWithValue("@namaBarang", textBox7.Text);
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
                dr.Close();
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            TampilBarang();
            Bersihkan();
            combobox();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == ""  || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap, Silaka cek kembali");
            }
            else
            {
                if (button1.Text == "Send")
                {
                    label6.Text = "Tambah Data";
                    //simpan
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO barang VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "')", conn);
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
                else if (button1.Text == "Update")
                //update
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE barang SET nama_barang ='" + textBox1.Text + "',stok ='" + textBox2.Text + "',harga_beli ='" + textBox4.Text + "',harga_jual ='" + textBox5.Text + "',satuan ='" + comboBox1.Text + "' where id_barang = '" + textBox6.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Update data Berhasil");
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
                    //Hapuss

                }


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                //Show Edit
                {

                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    textBox1.Text = row.Cells[1].Value.ToString();
                    textBox2.Text = row.Cells[2].Value.ToString();
                    textBox4.Text = row.Cells[3].Value.ToString();
                    textBox5.Text = row.Cells[4].Value.ToString();
                    comboBox1.Text = row.Cells[5].Value.ToString();
                    textBox6.Text = row.Cells[8].Value.ToString();
                    button1.Text = "Update";
                    label6.Text = "Update Kolom";
                    button2.Visible = true;
                }
                else if (e.ColumnIndex == 7)
                {
                    //Show Hapuss
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    {
                        DialogResult dialogResult = MessageBox.Show("Yakin ape buang kah? " + row.Cells[1].Value.ToString() + "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                cmd = new SqlCommand("DELETE FROM barang where id_barang = '" + row.Cells[8].Value.ToString() + "'", conn);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Delete data Berhasil");
                                TampilBarang();
                                Bersihkan();
                            }
                            catch (Exception X)
                            {
                                MessageBox.Show(X.ToString());
                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                        }
                    }

                    /*    textBox1.Text = row.Cells[1].Value.ToString();
                        textBox2.Text = row.Cells[2].Value.ToString();
                        textBox4.Text = row.Cells[3].Value.ToString();
                        textBox5.Text = row.Cells[4].Value.ToString();
                        textBox3.Text = row.Cells[5].Value.ToString();
                        textBox6.Text = row.Cells[8].Value.ToString();
                        button1.Text = "Delete";
                        label6.Text = "Hapus Kolom";
                        button2.Visible = true;*/
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            CariBarang();

        } 

        //diisi angka 
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
