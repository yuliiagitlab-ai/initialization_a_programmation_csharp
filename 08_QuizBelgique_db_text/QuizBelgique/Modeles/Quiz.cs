using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace QuizBelgique
{
    #region // Classe Quiz :
    // Cette classe représente un quiz complet.
    // Elle ne contient pas les questions elles-mêmes (c'est le rôle de la classe Question),
    // mais elle possède une liste de questions et une méthode Run() pour lancer le quiz pour un joueur donné.
    #endregion
    internal class Quiz
    {
        #region // Propriété publique Questions :
        // - C'est la liste de toutes les questions qui composent ce quiz.
        // - Chaque élément de la liste est un objet de type Question.
        // - Le type List<Question> permet d'ajouter, de parcourir et de gérer plusieurs questions.
        #endregion
        public List<Question> Questions { get; set; }

        #region // Constructeur du Quiz :
        // - Il reçoit en paramètre une liste de questions (questions),
        //   généralement construite dans Program.cs.
        // - On stocke cette liste dans la propriété Questions pour pouvoir
        //   l'utiliser plus tard dans la méthode Run().
        #endregion
        public Quiz(List<Question> questions)
        {
            Questions = questions;
        }

        #region // Méthode Run :
        // - Cette méthode lance réellement le quiz pour un joueur donné.
        // - Le paramètre "player" représente le joueur qui est en train de jouer.
        // - Pour chaque question de la liste, on appelle Question.Ask().
        //   * Ask() affiche la question, lit la réponse de l'utilisateur
        //     et retourne true si la réponse est correcte, false sinon.
        // - Si la réponse est correcte (correct == true), on appelle player.AddPoint()
        //   pour augmenter le score du joueur.
        #endregion
        public void Run(Player player)
        {
            // On parcourt toutes les questions du quiz une par une
            foreach (Question q in Questions)
            {
                // On pose la question au joueur.
                // La méthode Ask() (Question.cs) renvoie true si la réponse est correcte.
                bool correct = q.Ask();

                // Si la réponse est correcte, on ajoute un point au joueur.
                if (correct)
                {
                    // AddPoint() est une méthode de la classe Player (Player.cs).
                    // Elle augmente le score du joueur de 1 lorsqu'une réponse est correcte.
                    player.AddPoint();
                }
            }

        }   // On ferme void Run
    }       // On ferme class Quiz
}           // On ferme namespace
