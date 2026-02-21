using System;
using System.Collections.Generic;
using System.Text;

namespace QuizBelgique
{
    #region // Classe Player :
    // Représente un joueur du quiz.
    // Cet objet permet de garder en mémoire :
    // - le nom du joueur (Name)
    // - son score (Score), c'est-à-dire le nombre de bonnes réponses.
    #endregion
    internal class Player
    {
        #region // Propriétés du joueur :

        // Name :
        // - Le nom saisi par l'utilisateur au début du programme.
        // - Sert à personnaliser les messages ("Bonjour, ...", "Bravo, ...").

        // Score :
        // - Nombre de réponses correctes.
        // - Initialisé à 0 dans le constructeur.
        // - Incrémenté à chaque bonne réponse (voir la méthode AddPoint()).
        #endregion

        public string Name { get; set; }
        public int Score { get; set; }

        #region // Constructeur :
        // - Reçoit le nom du joueur en paramètre (name).
        // - Initialise la propriété Name avec cette valeur.
        // - Initialise le Score à 0, car le joueur commence le quiz sans points.
        #endregion
        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        #region // Méthode AddPoint :
        // - Appelée lorsqu'une réponse est correcte.
        // - Incrémente le score du joueur de 1.
        // - Utilisée dans la classe Quiz, dans la méthode Run().
        #endregion
        public void AddPoint()
        {
            Score++;
        }
    }
}
