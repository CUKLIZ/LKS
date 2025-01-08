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
    public partial class Lokasi : UserControl
    {
        private int id;
        private string name;
        private string role;
        public Lokasi(int id, string name, string role)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.role = role;


            Add.Visible = role == "Admin";

            if (role == "Admin")
            {
                NamaLokasi.ReadOnly = false;
                AlamatLokasi.ReadOnly = false;
                Deskripsi.ReadOnly = false;
                HargaTiket.ReadOnly = false;
                Kategori.ReadOnly = false;
                TotalTiket.ReadOnly = true;
            }
            else
            {
                Delete.Visible = false;
                Edit.Visible = false;
                IdLokasi.Visible = false;
                TotalTiket.ReadOnly = false;
            }

            DataTampil();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=Tamara-Desktop\SQLEXPRESS;Initial Catalog=Simulasi3;Integrated Security=True;Trust Server Certificate=True");


        private void DataTampil()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Lokasi", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;

            if (role == "User" && dataGridView1.Columns.Contains("IdLokasi"))
            {
                dataGridView1.Columns["IdLokasi"].Visible = false;
            }

            if (role == "User")
            {
                dataGridView1.ReadOnly = true;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(IdLokasi.Text))
                {
                    MessageBox.Show("Pilih Yang Mau Di Edit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                conn.Open();

                SqlCommand cmd = new SqlCommand(" UPDATE Lokasi SET NamaLokasi = @NamaLokasi, AlamatLokasi = @AlamatLokasi, Deskripsi = @Deskripsi, HargaTiket = @HargaTiket, Kategori = @Kategori, Gambar = @Gambar WHERE IdLokasi = @IdLokasi", conn);
                cmd.Parameters.AddWithValue("@IdLokasi", IdLokasi.Text);
                cmd.Parameters.AddWithValue("@NamaLokasi", NamaLokasi.Text);
                cmd.Parameters.AddWithValue("@AlamatLokasi", AlamatLokasi.Text);
                cmd.Parameters.AddWithValue("@Deskripsi", Deskripsi.Text);
                cmd.Parameters.AddWithValue("@HargaTiket", HargaTiket.Text);
                cmd.Parameters.AddWithValue("@Kategori", Kategori.Text);

                if (pictureBox1.Image != null)
                {
                    using(MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        byte[] imgData = ms.ToArray();

                        cmd.Parameters.AddWithValue("@Gambar", imgData);
                    }
                }

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data Berhasil Di Edit", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTampil();
                }
                else
                {
                    MessageBox.Show("Data Gagal Di Edit", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                NamaLokasi.Text = "";
                AlamatLokasi.Text = "";
                Deskripsi.Text = "";
                HargaTiket.Text = "";
                Kategori.Text = "";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                IdLokasi.Text = row.Cells["IdLokasi"].Value.ToString();
                NamaLokasi.Text = row.Cells["NamaLokasi"].Value.ToString();
                AlamatLokasi.Text = row.Cells["AlamatLokasi"].Value.ToString();
                Deskripsi.Text = row.Cells["Deskripsi"].Value.ToString();
                HargaTiket.Text = row.Cells["HargaTiket"].Value.ToString();
                Kategori.Text = row.Cells["Kategori"].Value.ToString();

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

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdLokasi.Text))
            {
                MessageBox.Show("Pilih Yang Mau Di Hapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conn.Open();

            SqlCommand cmd = new SqlCommand(" DELETE FROM Lokasi WHERE IdLokasi = @IdLokasi ", conn);
            cmd.Parameters.AddWithValue("@IdLokasi", IdLokasi.Text);


            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Data Berhasil Di Hapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTampil();
            }
            else
            {
                MessageBox.Show("Data Gagal Di Hapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            NamaLokasi.Text = "";
            AlamatLokasi.Text = "";
            Deskripsi.Text = "";
            HargaTiket.Text = "";
            Kategori.Text = "";

            conn.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddLokasi addLokasi = new AddLokasi();
            addLokasi.Show();
        }

        private void TotalHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void Beli_Click(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                MessageBox.Show("Admin tidak boleh membeli.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(TotalTiket.Text) || string.IsNullOrEmpty(TotalHarga.Text))
            {
                MessageBox.Show("Isi jumlah tiket yang ingin dibeli.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Pesanan (IdLokasi, NamaLokasi, TotalTiket, NamaUser, IdUser, TotalHarga, Status) " +
                    "VALUES (@IdLokasi, @NamaLokasi, @TotalTiket, @NamaUser, @IdUser, @TotalHarga, @Status)", conn);

                cmd.Parameters.AddWithValue("@IdLokasi", IdLokasi.Text);
                cmd.Parameters.AddWithValue("@NamaLokasi", NamaLokasi.Text);
                cmd.Parameters.AddWithValue("@TotalTiket", int.Parse(TotalTiket.Text));
                cmd.Parameters.AddWithValue("@NamaUser", name); // name dari parameter konstruktor
                cmd.Parameters.AddWithValue("@IdUser", id); // id dari parameter konstruktor
                cmd.Parameters.AddWithValue("@TotalHarga", decimal.Parse(TotalHarga.Text));
                cmd.Parameters.AddWithValue("@Status", "Pending");

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Pesanan berhasil dibuat.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal membuat pesanan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (int.TryParse(TotalTiket.Text, out int totalTiket) && decimal.TryParse(HargaTiket.Text, out decimal hargaTiket))
            {
                TotalHarga.Text = (totalTiket * hargaTiket).ToString();
            }
            else
            {
                TotalHarga.Text = "0";
            }
        }

        private void TotalTiket_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Lokasi_Load(object sender, EventArgs e)
        {

        }

        private void Gambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
