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
    public partial class AddLokasi : Form
    {
        public AddLokasi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Tamara-Desktop\SQLEXPRESS;Initial Catalog=Simulasi3;Integrated Security=True;Trust Server Certificate=True");

        private void Tambah_Click(object sender, EventArgs e)
        {
            try
            {
                string NamaLokasi = NamaLoc.Text;
                string AlamatLokasi = AlamatLoc.Text;
                string Deskripsi = Des.Text;
                string Kategori = Kategoris.Text;
                decimal HargaTiket = Convert.ToDecimal(HargaTic.Text);

                byte[] gambar = File.ReadAllBytes(selectedImage);

                if (string.IsNullOrEmpty(NamaLokasi) || string.IsNullOrEmpty(AlamatLokasi) || string.IsNullOrEmpty(Deskripsi)
                    || string.IsNullOrEmpty(Kategori))
                {
                    MessageBox.Show("Harus Semuanya di isi Boy", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Lokasi (NamaLokasi, AlamatLokasi, Deskripsi, Kategori, HargaTiket, Gambar) " +
                    "VALUES (@NamaLokasi, @AlamatLokasi, @Deskripsi, @Kategori, @HargaTiket, @Gambar)", conn);

                cmd.Parameters.AddWithValue("@NamaLokasi", NamaLokasi);
                cmd.Parameters.AddWithValue("@AlamatLokasi", AlamatLokasi);
                cmd.Parameters.AddWithValue("@Deskripsi", Deskripsi);
                cmd.Parameters.AddWithValue("@Kategori", Kategori);
                cmd.Parameters.AddWithValue("@HargaTiket", HargaTiket);
                cmd.Parameters.AddWithValue("@Gambar", gambar);

                int berhasil = cmd.ExecuteNonQuery();

                if (berhasil > 0)
                {
                    MessageBox.Show("Data Lokasi Berhasil Di Tambahbahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Lokasi Gagal Di Tambahkan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private string selectedImage = string.Empty;

        private void TmbGambar()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Tampilkan gambar di PictureBox
                    pictureBox1.Image = Image.FromFile(ofd.FileName);

                    selectedImage = ofd.FileName;
                }
            }
        }

        private void btnGambar_Click(object sender, EventArgs e)
        {
            TmbGambar();
        }
    }
}
