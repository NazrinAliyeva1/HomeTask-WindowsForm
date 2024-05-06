using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeTask_WindowsForms
{
    public partial class Form1 : Form
    {
        const string connectionString = "Server = LAPTOP-PVUROI38\\SQLEXPRESS; Database=MSPLATFORMST; Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.Columns.Add("Music", "Name");
            //dataGridView1.Columns.Add("Artist", "artistName");
            //dataGridView1.Columns.Add("duration", "Duration");
        }

        private void Create_Click(object sender, EventArgs e)
        {
            //
            string music = musicName.Text;
            string artist = artistName.Text;
            int CategoryId = Convert.ToInt32(categoryId.Text);
            int artistId = 1; 
            string timeInput = musicDuration.Text;

            
            TimeSpan duration;
            if (TimeSpan.TryParse(timeInput, out duration))
            {
               
                CreateMusic(music, artist, duration, CategoryId, artistId);
            }
            else
            {
                
                MessageBox.Show("Kecersiz zaman formatı. Zehmet olmasa 'saat:deqiqe:saniye' formatında bir zaman daxil edin.");
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void CreateMusic(string title, string artist, TimeSpan duration, int categoryId, int artistId)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string query = "INSERT INTO Musics (Name, Duration, CategoryId, ArtistId) VALUES (@Title, @Duration, @CategoryId, @ArtistId)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Artist", artist);
            command.Parameters.AddWithValue("@Duration", duration);
            command.Parameters.AddWithValue("@CategoryId", categoryId);
            command.Parameters.AddWithValue("@ArtistId", artistId);
            conn.Open();
            command.ExecuteNonQuery();
        }



        public void CreateArtist(string name, string genre)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string query = "INSERT INTO Artists (Name, Genre) VALUES (@Name, @Genre)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Genre", genre);
            conn.Open();
            command.ExecuteNonQuery();

        }
        // GetAll
        public DataTable GetAllMusic()
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string query = "SELECT * FROM Musics";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }




        // GetById
        public DataTable GetMusicById(int musicId)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM Musics WHERE Id = @MusicId";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@MusicId", musicId);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }


        // Update
        private void UpdateMusic(int id, string title, string artist, int duration)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string query = "UPDATE Music SET Title = @Title, Artist = @Artist, Duration = @Duration WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Artist", artist);
            command.Parameters.AddWithValue("@Duration", duration);

            try
            {
                conn.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Mahni ugurla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Daxil edilen ID ile mahni tapilmadi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mahni güncellenerken bir xeta yarandi: " + ex.Message);
            }
        }
        
        // Delete
        public void DeleteMusic(int id)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string query = "DELETE FROM Musics WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Id", id);

            try
            {
                conn.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Mahni ugurla silindi.");
                }
                else
                {
                    MessageBox.Show("Daxil edilen ID ile mahni tapilmadi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mahni silinerken bir xeta yarandi: " + ex.Message);
            }


        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetAll_Click(object sender, EventArgs e)
        {
            DataTable allMusic = GetAllMusic(); 
            dataGridView1.DataSource = allMusic;
        }

        private void GetById_Click(object sender, EventArgs e)
        {

            if (int.TryParse(id.Text, out int musicId))
            {
                DataTable musicData = GetMusicById(musicId);
                dataGridView2.DataSource = musicData;
            }
            else
            {
                MessageBox.Show("Zehmet olmasa kecerli bir Id daxil edin.");
            }



        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(updateId.Text, out int id))
            {
                MessageBox.Show("Kecerli bir Id daxil edin.");
                return;
            }

            string music = musicN.Text; 
            string artist = artistN.Text; 

            if (!int.TryParse(durationBtn.Text, out int duration))
            {
                MessageBox.Show("Zaman ucun kecerli reqem daxil edin.");
                return;
            }

            UpdateMusic(id, music, artist, duration);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lastId.Text))
            {
                if (int.TryParse(lastId.Text, out int id))
                {
                    DeleteMusic(id);
                }
                else
                {
                    MessageBox.Show("Kecerli bir ID girin.");
                }
            }
            else
            {
                MessageBox.Show("Zehmet olmasa bir ID girin.");
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
