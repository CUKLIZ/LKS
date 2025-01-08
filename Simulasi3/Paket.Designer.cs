namespace Simulasi3
{
    partial class Paket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            PaketHemat = new ReaLTaiizor.Controls.Button();
            Welcome = new Label();
            panel2 = new Panel();
            PaketLengkap = new ReaLTaiizor.Controls.Button();
            label1 = new Label();
            textbox = new Label();
            label2 = new Label();
            TotalTiket = new ReaLTaiizor.Controls.AloneTextBox();
            label3 = new Label();
            label4 = new Label();
            NamaPaket = new Label();
            NamaHotel = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            TotalHarga = new ReaLTaiizor.Controls.AloneTextBox();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            button1 = new ReaLTaiizor.Controls.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(PaketHemat);
            panel1.Controls.Add(Welcome);
            panel1.Location = new Point(67, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 118);
            panel1.TabIndex = 0;
            // 
            // PaketHemat
            // 
            PaketHemat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PaketHemat.BackColor = Color.Transparent;
            PaketHemat.BorderColor = Color.FromArgb(32, 34, 37);
            PaketHemat.EnteredBorderColor = Color.FromArgb(0, 117, 214);
            PaketHemat.EnteredColor = Color.FromArgb(32, 34, 37);
            PaketHemat.Font = new Font("Microsoft Sans Serif", 12F);
            PaketHemat.Image = null;
            PaketHemat.ImageAlign = ContentAlignment.MiddleLeft;
            PaketHemat.InactiveColor = Color.LimeGreen;
            PaketHemat.Location = new Point(33, 80);
            PaketHemat.Name = "PaketHemat";
            PaketHemat.PressedBorderColor = Color.FromArgb(0, 117, 214);
            PaketHemat.PressedColor = Color.FromArgb(0, 117, 214);
            PaketHemat.Size = new Size(130, 23);
            PaketHemat.TabIndex = 95;
            PaketHemat.Text = "Beli";
            PaketHemat.TextAlignment = StringAlignment.Center;
            PaketHemat.Click += PaketHemat_Click;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Segoe UI", 15F);
            Welcome.Location = new Point(41, 16);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(122, 28);
            Welcome.TabIndex = 2;
            Welcome.Text = "Paket Hemat";
            // 
            // panel2
            // 
            panel2.Controls.Add(PaketLengkap);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(534, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 118);
            panel2.TabIndex = 3;
            // 
            // PaketLengkap
            // 
            PaketLengkap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PaketLengkap.BackColor = Color.Transparent;
            PaketLengkap.BorderColor = Color.FromArgb(32, 34, 37);
            PaketLengkap.EnteredBorderColor = Color.FromArgb(0, 117, 214);
            PaketLengkap.EnteredColor = Color.FromArgb(32, 34, 37);
            PaketLengkap.Font = new Font("Microsoft Sans Serif", 12F);
            PaketLengkap.Image = null;
            PaketLengkap.ImageAlign = ContentAlignment.MiddleLeft;
            PaketLengkap.InactiveColor = Color.LimeGreen;
            PaketLengkap.Location = new Point(41, 80);
            PaketLengkap.Name = "PaketLengkap";
            PaketLengkap.PressedBorderColor = Color.FromArgb(0, 117, 214);
            PaketLengkap.PressedColor = Color.FromArgb(0, 117, 214);
            PaketLengkap.Size = new Size(130, 23);
            PaketLengkap.TabIndex = 96;
            PaketLengkap.Text = "Beli";
            PaketLengkap.TextAlignment = StringAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(41, 16);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 2;
            label1.Text = "Paket Lengkap";
            // 
            // textbox
            // 
            textbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textbox.AutoSize = true;
            textbox.Cursor = Cursors.Hand;
            textbox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textbox.ForeColor = Color.FromArgb(0, 117, 214);
            textbox.Location = new Point(6, 30);
            textbox.Name = "textbox";
            textbox.Size = new Size(100, 16);
            textbox.TabIndex = 125;
            textbox.Text = "Nama Paket :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(7, 74);
            label2.Name = "label2";
            label2.Size = new Size(81, 16);
            label2.TabIndex = 126;
            label2.Text = "Deskripsi :";
            // 
            // TotalTiket
            // 
            TotalTiket.BackColor = Color.Transparent;
            TotalTiket.EnabledCalc = true;
            TotalTiket.Font = new Font("Segoe UI", 9F);
            TotalTiket.ForeColor = Color.Black;
            TotalTiket.Location = new Point(94, 74);
            TotalTiket.MaxLength = 32767;
            TotalTiket.MultiLine = false;
            TotalTiket.Name = "TotalTiket";
            TotalTiket.ReadOnly = true;
            TotalTiket.Size = new Size(212, 72);
            TotalTiket.TabIndex = 127;
            TotalTiket.TextAlign = HorizontalAlignment.Left;
            TotalTiket.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 117, 214);
            label3.Location = new Point(6, 149);
            label3.Name = "label3";
            label3.Size = new Size(97, 16);
            label3.TabIndex = 128;
            label3.Text = "Nama Hotel :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 117, 214);
            label4.Location = new Point(5, 190);
            label4.Name = "label4";
            label4.Size = new Size(110, 16);
            label4.TabIndex = 129;
            label4.Text = "Nama Lokasi : ";
            // 
            // NamaPaket
            // 
            NamaPaket.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            NamaPaket.AutoSize = true;
            NamaPaket.Cursor = Cursors.Hand;
            NamaPaket.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NamaPaket.ForeColor = Color.FromArgb(0, 117, 214);
            NamaPaket.Location = new Point(112, 30);
            NamaPaket.Name = "NamaPaket";
            NamaPaket.Size = new Size(12, 16);
            NamaPaket.TabIndex = 130;
            NamaPaket.Text = "-";
            // 
            // NamaHotel
            // 
            NamaHotel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            NamaHotel.AutoSize = true;
            NamaHotel.Cursor = Cursors.Hand;
            NamaHotel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NamaHotel.ForeColor = Color.FromArgb(0, 117, 214);
            NamaHotel.Location = new Point(112, 149);
            NamaHotel.Name = "NamaHotel";
            NamaHotel.Size = new Size(12, 16);
            NamaHotel.TabIndex = 131;
            NamaHotel.Text = "-";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 117, 214);
            label5.Location = new Point(121, 190);
            label5.Name = "label5";
            label5.Size = new Size(12, 16);
            label5.TabIndex = 132;
            label5.Text = "-";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TotalHarga);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(NamaHotel);
            groupBox1.Controls.Add(NamaPaket);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TotalTiket);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textbox);
            groupBox1.Location = new Point(67, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(667, 283);
            groupBox1.TabIndex = 96;
            groupBox1.TabStop = false;
            groupBox1.Text = "Paket";
            // 
            // TotalHarga
            // 
            TotalHarga.BackColor = Color.Transparent;
            TotalHarga.EnabledCalc = true;
            TotalHarga.Font = new Font("Segoe UI", 9F);
            TotalHarga.ForeColor = Color.Black;
            TotalHarga.Location = new Point(430, 247);
            TotalHarga.MaxLength = 32767;
            TotalHarga.MultiLine = false;
            TotalHarga.Name = "TotalHarga";
            TotalHarga.ReadOnly = true;
            TotalHarga.Size = new Size(231, 30);
            TotalHarga.TabIndex = 138;
            TotalHarga.TextAlign = HorizontalAlignment.Left;
            TotalHarga.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 117, 214);
            label8.Location = new Point(322, 264);
            label8.Name = "label8";
            label8.Size = new Size(102, 16);
            label8.TabIndex = 137;
            label8.Text = " Total Harga :";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(322, 164);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(339, 80);
            dataGridView2.TabIndex = 136;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 117, 214);
            label7.Location = new Point(322, 134);
            label7.Name = "label7";
            label7.Size = new Size(89, 16);
            label7.TabIndex = 135;
            label7.Text = "Pilih Wisata";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(322, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(339, 80);
            dataGridView1.TabIndex = 134;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 117, 214);
            label6.Location = new Point(322, 20);
            label6.Name = "label6";
            label6.Size = new Size(86, 16);
            label6.TabIndex = 133;
            label6.Text = "Pilih Hotel :";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(32, 34, 37);
            button1.EnteredBorderColor = Color.FromArgb(0, 117, 214);
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.LimeGreen;
            button1.Location = new Point(740, 409);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(0, 117, 214);
            button1.PressedColor = Color.FromArgb(0, 117, 214);
            button1.Size = new Size(77, 23);
            button1.TabIndex = 97;
            button1.Text = "Beli";
            button1.TextAlignment = StringAlignment.Center;
            // 
            // Paket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Paket";
            Size = new Size(820, 451);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Welcome;
        private Panel panel2;
        private Label label1;
        private ReaLTaiizor.Controls.Button PaketHemat;
        private ReaLTaiizor.Controls.Button PaketLengkap;
        private Label textbox;
        private Label label2;
        private ReaLTaiizor.Controls.AloneTextBox TotalTiket;
        private Label label3;
        private Label label4;
        private Label NamaPaket;
        private Label NamaHotel;
        private Label label5;
        private GroupBox groupBox1;
        private Label label6;
        private DataGridView dataGridView2;
        private Label label7;
        private DataGridView dataGridView1;
        private Label label8;
        private ReaLTaiizor.Controls.AloneTextBox TotalHarga;
        private ReaLTaiizor.Controls.Button button1;
    }
}
