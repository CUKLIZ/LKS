using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Simulasi3
{
    public partial class AddHotel : Form
    {
        public AddHotel()
        {
            InitializeComponent();
        }

        // Koneksi ke database
        SqlConnection conn = new SqlConnection(@"Data Source=Tamara-Desktop\SQLEXPRESS;Initial Catalog=Simulasi3;Integrated Security=True;Trust Server Certificate=True");

        // Untuk Penyimpan Gambar Cuy
        private string selectedImagePath = string.Empty;

        private void TmbGambar()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Pilih Gambar";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Tampilkan gambar di PictureBox
                    pictureBox1.Image = Image.FromFile(ofd.FileName);

                    // Simpan path gambar (opsional, jika ingin menyimpan path saja)
                    selectedImagePath = ofd.FileName;
                }
            }

        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil data dari TextBox
                string namaHotel = NamaTel.Text;
                string alamatHotel = AlamatTel.Text;
                string deskripsi = Des.Text;
                decimal hargaPerMalam = Convert.ToDecimal(HargaPerMalam.Text);
                int bintang = Convert.ToInt32(Bintang.Text);

                if (string.IsNullOrEmpty(namaHotel) || string.IsNullOrEmpty(alamatHotel) || string.IsNullOrEmpty(deskripsi) ||
                    hargaPerMalam <= 0 || bintang <= 0 || string.IsNullOrEmpty(selectedImagePath))
                {
                    MessageBox.Show("Semua data harus diisi dengan benar, termasuk gambar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Baca file gambar ke byte array
                byte[] gambar = File.ReadAllBytes(selectedImagePath);

                // Query insert ke tabel Hotel
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Hotel (NamaHotel, AlamatHotel, Deskripsi, HargaPerMalam, Bintang, Gambar) " +
                                                "VALUES (@NamaHotel, @AlamatHotel, @Deskripsi, @HargaPerMalam, @Bintang, @Gambar)", conn);

                // Tambahkan parameter
                cmd.Parameters.AddWithValue("@NamaHotel", namaHotel);
                cmd.Parameters.AddWithValue("@AlamatHotel", alamatHotel);
                cmd.Parameters.AddWithValue("@Deskripsi", deskripsi);
                cmd.Parameters.AddWithValue("@HargaPerMalam", hargaPerMalam);
                cmd.Parameters.AddWithValue("@Bintang", bintang);
                cmd.Parameters.AddWithValue("@Gambar", gambar);

                // Eksekusi query
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data Hotel berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Hotel gagal ditambahkan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnGambar_Click(object sender, EventArgs e)
        {
            TmbGambar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
