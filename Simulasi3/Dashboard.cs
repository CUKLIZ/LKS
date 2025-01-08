using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Simulasi3
{
    public partial class Dashboard : Form
    {

        private int id;
        private string name;
        private string role;

        public Dashboard(int id, string name, string role)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.role = role;

            Welcome.Text = $"Welcome {name}";

            Paket.Visible = false;

            if (role != "Admin")
            {
                AdminTerima.Visible = false;
                Aktifitas.Visible = false;
                button2.Text = "Aktifitas";
                button3.Visible = false;
            }
            else
            {
                UserPesanan.Visible = false;
            }

            fromLoad(new Home());

        }
        SqlConnection conn = new SqlConnection(@"Data Source=Tamara-Desktop\SQLEXPRESS;Initial Catalog=Simulasi3;Integrated Security=True;Trust Server Certificate=True");
        private void Welcome_Click(object sender, EventArgs e)
        {

        }
        private void Logout_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lokasi_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            Lokasi lokasi = new Lokasi(id, name, role);
            lokasi.Dock = DockStyle.Fill;

            panel2.Controls.Add(lokasi);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            Pesanan userPesanan = new Pesanan(id, name);
            userPesanan.Dock = DockStyle.Fill;

            panel2.Controls.Add(userPesanan);
        }

        private void AdminTerima_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            Terima lokasi = new Terima();
            lokasi.Dock = DockStyle.Fill;

            panel2.Controls.Add(lokasi);
        }

        private void Logout_Click_1(object sender, EventArgs e)
        {
            LoginPage back = new LoginPage();
            back.Show();
            this.Close();
        }

        private void Hotel_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            Hotel htl = new Hotel(id, name, role);

            htl.Dock = DockStyle.Fill;

            panel2.Controls.Add(htl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            TerimaHotel htl = new TerimaHotel(id, name, role);

            htl.Dock = DockStyle.Fill;

            panel2.Controls.Add(htl);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            PesananHotel htl = new PesananHotel(id, name, role);

            htl.Dock = DockStyle.Fill;

            panel2.Controls.Add(htl);
        }

        private void Paket_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            Paket htl = new Paket(id, name, role);

            htl.Dock = DockStyle.Fill;

            panel2.Controls.Add(htl);
        }

        void fromLoad(Form form)
        {
            panel2.Controls.Clear();
            form.TopMost = true;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(form);
            form.Show();
        }        

        private void Home_Click(object sender, EventArgs e)
        {
            fromLoad(new Home());
        }
    }
}
