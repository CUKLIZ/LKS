using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace Simulasi3
{
    public partial class TerimaHotel : UserControl
    {
        private int id;
        private string name;
        private string role;

        public TerimaHotel(int id, string name, string role)
        {
            InitializeComponent();

            DataTampil();
            this.id = id;
            this.name = name;
            this.role = role;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=Tamara-Desktop\SQLEXPRESS;Initial Catalog=Simulasi3;Integrated Security=True;Trust Server Certificate=True");

        private void DataTampil()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM PesananHotel WHERE Status = 'Pending'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Isi TextBox dengan data dari DataGridView
                IdPesanan.Text = row.Cells["IdPesanan"].Value.ToString();
                NamaLokasi.Text = row.Cells["NamaHotel"].Value.ToString();
                TotalTiket.Text = row.Cells["BerapaHari"].Value.ToString();
                NamaUser.Text = row.Cells["NamaUser"].Value.ToString();
                TotalHarga.Text = row.Cells["TotalHarga"].Value.ToString();
                Status.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdPesanan.Text))
            {
                MessageBox.Show("Pilih pesanan yang ingin diterima.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE PesananHotel SET Status = 'Accepted' WHERE IdPesanan = @IdPesanan", conn);
                cmd.Parameters.AddWithValue("@IdPesanan", IdPesanan.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Pesanan diterima.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTampil();
                }
                else
                {
                    MessageBox.Show("Gagal menerima pesanan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void Tolak_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdPesanan.Text))
            {
                MessageBox.Show("Pilih pesanan yang ingin ditolak.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE PesananHotel SET Status = 'Rejected' WHERE IdPesanan = @IdPesanan", conn);
                cmd.Parameters.AddWithValue("@IdPesanan", IdPesanan.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Pesanan ditolak.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTampil();
                }
                else
                {
                    MessageBox.Show("Gagal menolak pesanan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}
