using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan1
{
    public partial class index : Form
    {
        private SqlCommand cmd;
        private SqlDataReader rd;

        bool sidebarexp;
        static Koneksi konn = new Koneksi();
        private SqlConnection conn = konn.getConn();
        public index()
        {
            InitializeComponent();
            button1.MouseEnter += Button_MouseEnter;
            button2.MouseEnter += Button_MouseEnter;
            button3.MouseEnter += Button_MouseEnter;
            button4.MouseEnter += Button_MouseEnter;
            button5.MouseEnter += Button_MouseEnter;
            button1.MouseLeave += button_MouseLeave;
            button2.MouseLeave += button_MouseLeave;
            button3.MouseLeave += button_MouseLeave;
            button4.MouseLeave += button_MouseLeave;
            button5.MouseLeave += button_MouseLeave;
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = SystemColors.GradientActiveCaption;
            }
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = SystemColors.Control;
            }
        }

        void time()
        {
            if (sidebarexp)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarexp = false;
                    Sidebartime.Stop();
                }
            }

            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarexp = true;
                    Sidebartime.Stop();
                }
            }
        }
     /*   void btnclik()
        {
            button1_MouseEnter = button1.BackColor = SystemColors.Control;
            button2_MouseEnter = button2.BackColor = SystemColors.Control;
        }*/
        private void index_Load(object sender, EventArgs e)
        {
            conn.Open();
            tampilbarang();
            bersihkan();
        }
        void tampilfrom1()
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
        void tampilpetugas()
        {
            Petugas petugas = new Petugas();
            this.Hide();
            petugas.ShowDialog();
        }

        void tampilbarang()
        {
            dataGridView1.Rows.Clear();
            try
            {
                cmd = new SqlCommand("select * from barang", conn);
                rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        int i = dataGridView1.Rows.Add();
                        int no = i + 1;
                        DataGridViewRow row = dataGridView1.Rows[i];
                        row.Cells[0].Value = no.ToString();
                        row.Cells[1].Value = rd["nama_barang"].ToString();
                        row.Cells[2].Value = rd["stok"].ToString();
                        row.Cells[3].Value = rd["harga_beli"].ToString();
                        row.Cells[4].Value = rd["harga_jual"].ToString();
                        row.Cells[5].Value = rd["satuan"].ToString();

                    }
                }
                rd.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        /*void caribarang()
        {
            dataGridView1.Rows.Clear();
            try
            {
                cmd = new SqlCommand("select * from barang where nama_barang like '%'= '" + textBox1.Text + "''%'");
                rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        int i = dataGridView1.Rows.Add();
                        int no = i + 1;
                        DataGridViewRow row = dataGridView1.Rows[i];
                        row.Cells[0].Value = no.ToString();
                        row.Cells[1].Value = rd["nama_barang"].ToString();
                        row.Cells[2].Value = rd["stok"].ToString();
                        row.Cells[3].Value = rd["harga_beli"].ToString();
                        row.Cells[4].Value = rd["harga_jual"].ToString();
                        row.Cells[5].Value = rd["satuan"].ToString();
                    }
                }
                rd.Close();
            }
            catch
            {

            }
        }*/
        void bersihkan()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Sidebartime.Start();
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //button1.BackColor = Color.White;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //button1.BackColor = Color.Black;
            dataGridView1.Visible = false;
          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
          
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
      
            tampilfrom1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tampilpetugas();
            dataGridView1.Visible = false;
     
        }
        void tam(object Form)
        {
            if(this.datagridviuw.Controls.Count > 0) 
                this.datagridviuw.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock =DockStyle.Fill;
            this.datagridviuw.Controls.Add(f);
            this.datagridviuw.Tag = f;
            f.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //pictureBox4.Visible = false;
            /*      dataGridView1.Visible = true;
                  label1.Visible = true;
                  textBox1.Visible = true;
                  groupBox1.Visible = true;*/
            //dataGridView1.Location = new Point(776; 225);
            tam(new Form1());
            
        }
        private void Sidebartime_Tick(object sender, EventArgs e)
        {
            time();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sidebartime.Start();
            dataGridView1.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
       
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
       
            tampilfrom1();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
          
            tampilpetugas();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* caribarang();*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
