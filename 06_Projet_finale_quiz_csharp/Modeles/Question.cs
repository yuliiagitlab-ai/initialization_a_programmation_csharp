using System;
using System.Collections.Generic;
using System.Text;


namespace QuizBelgique
{
    #region // Classe Question :
    // Représente une seule question du quiz.
    // Chaque question possède :
    // - un texte (Text)
    // - une liste de réponses possibles (Options)
    // - l'indice de la bonne réponse (CorrectIndex)
    #endregion
    internal class Question
    {
        #region // Propriétés de la question :

        // Text :
        // - Contient l'énoncé complet de la question (souvent avec "Question #x" et le texte).

        // Options :
        // - Tableau de chaînes de caractères.
        // - Chaque élément représente une réponse possible (1, 2, 3, 4).

        // CorrectIndex :
        // - Indice (0-based) de la bonne réponse dans le tableau Options.
        //   Par exemple :
        //   Options = { "1789", "1830", "1914", "1945" }
        //   CorrectIndex = 1  => la bonne réponse est "1830".

        #endregion
        public string Text { get; set; }
        public string[] Options { get; set; }
        public int CorrectIndex { get; set; }

        #region // Constructeur :
        // - Permet de créer une nouvelle question en fournissant :
        //   * le texte de la question (text)
        //   * le tableau des réponses possibles (options)
        //   * l'indice de la bonne réponse (correctIndex)
        #endregion

        public Question(string text, string[] options, int correctIndex) // paramètres
        {
            Text = text;
            Options = options;
            CorrectIndex = correctIndex;
        }

        #region // Méthode Ask :
        // - Affiche la question et les options à l'écran.
        // - Demande à l'utilisateur de saisir une réponse (1, 2, 3 ou 4).
        // - Vérifie si la saisie est valide (nombre dans le bon intervalle).
        // - Compare la réponse du joueur avec CorrectIndex.
        // - Retourne true si la réponse est correcte, false sinon.
        #endregion
        public bool Ask()
        {
            // Ligne vide pour aérer l'affichage
            // Affichage du texte de la question

            Console.WriteLine();
            Console.WriteLine(Text);

            // Affichage des options numérotées (1, 2, 3, 4)
            for (int i = 0; i < Options.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + Options[i]);
            }

            int answer;

            // Boucle de lecture de la réponse :
            // On reste dans la boucle tant que la saisie n'est pas un nombre valide.

            while (true)
            {
                Console.Write("Votre réponse (1-" + Options.Length + ") : ");
                string input = Console.ReadLine();

                // int.TryParse :
                // - essaie de convertir la saisie en entier (answer).
                // - renvoie true si la conversion fonctionne.
                // On vérifie aussi que la réponse est dans [1 ; Options.Length].

                if (int.TryParse(input, out answer) &&
                    answer >= 1 && answer <= Options.Length)
                {
                    // Saisie valide → on sort de la boucle
                    break;
                }

                Console.WriteLine("Entrée invalide. Essayez encore.");
            }

            // On compare la réponse (answer) à l'indice correct.
            // Attention :
            // - answer est 1-based (1, 2, 3, 4)
            // - CorrectIndex est 0-based (0, 1, 2, 3)
            // Donc on fait answer - 1.

            if (answer - 1 == CorrectIndex)
            {
                Console.WriteLine("✅ Correct !");
                return true;
            }
            else
            {
                Console.WriteLine("❌ Incorrect. La bonne réponse était : " + Options[CorrectIndex]);
                return false;
            }
        }
    }
}
