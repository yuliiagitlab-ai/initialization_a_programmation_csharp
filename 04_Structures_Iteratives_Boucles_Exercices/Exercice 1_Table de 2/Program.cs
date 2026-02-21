Console.OutputEncoding = System.Text.Encoding.UTF8;

//------------------------------------------------------------------------------------------
// Exercices Iteratives Boucles :
//------------------------------------------------------------------------------------------

#region Exercice 1 : Table de 2
// À l’aide d’une boucle, afficher la table de multiplication par 2.
// (2x0 jusqu'à 2x10)
#endregion

#region En-tête en couleur
// Console.ForegroundColor : récupère la couleur actuelle du texte dans la console.
// ConsoleColor currentColor : stocke cette couleur dans une variable.
// Le but est de sauvegarder la couleur actuelle avant de la modifier, afin de pouvoir la restaurer plus tard.

ConsoleColor currentColor = Console.ForegroundColor; // pour sauvegarder la couleur avant de la changer
// -------------------------------------------------
// Exercice 1 : Table de 2
// -------------------------------------------------
Console.ForegroundColor = ConsoleColor.DarkYellow; //change la couleur de l'écriture dans la console
Console.WriteLine("\n----------------------------------");
Console.WriteLine("\t✏️ La table de 2 ");
Console.WriteLine("----------------------------------");
Console.WriteLine();
Console.ForegroundColor = currentColor; // retour à la couleur originale
#endregion

// Déclare une constante pour la table de multiplication (valeur fixe):
const int TABLE = 2;

// Déclare le multiplicateur (compteur de la boucle):
int multiplicateur = 0;

// Variable qui contiendra le résultat du calcul:
int resultat;


// Boucle do...while :
// Le code est exécuté au moins une fois avant de vérifier la condition

do
{
    // Calcule le résultat de la multiplication:
    resultat = TABLE * multiplicateur;

    // Affiche le calcul sous la forme : 2 x 3 = 6:
    Console.WriteLine($"\t{TABLE} x {multiplicateur} = {resultat}");

    // Incrémente le multiplicateur (équivalent à multiplicateur = multiplicateur + 1):
    multiplicateur++;

} while (multiplicateur <= 10); // Continue tant que le multiplicateur est inférieur ou égal à 10


//-----------------------------------------------------------------------------------------------


// Spoiler des prochains jours : Pareil mais avec le POUR:
// const int TABLE = 2;
// int resultat;

// for (int multiplicateur = 0; multiplicateur <= 10; multiplicateur++)
// {
//    resultat = TABLE * multiplicateur;
//    Console.WriteLine($"{TABLE} x {multiplicateur} = {resultat}");
// }


//-----------------------------------------------------------------------------------------------

#region En-tête en couleur

Console.ForegroundColor = ConsoleColor.DarkYellow; //change la couleur de l'écriture dans la console
Console.WriteLine("\n----------------------------------");
Console.WriteLine("\t✏️ Prêt ! ");
Console.WriteLine("----------------------------------");
Console.WriteLine();
Console.ForegroundColor = currentColor; // retour à la couleur originale
#endregion