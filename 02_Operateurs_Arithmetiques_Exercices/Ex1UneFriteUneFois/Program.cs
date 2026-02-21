Console.OutputEncoding = System.Text.Encoding.UTF8;

//------------------------------------------------------------------------------------------
// Exercices Opérateurs :
//------------------------------------------------------------------------------------------

#region // Exercice 1 : Une frite une fois
/*Demandez à l'utilisateur combien il souhaite payer pour une frite (ex : 4.5)
Demandez lui ensuite combien de frites il désire (ex : 2)

Affichez lui ensuite combien il doit payer MAIS vous devrez rajouter à ce prix 25% de TVA.*/
#endregion

// Console.ForegroundColor : récupère la couleur actuelle du texte dans la console.
// ConsoleColor currentColor : stocke cette couleur dans une variable.
// Le but est de sauvegarder la couleur actuelle avant de la modifier, afin de pouvoir la restaurer plus tard.

ConsoleColor currentColor = Console.ForegroundColor; // pour sauvegarder la couleur avant de la changer
// -------------------------------------------------
// Exercice 1 : Une frite une fois
// -------------------------------------------------
Console.ForegroundColor = ConsoleColor.Magenta; //change la couleur de l'écriture dans la console
Console.WriteLine("-------------------------------------");
Console.WriteLine("\tUne frite une fois !");
Console.WriteLine("-------------------------------------");
Console.WriteLine();
Console.ForegroundColor = currentColor; // retour à la couleur originale

// Demande l'utilisateur le prix désiré:
Console.WriteLine("Combien vous souhaitez payer pour une frite?");

//     prixString = Console.ReadLine();
//     double prix = double.Parse(prixString);
//-->> double prix = double.Parse(Console.ReadLine());

// String.Replace(termeRecherché, parQuoiRemplacer) :
// remplace dans la chaîne de caractères toutes les occurrences de "termeRecherché"
// par "parQuoiRemplacer" et retourne une nouvelle chaîne (la chaîne originale ne change pas).
// Ici, on remplace le point '.' par la virgule ',' pour gérer le séparateur décimal.

// Transforme les données de l’utilisateur en décimal :
double prixDeFrites = double.Parse(Console.ReadLine().Replace('.', ','));


// Transforme les données de l’utilisateur en décimal :
//double prixDeFrite = double.Parse(Console.ReadLine());

// Demande lui ensuite combien de frites il désire:
Console.WriteLine("Combien de frites vous désirez?");

// Transforme les données de l’utilisateur en intrier :
int combienDeFrite = int.Parse(Console.ReadLine());

// Affiche un message de confirmation.
Console.WriteLine($"\n🧑🏻‍🍳 C'est parti Сhef, faites-moi {combienDeFrite} frites à {prixDeFrites} € !\n");

// Calcule le prix d'une frite TVA incluse.
// On multiplie par 1,25 car ajouter 25% revient à faire : 100% + 25% = 125% = 1,25.
double prixAvecTva = prixDeFrites * 1.25;

// Affiche le prix unitaire (pour 1 frite) avec TVA incluse.
Console.WriteLine($"Le prix TVA inclut: {prixAvecTva} €");

// Calcule le montant total à payer : prix unitaire (TVA incluse) × quantité commandée.
double amountTotal = prixAvecTva * combienDeFrite;

// Affiche le montant total à payer.
// {amountTotal:0.00} force l'affichage avec exactement 2 chiffres après la virgule (ex : 7,50).
Console.WriteLine($"\n💸 Ça vous fera " + $"{amountTotal:0.00} € s'il vous plait !");

Console.ForegroundColor = ConsoleColor.Magenta; //change la couleur de l'écriture dans la console
Console.WriteLine("\n-------------------------------------");
Console.WriteLine("\tBon Appetit !");
Console.WriteLine("-------------------------------------");
Console.WriteLine();
Console.ForegroundColor = currentColor; // retour à la couleur originale



//------------------------------------------------------------------------------------------
// Différence entre int et double (important !)

// int a = 5 / 2;        // résultat = 2
// double b = 5 / 2;    // résultat = 2
// double c = 5.0 / 2; // résultat = 2.5
//------------------------------------------------------------------------------------------
