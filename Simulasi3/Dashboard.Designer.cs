namespace Simulasi3
{
    partial class Dashboard
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
            panel1 = new Panel();
            label1 = new Label();
            Logout = new Label();
            Welcome = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            Paket = new Button();
            Lokasi = new Button();
            Hotel = new Button();
            Aktifitas = new Button();
            AdminTerima = new Button();
            button3 = new Button();
            button1 = new Button();
            UserPesanan = new Button();
            button4 = new Button();
            panel2 = new Panel();
            Home = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 35, 38);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Logout);
            panel1.Controls.Add(Welcome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 44);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("MV Boli", 15F);
            label1.ForeColor = Color.FromArgb(236, 200, 21);
            label1.Location = new Point(893, 9);
            label1.Name = "label1";
            label1.Size = new Size(26, 26);
            label1.TabIndex = 2;
            label1.Text = "X";
            label1.Click += label1_Click_1;
            // 
            // Logout
            // 
            Logout.AutoSize = true;
            Logout.Cursor = Cursors.Hand;
            Logout.Font = new Font("MV Boli", 15F);
            Logout.ForeColor = Color.FromArgb(236, 200, 21);
            Logout.Location = new Point(787, 9);
            Logout.Name = "Logout";
            Logout.Size = new Size(77, 26);
            Logout.TabIndex = 1;
            Logout.Text = "Logout";
            Logout.Click += Logout_Click_1;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("MV Boli", 15F);
            Welcome.ForeColor = Color.FromArgb(236, 200, 21);
            Welcome.Location = new Point(420, 9);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(93, 26);
            Welcome.TabIndex = 0;
            Welcome.Text = "Welcome";
            Welcome.Click += Welcome_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(119, 181, 211);
            flowLayoutPanel1.Controls.Add(Home);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(Hotel);
            flowLayoutPanel1.Controls.Add(Lokasi);
            flowLayoutPanel1.Controls.Add(Paket);
            flowLayoutPanel1.Controls.Add(Aktifitas);
            flowLayoutPanel1.Controls.Add(AdminTerima);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(UserPesanan);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 44);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(100, 494);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(236, 200, 21);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Orange;
            button2.FlatAppearance.MouseOverBackColor = Color.Orange;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(3, 50);
            button2.Name = "button2";
            button2.Size = new Size(97, 28);
            button2.TabIndex = 10;
            button2.Text = "Master";
            button2.UseVisualStyleBackColor = false;
            // 
            // Paket
            // 
            Paket.BackColor = Color.FromArgb(119, 181, 211);
            Paket.Cursor = Cursors.Hand;
            Paket.FlatAppearance.BorderSize = 0;
            Paket.FlatStyle = FlatStyle.Flat;
            Paket.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            Paket.ForeColor = Color.DarkSlateGray;
            Paket.Location = new Point(3, 178);
            Paket.Name = "Paket";
            Paket.Size = new Size(97, 41);
            Paket.TabIndex = 15;
            Paket.Text = "Paket";
            Paket.UseVisualStyleBackColor = false;
            Paket.Click += Paket_Click;
            // 
            // Lokasi
            // 
            Lokasi.BackColor = Color.FromArgb(119, 181, 211);
            Lokasi.Cursor = Cursors.Hand;
            Lokasi.FlatAppearance.BorderSize = 0;
            Lokasi.FlatStyle = FlatStyle.Flat;
            Lokasi.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            Lokasi.ForeColor = Color.DarkSlateGray;
            Lokasi.Location = new Point(3, 131);
            Lokasi.Name = "Lokasi";
            Lokasi.Size = new Size(97, 41);
            Lokasi.TabIndex = 2;
            Lokasi.Text = "Lokasi";
            Lokasi.UseVisualStyleBackColor = false;
            Lokasi.Click += Lokasi_Click;
            // 
            // Hotel
            // 
            Hotel.BackColor = Color.FromArgb(119, 181, 211);
            Hotel.Cursor = Cursors.Hand;
            Hotel.FlatAppearance.BorderSize = 0;
            Hotel.FlatStyle = FlatStyle.Flat;
            Hotel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            Hotel.ForeColor = Color.DarkSlateGray;
            Hotel.Location = new Point(3, 84);
            Hotel.Name = "Hotel";
            Hotel.Size = new Size(97, 41);
            Hotel.TabIndex = 11;
            Hotel.Text = "Hotel";
            Hotel.UseVisualStyleBackColor = false;
            Hotel.Click += Hotel_Click;
            // 
            // Aktifitas
            // 
            Aktifitas.BackColor = Color.FromArgb(236, 200, 21);
            Aktifitas.FlatAppearance.BorderSize = 0;
            Aktifitas.FlatAppearance.MouseDownBackColor = Color.Orange;
            Aktifitas.FlatAppearance.MouseOverBackColor = Color.Orange;
            Aktifitas.FlatStyle = FlatStyle.Flat;
            Aktifitas.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Aktifitas.ForeColor = Color.Black;
            Aktifitas.Location = new Point(3, 225);
            Aktifitas.Name = "Aktifitas";
            Aktifitas.Size = new Size(97, 28);
            Aktifitas.TabIndex = 9;
            Aktifitas.Text = "Aktifitas";
            Aktifitas.UseVisualStyleBackColor = false;
            // 
            // AdminTerima
            // 
            AdminTerima.BackColor = Color.FromArgb(119, 181, 211);
            AdminTerima.Cursor = Cursors.Hand;
            AdminTerima.FlatAppearance.BorderSize = 0;
            AdminTerima.FlatStyle = FlatStyle.Flat;
            AdminTerima.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            AdminTerima.ForeColor = Color.DarkSlateGray;
            AdminTerima.Location = new Point(3, 259);
            AdminTerima.Name = "AdminTerima";
            AdminTerima.Size = new Size(102, 53);
            AdminTerima.TabIndex = 12;
            AdminTerima.Text = "Terima Pesanan";
            AdminTerima.UseVisualStyleBackColor = false;
            AdminTerima.Click += AdminTerima_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(119, 181, 211);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            button3.ForeColor = Color.DarkSlateGray;
            button3.Location = new Point(3, 318);
            button3.Name = "button3";
            button3.Size = new Size(102, 53);
            button3.TabIndex = 13;
            button3.Text = "Terima Hotel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(236, 200, 21);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Orange;
            button1.FlatAppearance.MouseOverBackColor = Color.Orange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(3, 377);
            button1.Name = "button1";
            button1.Size = new Size(97, 28);
            button1.TabIndex = 10;
            button1.Text = "Laporan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserPesanan
            // 
            UserPesanan.BackColor = Color.FromArgb(119, 181, 211);
            UserPesanan.Cursor = Cursors.Hand;
            UserPesanan.FlatAppearance.BorderSize = 0;
            UserPesanan.FlatStyle = FlatStyle.Flat;
            UserPesanan.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            UserPesanan.ForeColor = Color.DarkSlateGray;
            UserPesanan.Location = new Point(3, 411);
            UserPesanan.Name = "UserPesanan";
            UserPesanan.Size = new Size(97, 41);
            UserPesanan.TabIndex = 11;
            UserPesanan.Text = "Pesanan";
            UserPesanan.UseVisualStyleBackColor = false;
            UserPesanan.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(119, 181, 211);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            button4.ForeColor = Color.DarkSlateGray;
            button4.Location = new Point(3, 458);
            button4.Name = "button4";
            button4.Size = new Size(97, 47);
            button4.TabIndex = 14;
            button4.Text = "Pesanan Hotel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            panel2.ForeColor = Color.DarkSlateGray;
            panel2.Location = new Point(100, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 494);
            panel2.TabIndex = 3;
            // 
            // Home
            // 
            Home.BackColor = Color.FromArgb(119, 181, 211);
            Home.Cursor = Cursors.Hand;
            Home.FlatAppearance.BorderSize = 0;
            Home.FlatStyle = FlatStyle.Flat;
            Home.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            Home.ForeColor = Color.DarkSlateGray;
            Home.Location = new Point(3, 3);
            Home.Name = "Home";
            Home.Size = new Size(97, 41);
            Home.TabIndex = 16;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 165, 221);
            ClientSize = new Size(920, 538);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label Logout;
        private Label Welcome;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Lokasi;
        private Panel panel2;
        private Button Aktifitas;
        private Button button1;
        private Button UserPesanan;
        private Button AdminTerima;
        private Button button2;
        private Button Hotel;
        private Button button3;
        private Button button4;
        private Button Paket;
        private Button Home;
    }
}