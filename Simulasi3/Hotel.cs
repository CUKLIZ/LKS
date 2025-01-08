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
    public partial class Hotel : UserControl
    {
        private int id;
        private string name;
        private string role;
        public Hotel(int id, string name, string role)
        {
            InitializeComponent();

            Add.Visible = role == "Admin";

            if (role == "Admin")
            {
                NamaHotel.ReadOnly = false;
                AlamatHotel.ReadOnly = false;
                Deskripsi.ReadOnly = false;
                HargaPerMalam.ReadOnly = false;
                Bintang.ReadOnly = false;
                TotalTiket.ReadOnly = true;
            }
            else
            {
                Gambar.Visible = false;
                Delete.Visible = false;
                Edit.Visible = false;
                IdHotel.Visible = false;
                TotalTiket.ReadOnly = false;
                button1.Visible = false;
            }

            DataTampil();
            this.id = id;
            this.name = name;
            this.role = role;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Tamara-Desktop\SQLEXPRESS;Initial Catalog=Simulasi3;Integrated Security=True;Trust Server Certificate=True");

        private void DataTampil()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Hotel", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;

            if (role == "User" && dataGridView1.Columns.Contains("IdHotel"))
            {
                dataGridView1.Columns["IdHotel"].Visible = false;
            }

            if (role == "User")
            {
                dataGridView1.ReadOnly = true;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                IdHotel.Text = row.Cells["IdHotel"].Value.ToString();
                NamaHotel.Text = row.Cells["NamaHotel"].Value.ToString();
                AlamatHotel.Text = row.Cells["AlamatHotel"].Value.ToString();
                Deskripsi.Text = row.Cells["Deskripsi"].Value.ToString();
                HargaPerMalam.Text = row.Cells["HargaPerMalam"].Value.ToString();
                Bintang.Text = row.Cells["Bintang"].Value.ToString();

                if (row.Cells["Gambar"].Value != DBNull.Value)
                {
                    byte[] imgData = (byte[])row.Cells["Gambar"].Value;
                    MemoryStream ms = new MemoryStream(imgData);
                    pictureBox1.Image = Image.FromStream(ms);
                } else
                {
                    pictureBox1.Image = null;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddHotel sasa = new AddHotel();
            sasa.Show();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdHotel.Text))
            {
                MessageBox.Show("Pilih hotel yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Hotel WHERE IdHotel = @IdHotel", conn);
                cmd.Parameters.AddWithValue("@IdHotel", IdHotel.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Hotel berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTampil();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus hotel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Reset form
            IdHotel.Text = "";
            NamaHotel.Text = "";
            AlamatHotel.Text = "";
            Deskripsi.Text = "";
            HargaPerMalam.Text = "";
            Bintang.Text = "";
        }

        private void Edi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdHotel.Text))
            {
                MessageBox.Show("Pilih hotel yang ingin diubah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Hotel SET NamaHotel = @NamaHotel, AlamatHotel = @AlamatHotel, Deskripsi = @Deskripsi, HargaPerMalam = @HargaPerMalam, Bintang = @Bintang, Gambar = @Gambar WHERE IdHotel = @IdHotel", conn);
                cmd.Parameters.AddWithValue("@IdHotel", IdHotel.Text);
                cmd.Parameters.AddWithValue("@NamaHotel", NamaHotel.Text);
                cmd.Parameters.AddWithValue("@AlamatHotel", AlamatHotel.Text);
                cmd.Parameters.AddWithValue("@Deskripsi", Deskripsi.Text);
                cmd.Parameters.AddWithValue("@HargaPerMalam", HargaPerMalam.Text);
                cmd.Parameters.AddWithValue("@Bintang", Bintang.Text);

                // Simpan gambar hanya jika PictureBox memiliki gambar
                if (pictureBox1.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        byte[] imgData = ms.ToArray();
                        cmd.Parameters.AddWithValue("@Gambar", imgData);
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Gambar", DBNull.Value);
                }

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data hotel berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTampil();
                }
                else
                {
                    MessageBox.Show("Gagal mengubah data hotel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Reset form
            IdHotel.Text = "";
            NamaHotel.Text = "";
            AlamatHotel.Text = "";
            Deskripsi.Text = "";
            HargaPerMalam.Text = "";
            Bintang.Text = "";
        }


        private void Bel_Click(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                MessageBox.Show("Admin tidak boleh memesan hotel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(TotalTiket.Text) || string.IsNullOrEmpty(TotalHarga.Text))
            {
                MessageBox.Show("Isi jumlah hari menginap.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO PesananHotel (IdHotel, NamaHotel, BerapaHari, NamaUser, IdUser, TotalHarga, Status) " +
                    "VALUES (@IdHotel, @NamaHotel, @BerapaHari, @NamaUser, @IdUser, @TotalHarga, @Status)", conn);

                cmd.Parameters.AddWithValue("@IdHotel", IdHotel.Text);
                cmd.Parameters.AddWithValue("@NamaHotel", NamaHotel.Text);
                cmd.Parameters.AddWithValue("@BerapaHari", int.Parse(TotalTiket.Text));
                cmd.Parameters.AddWithValue("@NamaUser", name); // name dari parameter konstruktor
                cmd.Parameters.AddWithValue("@IdUser", id); // id dari parameter konstruktor
                cmd.Parameters.AddWithValue("@TotalHarga", decimal.Parse(TotalHarga.Text));
                cmd.Parameters.AddWithValue("@Status", "Pending");

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Pesanan hotel berhasil dibuat.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal membuat pesanan hotel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                TotalTiket.Text = "";
                TotalHarga.Text = "";

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

        private void TotalTiket_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(TotalTiket.Text, out int berapaHari) && decimal.TryParse(HargaPerMalam.Text, out decimal hargaPerMalam))
            {
                TotalHarga.Text = (berapaHari * hargaPerMalam).ToString();
            }
            else
            {
                TotalHarga.Text = "0";
            }
        }

        private void Gambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
