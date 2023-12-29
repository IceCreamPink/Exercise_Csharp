namespace Latihan1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewButtonColumn();
            Column9 = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column5, Column6, Column7, Column8, Column9, Column3 });
            dataGridView1.Location = new Point(2, 253);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 162);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama barang";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Stok";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 75;
            // 
            // Column5
            // 
            Column5.HeaderText = "Harga Beli";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 75;
            // 
            // Column6
            // 
            Column6.HeaderText = "Harga Jual";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 75;
            // 
            // Column7
            // 
            Column7.HeaderText = "Satuan";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Edit";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Resizable = DataGridViewTriState.True;
            Column8.SortMode = DataGridViewColumnSortMode.Automatic;
            Column8.Text = "Edit";
            Column8.UseColumnTextForButtonValue = true;
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Hapus";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Resizable = DataGridViewTriState.True;
            Column9.SortMode = DataGridViewColumnSortMode.Automatic;
            Column9.Text = "Hapus";
            Column9.UseColumnTextForButtonValue = true;
            Column9.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 42);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 79);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 2;
            label2.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 115);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "Harga Beli";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 49);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 4;
            label4.Text = "Harga Jual";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 85);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 5;
            label5.Text = "Satuan";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(508, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(181, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(191, 115);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(196, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(508, 42);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(181, 27);
            textBox5.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(508, 164);
            button1.Name = "button1";
            button1.Size = new Size(114, 41);
            button1.TabIndex = 11;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Column3
            // 
            Column3.HeaderText = "id";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Visible = false;
            Column3.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Column8;
        private DataGridViewButtonColumn Column9;
        private DataGridViewTextBoxColumn Column3;
    }
}
