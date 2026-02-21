Console.OutputEncoding = System.Text.Encoding.UTF8;

//------------------------------------------------------------------------------------------
// Exercices Iteratives Boucles :
//------------------------------------------------------------------------------------------

#region Exercice 3 : Exposant (boucle do..while)
// À l’aide de la boucle de votre choix, réaliser un algorithme calculant le résultat de N^X.
// N et X étant des nombres saisis par l’utilisateur
// (Vous ne devez pas utiliser la méthode pour faire un exposant mais faire le calcul vous même avec une boucle)
// Exemple:
// 2 ^ 3 -> 8
// 3 ^ 5 -> 243
#endregion

#region En-tête en couleur
// Console.ForegroundColor : récupère la couleur actuelle du texte dans la console.
// ConsoleColor currentColor : stocke cette couleur dans une variable.
// Le but est de sauvegarder la couleur actuelle avant de la modifier, afin de pouvoir la restaurer plus tard.

ConsoleColor currentColor = Console.ForegroundColor; // pour sauvegarder la couleur avant de la changer
// ----------------------------------------------------------------------------------------------------
// Exercice 3 : Exposant (boucle do..while)
// ----------------------------------------------------------------------------------------------------
Console.ForegroundColor = ConsoleColor.DarkCyan; //change la couleur de l'écriture dans la console
Console.WriteLine("\n--------------------------------------");
Console.WriteLine("\t✏️ Exposant ");
Console.WriteLine("--------------------------------------");
Console.WriteLine();
Console.ForegroundColor = currentColor; // retour à la couleur originale
#endregion

// Variable qui contiendra le nombre saisi par l'utilisateur:
int nombre;

// Booléen indiquant si la conversion de la saisie en entier a réussi (true = succès, false = échec):
// Indique si la saisie est valide (résultat de TryParse):
bool reussite;


do
{
    Console.WriteLine("Entrez un nombre (>= 1) :");

    // TryParse tente de convertir la saisie en entier.
    // - Retourne true si la conversion réussit, sinon false.
    // - Le mot-clé "out" permet de stocker la valeur convertie dans la variable "nombre".
    reussite = int.TryParse(Console.ReadLine(), out nombre);

} // fin du do (nombre)

// La boucle se répète tant que :
// - la conversion de la saisie a échoué (!reussite)
// OU
// - le nombre saisi est inférieur à 1 (nombre < 1)
while (!reussite || nombre < 1) ; /*while (reussite == false)*/

Console.WriteLine();

// Variable qui contiendra l'exposant saisi par l'utilisateur:
int exposant;

do
{
    // Demande à l'utilisateur de saisir un exposant (un entier >= 0):
    Console.WriteLine("Entrez un exposant :");

    // TryParse tente de convertir la saisie en entier :
    // - retourne true si la conversion réussit, sinon false
    // - stocke la valeur convertie dans "exposant" grâce au mot-clé "out":
    reussite = int.TryParse(Console.ReadLine(), out exposant);

} // fin du do (exposant)

// La boucle se répète tant que :
// - la conversion a échoué (!reussite)
// OU
// - l'exposant est négatif (exposant < 0)
while (!reussite || exposant < 0);

Console.WriteLine();

// Initialisation du calcul de la puissance : résultat commence à 1 (élément neutre de la multiplication):
int resultat = 1;

// Compteur qui servira à répéter la multiplication "exposant" fois:
int compteur = 1;

do
{
    resultat = resultat * nombre;
    compteur++;
}

// On multiplie "resultat" par "nombre" exactement "exposant" fois:
while (compteur <= exposant);

// Affiche le résultat final du calcul sous la forme :
// "<nombre> exposant <exposant> vaut <résultat>":
Console.WriteLine($"{nombre} exposant {exposant} vaut {resultat}");

//------------------------------------------------------------------------------------------

// ex : nombre = 2 et exposant = 4
// resultat = resultat * nombre -> 2
// resultat = resultat * nombre -> 4
// resultat = resultat * nombre -> 8
// resultat = resultat * nombre -> 16

// Le calcul de la puissance se fait par multiplications successives :
// (ex: 2 ^ 4 = 2 × 2 × 2 × 2)
// on part de 1, puis on multiplie le résultat par "nombre" autant de fois que vaut l'exposant.
// Exemple : nombre = 2 et exposant = 4
// Étapes :
// 1 → 1 * 2 = 2
// 2 → 2 * 2 = 4
// 3 → 4 * 2 = 8
// 4 → 8 * 2 = 16
// Ce qui correspond à : 2 × 2 × 2 × 2 = 16

//------------------------------------------------------------------------------------------

#region En-tête en couleur

Console.ForegroundColor = ConsoleColor.DarkCyan; //change la couleur de l'écriture dans la console
Console.WriteLine("\n--------------------------------------");
Console.WriteLine("\t✏️ Prêt ! ");
Console.WriteLine("--------------------------------------");
Console.WriteLine();
Console.ForegroundColor = currentColor; // retour à la couleur originale
#endregion