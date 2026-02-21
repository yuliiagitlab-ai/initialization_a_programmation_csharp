using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizBelgique
{
    // "База даних" гравців (через текстовий файл)
    internal class PlayerDatabase
    {
        public string FilePath { get; set; }

        public PlayerDatabase(string filePath)
        {
            FilePath = filePath;
        }

        // Зберегти гравця у файл: формат "ім'я;бал"
        public void SavePlayer(Player player)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath, append: true))
                {
                    writer.WriteLine(player.Name + ";" + player.Score);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'enregistrement du joueur : " + ex.Message);
            }
        }

        // Показати всіх гравців з "бази"
        public void ShowAllPlayers()
        {
            Console.WriteLine("\n=== Joueurs enregistrés (base de données) ===");

            if (!File.Exists(FilePath))
            {
                Console.WriteLine("Aucun joueur enregistré pour le moment.");
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(FilePath);

                if (lines.Length == 0)
                {
                    Console.WriteLine("Aucun joueur enregistré pour le moment.");
                    return;
                }

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 2)
                    {
                        string name = parts[0];
                        string scoreText = parts[1];
                        Console.WriteLine("Joueur : " + name + " | Score : " + scoreText);
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

