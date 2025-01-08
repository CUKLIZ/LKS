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
    public partial class Pesanan : UserControl
    {
        private int id;
        private string name;

        public Pesanan(int id, string name)
        {
            InitializeComponent();

            this.id = id;
            this.name = name;

            DataTampil();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Tamara-Desktop\SQLEXPRESS;Initial Catalog=Simulasi3;Integrated Security=True;Trust Server Certificate=True");

        private void Pesanan_Load(object sender, EventArgs e)
        {
            DataTampil();
        }

        private void DataTampil()
        {
            try
            {
                conn.Open();

                // Query untuk menampilkan pesanan yang diterima sesuai ID atau nama user
                string query = "SELECT * FROM Pesanan WHERE Status IN ('Accepted', 'Rejected') AND (IdUser = @IdUser OR NamaUser = @NamaUser)";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Menambahkan parameter
                cmd.Parameters.AddWithValue("@IdUser", id);
                cmd.Parameters.AddWithValue("@NamaUser", name);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Tampilkan data di DataGridView
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

    }
}
