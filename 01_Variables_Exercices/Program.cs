Console.WriteLine("=========================\n");
Console.WriteLine("Exercice échange variable\n");
Console.WriteLine("=========================\n");

// Trouvez une méthode permettant d’inverser le contenu de deux variables (du même type évidemment). Si A = 5 et B = 7, après ce traitement, A = 7 et B = 5.

// Étape 1 : Demander à l'utilisateur 2 nombres et les afficher avant l'échange
//--------------------------------------------------------------

// Déclare une variable a de type entier (int) sans valeur.
// int a;

// Affecte la valeur 5 à la variable a.
// a = 5;

// Affiche la valeur de a dans la console.
// Console.WriteLine(a);

// Déclare et affecte la variable en une seule ligne.
// int a = 5;

// Lire + convertir + declare + affecter
// int a = int.Parse(Console.ReadLine());

//--------------------------------------------------------------


// déclaration des variables dont on a besoin
int nombre1;
int nombre2;

// demande à l'utilisateur pour remplir ces variables:
// lecture de la saisie utilisateur et affectation à nombre1 et nombre2:
Console.WriteLine("Entrez un premier nombre:");
nombre1 = int.Parse(Console.ReadLine());
Console.WriteLine("Entrez un deuxième nombre:");
nombre2 = int.Parse(Console.ReadLine());

// Note : On aurait pu tout faire en une seule ligne
//Console.WriteLine("Entrez un premier nombre");
//int nombre1 = int.Parse(Console.ReadLine());

//--------------------------------------------------------------
// { } accolades – braces
// < > chevrons – angle brackets
// [ ] crochets – square brackets
// ( ) parenthèses – parentheses
// " " guillemets – double quotes
// ' ' guillemets simples – single quotes
//--------------------------------------------------------------


// Affichage des deux nombres

Console.WriteLine("\nSolution 1: avec une variable temporaire:");
Console.WriteLine("Les valeurs avant le traitement et après le traitement:");
Console.WriteLine($"\nA vaut {nombre1} et B vaut {nombre2}"); //interpolation
//Console.WriteLine("\nA vaut " + nombre1 + " et B vaut " + nombre2 ); //concaténation

// Étape 2 : Les échanger
//--------------------------------------------------------------
// Si on essaie d'échanger comme ceci, on écrase la valeur initiale de nombre1 et on l'a perdue pour toujours
// si nombre1 = 7 et nombre2 = 5
// nombre1 = nombre2; // nombre1 = 5, nombre2 = 5
// nombre2 = nombre1; // nombre2 = 5, nombre1 = 5

// Solution 1 : Créer une variable temporaire pour stocker le nombre1
int temporaire;
temporaire = nombre1; //temporaire = 7  nombre1 = 7  nombre2 = 5
nombre1 = nombre2; //temporaire = 7   nombre1 = 5   nombre2 = 5
nombre2 = temporaire; //temporaire = 7  nombre1 = 5  nombre2 = 7

// Étape 3 : Afficher le résultat
//--------------------------------------------------------------
Console.WriteLine($"\nA vaut {nombre1} et B vaut {nombre2}");


// Solution 2 : Avec des opérateurs mathématiques (ne fonctionne que si nos variables à échanger sont des nombres)
Console.WriteLine("\n--------------------------------------------------------------\n");
Console.WriteLine("\nDeuxième version de l'exercice :\n");

Console.WriteLine("Entrez un nombre:");
int nombreA = int.Parse(Console.ReadLine());
Console.WriteLine("Encore:");
int nombreB = int.Parse(Console.ReadLine());

Console.WriteLine("\nSolution 2: avec des opérateurs mathématiques");
Console.WriteLine("Les valeurs avant le traitement et après le traitement:");
Console.WriteLine($"\nA vaut {nombreA} et B vaut {nombreB}"); //interpolation

// Example:
// A = 2
// B = 4
nombreA = nombreA + nombreB; // A = 2 + 4     -->> A = 6
nombreB = nombreA - nombreB; // B = 6 - 4 = 2      A = 6
nombreA = nombreA - nombreB; // A = 6 - 2 = 4 -->> A = 4, B = 2

Console.WriteLine($"\nA vaut {nombreA} et B vaut {nombreB}"); //interpolation