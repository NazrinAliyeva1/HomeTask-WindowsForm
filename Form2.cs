using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeTask_WindowsForms
{
    public partial class Form2 : Form
    {
        const string connectionString = "Server = LAPTOP-PVUROI38\\SQLEXPRESS; Database=MSPLATFORMST; Trusted_Connection=True;";

        public Form2()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string name = artistName.Text;
            string genre = musicGenre.Text;

            
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(genre))
            {
                MessageBox.Show("Zehmet olmasa senetci adi ve soyadi daxil edin.");
                return;
            }

            try
            {
                CreateArtistNew(name, genre);
                MessageBox.Show("Senetci ugurla elave edildi.", "Ugurlu");

                // elave etdikden sonra formu temizleyek
                artistName.Text = "";
                musicGenre.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Senetci elave olunarken xeta yarandi: " + ex.Message, "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void CreateArtistNew(string name, string genre)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string query = "INSERT INTO Artists (Name, Genre) VALUES (@Name, @Genre)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Genre", genre);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Senetci ugurla yarandi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Senetci elave olunarken xeta yarandi: " + ex.Message);
            }
        }
        private void GetAllArtists()
        {
            DataTable artistsTable = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Name, Genre FROM Artists";
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(artistsTable);
                }

               
                dataGridView1.DataSource = artistsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Senetçi alinarken  xeta yarandi: " + ex.Message, "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public DataTable GetArtistById(int id)
        {
            DataTable artistTable = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Name, Genre FROM Artists WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Id", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(artistTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Senetçi alinarken  xeta yarandi: " + ex.Message);
            }
            return artistTable;
        }

        //forms


       
        public void UpdateArtist(int id, string name)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string query = "UPDATE Artists SET Name = @Name WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);

            try
            {
                conn.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Senetçi ugurla guncellendi.");
                }
                else
                {
                    Console.WriteLine("Daxil edilen ID ile senetçi tapilmadi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Senetçi güncellenerken bir xeta yarandi: " + ex.Message);
            }
        }

    
        public void DeleteArtist(int id)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string query = "DELETE FROM Artists WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Id", id);

            try
            {
                conn.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Senetçi ugurla silindi.");
                }
                else
                {
                    Console.WriteLine("Daxil edilen ID ile senetçi tapilmadi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Senetçi silinerken bir xeta yarandi: " + ex.Message);
            }
        }

        private void GetById_Click(object sender, EventArgs e)
        {
            if (int.TryParse(id.Text, out int artistId))
            {
                GetArtistById(artistId);
            }
            else
            {
                MessageBox.Show("Zehmet olmasa kecerli bir ID girin.");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (int.TryParse(id.Text, out int artistId))
            {
                string newName = artistName.Text;

                UpdateArtist(artistId, newName);
            }
            else
            {
                MessageBox.Show("Zehmet olmasa kecerli bir ID girin.");
            }
        }

        private void GetAll_Click(object sender, EventArgs e)
        {
            GetAllArtists();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan silinecek sanatçının ID'sini al
            if (int.TryParse(lastId.Text, out int artistId))
            {
                // Sanatçıyı sil
                DeleteArtist(artistId);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



}