Console.OutputEncoding = System.Text.Encoding.UTF8;

//------------------------------------------------------------------------------------------
// Exercices Opérateurs :
//------------------------------------------------------------------------------------------

#region // Exercice 2 : Convertisseur de secondes
/*Demandez à l'utilisateur combien il souhaite payer pour une frite (ex : 4.5)
Demandez lui ensuite combien dDemandez à l'utiliser un nombre total de secondes et affichez lui le nombre de jours, 
heures, minutes et secondes auquel elles correspondent.

Exemple :
L'utilisateur entre 4561 secondes et on affiche 0 jour 1 heure 16 minutes et 1 seconde.
Indice : Dans 126 secondes il y a 2 minutes et 6 secondes qu'on peut obtenir en divisant 120 / 60 puisque dans 1 minute 
il y a 60 secondes et vous pouvez obtenir le 6 restant avec un modulo.*/
#endregion

// Console.ForegroundColor : récupère la couleur actuelle du texte dans la console.
// ConsoleColor currentColor : stocke cette couleur dans une variable.
// Le but est de sauvegarder la couleur actuelle avant de la modifier, afin de pouvoir la restaurer plus tard.

ConsoleColor currentColor = Console.ForegroundColor; // pour sauvegarder la couleur avant de la changer
// -------------------------------------------------
// Exercice 2 : Convertisseur de secondes
// -------------------------------------------------
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine();
Console.WriteLine("-------------------------------------");
Console.WriteLine("\tLe temps presse !");
Console.WriteLine("-------------------------------------");
Console.ForegroundColor = currentColor; // retour à la couleur originale


// Demande à l'utilisateur d'entrer un nombre total de secondes (ex : 1000000000).
// Remarque : la valeur doit rester dans la limite d’un int (max : 2147483647).
Console.WriteLine("\nTapez un nombre total de secondes:");

// Lit la saisie de l'utilisateur (string) et la convertit en entier (int).
// Attention : si l'utilisateur ne tape pas un nombre entier valide, int.Parse provoquera une erreur.
int seconds = int.Parse(Console.ReadLine());

// ----- Calcul des jours -----
// 1 jour = 24 h = 24 * 3600 = 86400 secondes.
// La division entière (/) donne le nombre de jours complets contenus dans "seconds".
int days = seconds / 86400;

// On garde le reste des secondes après avoir retiré les jours complets.
// L'opérateur modulo (%) donne le "reste" de la division.
// Réaffectation de la variable seconds avec le reste après la division par 3600.
seconds = seconds % 86400;

// ----- Calcul des heures -----
// 1 heure = 3600 secondes.
// On calcule le nombre d'heures complètes restantes.
int hours = seconds / 3600;

// On enlève les heures complètes et on garde le reste en secondes.
// Réaffectation de la variable seconds.
seconds = seconds % 3600;

// ----- Calcul des minutes -----
// 1 minute = 60 secondes.
// On calcule le nombre de minutes complètes restantes.
int minutes = seconds / 60;

// Les secondes restantes après avoir retiré les minutes complètes.
// Ici, c'est le reste final : ce sont les secondes "isolées".
int secondsRest = seconds % 60;

// Affiche le résultat final au format : Jours / Heures / Minutes / Secondes.
// L'interpolation ($"...") permet d'insérer les valeurs des variables entre { }.
Console.WriteLine($"\nJours: {days}; Heures: {hours}; Minutes: {minutes}; Seconds: {secondsRest}");

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine();
Console.WriteLine("-------------------------------------");
Console.WriteLine("\tCarpe diem !");
Console.WriteLine("-------------------------------------");
Console.ForegroundColor = currentColor; // retour à la couleur originale.


//------------------------------------------------------------------------------------------
// Types entiers :
// Valeurs maximales des types entiers en C# :

// byte  (3 chiffres)  : max = 255
// short (5 chiffres)  : max = 32 767
// int   (10 chiffres) : max = 2 147 483 647
// long  (19 chiffres) : max = 9 223 372 036 854 775 807
//------------------------------------------------------------------------------------------
