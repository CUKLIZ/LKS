using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Simulasi3
{
    public partial class Paket : UserControl
    {
        private int id;
        private string name;
        private string role;

        private decimal hargaHotel = 0;
        private decimal hargaLokasi = 0;
        private const decimal DISKON = 0.15m; // Diskon 15%

        SqlConnection conn = new SqlConnection(@"Data Source=Tamara-Desktop\SQLEXPRESS;Initial Catalog=Simulasi3;Integrated Security=True;Trust Server Certificate=True");

        public Paket(int id, string name, string role)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.role = role;

            // Default: sembunyikan DataGridView
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
        }

        private void PaketHemat_Click(object sender, EventArgs e)
        {
            // Tampilkan DataGridView dan isi data
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;

            TampilHotel();
            TampilLokasi();

            TotalTiket.Text = "Hanya Ada Tiket Wisata dan Hotel";
            NamaPaket.Text = "Paket Hemat";
        }

        private void TampilHotel()
        {
            try
            {
                conn.Open();
                string query = "SELECT IdHotel, NamaHotel, HargaPerMalam FROM Hotel";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void TampilLokasi()
        {
            try
            {
                conn.Open();
                string query = "SELECT IdLokasi, NamaLokasi, HargaTiket FROM Lokasi";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                NamaHotel.Text = row.Cells["NamaHotel"].Value.ToString();
                hargaHotel = Convert.ToDecimal(row.Cells["HargaPerMalam"].Value);
                HitungTotalHarga();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                label5.Text = row.Cells["NamaLokasi"].Value.ToString();
                hargaLokasi = Convert.ToDecimal(row.Cells["HargaTiket"].Value);
                HitungTotalHarga();
            }
        }

        private void HitungTotalHarga()
        {
            if (hargaHotel > 0 && hargaLokasi > 0)
            {
                decimal totalHarga = hargaHotel + hargaLokasi;
                decimal hargaDiskon = totalHarga - (totalHarga * DISKON);

                // Format mata uang Indonesia
                CultureInfo culture = new CultureInfo("id-ID");
                TotalHarga.Text = hargaDiskon.ToString("C", culture);
            }

        }
    }
}
