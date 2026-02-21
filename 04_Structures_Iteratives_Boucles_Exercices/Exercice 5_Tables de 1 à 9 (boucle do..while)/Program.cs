Console.OutputEncoding = System.Text.Encoding.UTF8;

//------------------------------------------------------------------------------------------
// Exercices Iteratives Boucles :
//------------------------------------------------------------------------------------------

#region Exercice 5 : Tables de 1 à 9 (boucle do..while)
// À l’aide de deux boucles, afficher les tables de multiplication de 1 à 9.
// (Attention boucles imbriquées !)
#endregion

#region En-tête en couleur
// Console.ForegroundColor : récupère la couleur actuelle du texte dans la console.
// ConsoleColor currentColor : stocke cette couleur dans une variable.
// Le but est de sauvegarder la couleur actuelle avant de la modifier, afin de pouvoir la restaurer plus tard.

ConsoleColor currentColor = Console.ForegroundColor; // pour sauvegarder la couleur avant de la changer
// ----------------------------------------------------------------------------------------------------
// Exercice 5 : Tables de 1 à 9 (boucle do..while)
// ----------------------------------------------------------------------------------------------------
Console.ForegroundColor = ConsoleColor.DarkGreen; //change la couleur de l'écriture dans la console
Console.WriteLine("\n--------------------------------------");
Console.WriteLine("\t✏️ Tables de 1 à 9 ");
Console.WriteLine("--------------------------------------");
Console.WriteLine();
Console.ForegroundColor = currentColor; // retour à la couleur originale
#endregion



//int table = 1;
//int multiplicateur = 0;

//do
//{
//    Console.WriteLine($"Table de {table} :");
//    Console.WriteLine("------------------------");

//    //TODO : faire les tables
//    multiplicateur = 0;
//    do
//    {

//        Console.WriteLine($"{table} x {multiplicateur} = {table * multiplicateur }");
//        multiplicateur++;
//    } while (multiplicateur < 11);

//    table++;
//    Console.WriteLine();
//} while (table < 10);

// Boucle externe : parcourt les tables (1, 2, 3, ..., 9):
for (int table = 1; table < 10; table++)
{
    // Affiche l'en-tête de la table courante:
    Console.WriteLine($"Table de {table} :");
    Console.WriteLine("--------------------------");

    // Boucle interne : parcourt les multiplicateurs (0, 1, 2, ..., 10):
    for (int multiplicateur = 0; multiplicateur < 11; multiplicateur++)
    {
        // Calcule et affiche le produit sous la forme : "3 x 4 = 12":
        Console.WriteLine($"{table} x {multiplicateur} = {table * multiplicateur}");
    }

    // Ligne vide pour séparer visuellement chaque table:
    Console.WriteLine();
}

// Spoil de la suite : au lieu de stocker les notes dans plusieurs variables séparées (note1, note2, note3...),
// on peut les regrouper dans un tableau (double[]). Cela permet de manipuler facilement plusieurs valeurs
// (ajouter des notes, calculer une moyenne, afficher toutes les notes, etc.). On parcourt ensuite le tableau
// avec une boucle for en utilisant notes.Length pour afficher chaque note (notes[i]):

//double note1 = 12.5;
//double note2 = 5;
//double note3 = 8;

//double[] notes = new double[4];
//notes[0] = 12.5;
//notes[1] = 5;
//notes[2] = 8;
//notes[3] = 2;

//for(int i = 0; i < notes.Length; i++)
//{
//    Console.WriteLine(notes[i]);
//}

#region En-tête en couleur

Console.ForegroundColor = ConsoleColor.DarkGreen; //change la couleur de l'écriture dans la console
Console.WriteLine("\n--------------------------------------");
Console.WriteLine("\t✏️ Prêt ! ");
Console.WriteLine("--------------------------------------");
Console.WriteLine();
Console.ForegroundColor = currentColor; // retour à la couleur originale
#endregion

Console.WriteLine("\n\n\nAppuyez sur n'importe quelle touche pour quitter");
Console.ReadKey();


