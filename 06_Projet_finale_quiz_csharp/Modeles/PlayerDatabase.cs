
using Microsoft.Data.SqlClient;

namespace QuizBelgique
{
    // "База даних" гравців (SQL)
    internal class PlayerDatabase
    {
        public string ConnectionString { get; set; }

        public PlayerDatabase(string connectionString)
        {
            ConnectionString = connectionString;
        }

        // Зберегти гравця у файл: формат "ім'я;бал"
        public void SavePlayer(Player player)
        {
            string sql = @"INSERT INTO Players (Name, Score) VALUES (@Name, @Score);";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", player.Name);
                    cmd.Parameters.AddWithValue("@Score", player.Score);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la lecture de la base : " + ex.Message);
            }
        }
        public void ShowAllPlayers()
        {
            Console.WriteLine("\n=== Joueurs enregistrés (base SQL) ===");

            const string sql = @"SELECT Name, Score, PlayedAt FROM Players ORDER BY PlayedAt DESC;";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            Console.WriteLine("Aucune joueur enregistré pour le moment.");
                            return;
                        }

                        int totalQuestions = 10;

                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            int score = reader.GetInt32(1);
                            DateTime playedAt = reader.GetDateTime(2);

                            int percent = score * 100 / totalQuestions;
                            

                            Console.WriteLine($"Joueur : {name} | Score : {score} / {totalQuestions} | Pourcentage : {percent} % | Date : {playedAt}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la lecture de la base : " + ex.Message);
            }

                
            
        }
    }
}

