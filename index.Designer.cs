namespace Latihan1
{
    partial class index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            sidebar = new Panel();
            panel6 = new Panel();
            button5 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            Sidebartime = new System.Windows.Forms.Timer(components);
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            datagridviuw = new Panel();
            sidebar.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.GradientActiveCaption;
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel2);
            sidebar.ForeColor = SystemColors.ActiveCaptionText;
            sidebar.Location = new Point(-5, -18);
            sidebar.MaximumSize = new Size(142, 472);
            sidebar.MinimumSize = new Size(55, 472);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(55, 472);
            sidebar.TabIndex = 0;
            sidebar.Paint += sidebar_Paint;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Location = new Point(-37, 235);
            panel6.Name = "panel6";
            panel6.Size = new Size(238, 61);
            panel6.TabIndex = 4;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GradientActiveCaption;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI Variable Small", 10.2F);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(-31, -19);
            button5.Name = "button5";
            button5.Size = new Size(266, 99);
            button5.TabIndex = 2;
            button5.Text = "     Show";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            button5.MouseEnter += button1_MouseEnter;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(-13, 297);
            panel5.Name = "panel5";
            panel5.Size = new Size(238, 61);
            panel5.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientActiveCaption;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI Variable Small", 10.2F);
            button4.Image = Properties.Resources.user__2_;
            button4.Location = new Point(-5, -20);
            button4.Name = "button4";
            button4.Size = new Size(211, 99);
            button4.TabIndex = 2;
            button4.Text = "     User";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            button4.MouseEnter += button1_MouseEnter;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(-8, 175);
            panel4.Name = "panel4";
            panel4.Size = new Size(238, 61);
            panel4.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Variable Small", 10.2F);
            button3.Image = Properties.Resources.insert__2_;
            button3.Location = new Point(-10, -16);
            button3.Name = "button3";
            button3.Size = new Size(216, 99);
            button3.TabIndex = 2;
            button3.Text = "     Insert";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseEnter += button1_MouseEnter;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(0, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 61);
            panel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Variable Small", 10.2F);
            button2.Image = Properties.Resources.home__1_;
            button2.Location = new Point(-18, -22);
            button2.Name = "button2";
            button2.Size = new Size(216, 99);
            button2.TabIndex = 2;
            button2.Text = "     Home";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseEnter += button1_MouseEnter;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(6, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 103);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.menu;
            button1.Location = new Point(-24, 0);
            button1.Name = "button1";
            button1.Size = new Size(211, 117);
            button1.TabIndex = 1;
            button1.Text = "     Menu";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // Sidebartime
            // 
            Sidebartime.Interval = 20;
            Sidebartime.Tick += Sidebartime_Tick;
            // 
            // Column6
            // 
            Column6.HeaderText = "Satuan";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Harga Jual";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 120;
            // 
            // Column4
            // 
            Column4.HeaderText = "Harga Beli";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // Column3
            // 
            Column3.HeaderText = "Stok";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 75;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama barang";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 135;
            // 
            // Column1
            // 
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.MenuHighlight;
            dataGridView1.Location = new Point(231, 510);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(627, 235);
            dataGridView1.TabIndex = 3;
            dataGridView1.Visible = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // datagridviuw
            // 
            datagridviuw.Location = new Point(56, 12);
            datagridviuw.Name = "datagridviuw";
            datagridviuw.Size = new Size(732, 426);
            datagridviuw.TabIndex = 4;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sidebar);
            Controls.Add(dataGridView1);
            Controls.Add(datagridviuw);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "index";
            Load += index_Load;
            sidebar.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private Panel panel3;
        private Panel panel2;
        private Button button1;
        private Panel panel4;
        private Panel panel5;
        private Button button4;
        private Panel panel6;
        private Button button5;
        private Button button3;
        private Button button2;
        private System.Windows.Forms.Timer Sidebartime;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dataGridView1;
        private Panel datagridviuw;
    }
}