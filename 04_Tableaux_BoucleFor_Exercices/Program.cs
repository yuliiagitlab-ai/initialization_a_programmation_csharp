class Program
{
    static void Main()
    {
        // ============================================================
        // EXERCICE 1 — Remplir un tableau avec des valeurs saisies
        // ============================================================

        // Création d'un tableau de 6 entiers.
        // Creation du tableau de 6 Valeur => [0,0,0,0,0,0]
        // Par défaut, les valeurs sont initialisées à 0.
        int[] tabExo1 = new int[6];

        // On utilise un index pour parcourir le tableau avec une boucle while.
        int index = 0;

        // Tant que l'index est STRICTEMENT inférieur à la taille du tableau,
        // on continue à demander une valeur à l'utilisateur.
        while (index < tabExo1.Length)
        {
            Console.Write($"Entrez un nombre (case {index}) : ");

            // Lecture de l'entrée utilisateur + conversion en entier.
            // Note : int.Parse lève une exception si l'entrée n'est pas un nombre.
            tabExo1[index] = int.Parse(Console.ReadLine());

            // Incrémentation obligatoire pour éviter une boucle infinie.
            index++;
        }

        Console.WriteLine("\n--- Contenu du tableau (Exo 1) ---");

        // Boucle for : version plus compacte pour parcourir un tableau.
        for (int i = 0; i < tabExo1.Length; i++)
        {
            Console.WriteLine($"tabExo1[{i}] = {tabExo1[i]}");
        }

        // ============================================================
        // EXERCICE 2 — Remplir un tableau avec des puissances de 2
        // ============================================================

        // Création d'un tableau de 10 entiers.
        int[] tabExo2 = new int[10];

        // Variable "valeur" qui va évoluer à chaque tour (multipliée par 2).
        // Ici, on démarre à 1 puis on calcule 2, 4, 8, 16, ...
        int valeur = 1;

        // On remplit le tableau :
        // à chaque itération, on double "valeur" et on la stocke dans tabExo2[i].
        for (int i = 0; i < tabExo2.Length; i++)
        {
            valeur *= 2;       // équivalent à : valeur = valeur * 2;
            tabExo2[i] = valeur;
        }

        Console.WriteLine("\n--- Contenu du tableau (Exo 2) ---");

        // Affichage des valeurs du tableau.
        for (int i = 0; i < tabExo2.Length; i++)
        {
            Console.WriteLine($"tabExo2[{i}] = {tabExo2[i]}");
        }
    }
}


