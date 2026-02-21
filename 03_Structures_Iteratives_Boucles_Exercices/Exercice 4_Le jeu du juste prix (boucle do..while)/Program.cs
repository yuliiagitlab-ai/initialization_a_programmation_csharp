Console.OutputEncoding = System.Text.Encoding.UTF8;

//------------------------------------------------------------------------------------------
// Exercices Iteratives Boucles :
//------------------------------------------------------------------------------------------

#region Exercice 4 : Le jeu du juste prix (boucle do..while)
// Générer un nombre aléatoire entre 1 et 10.
// Ensuite, tant qu'il n'a pas trouvé la bonne réponse, l'utilisateur va proposer un nombre.
// Si le nombre qu'il propose est plus petit que le nombre à deviner, vous indiquez "C'est plus".
// Si  le nombre est plus grand, vous indiquez "C'est moins". Si le nombre est égal, c'est gagné.

// Bonus : Vous pouvez rajouter un nombre de tentatives (ex 3 ou 5) pour trouver.
// La partie s'arrête alors s'il a gagné ou s'il a utilisé toutes ces tentatives.
#endregion

#region En-tête en couleur
// Console.ForegroundColor : récupère la couleur actuelle du texte dans la console.
// ConsoleColor currentColor : stocke cette couleur dans une variable.
// Le but est de sauvegarder la couleur actuelle avant de la modifier, afin de pouvoir la restaurer plus tard.

ConsoleColor currentColor = Console.ForegroundColor; // pour sauvegarder la couleur avant de la changer
// ----------------------------------------------------------------------------------------------------
// Exercice 4 : Le jeu du juste prix (boucle do..while)
// ----------------------------------------------------------------------------------------------------
Console.ForegroundColor = ConsoleColor.DarkCyan; //change la couleur de l'écriture dans la console
Console.WriteLine("-------------------------------");
Console.WriteLine("    Le juuuuste priiiiix");
Console.WriteLine("-------------------------------");
Console.WriteLine();
Console.ForegroundColor = currentColor; // retour à la couleur originale
#endregion

// Génère un nombre aléatoire à deviner entre 1 et 10
// (11 est exclu):
Random rand = new Random();
int nombreADeviner = rand.Next(1, 11);

// Variables pour stocker la proposition du joueur et l'état de la partie:
int nombrePropose;
bool gagne = false;

// Nombre maximum de tentatives autorisées:
const int TENTATIVES_MAX = 3;

// Compteur de tentatives déjà utilisées:
int tentatives = 0;

// Affiche le nombre de tentatives restantes au départ:
Console.WriteLine($"Il vous reste {TENTATIVES_MAX - tentatives}/{TENTATIVES_MAX} tentatives");

do
{
    // ---------------------------
    // Saisie contrôlée du joueur
    // ---------------------------

    // reussite indique si la conversion (TryParse) a fonctionné:
    bool reussite;

    // Demande un nombre tant que :
    // - la conversion échoue
    // OU
    // - le nombre n'est pas dans l'intervalle [1;10]:

    do
    {
        Console.WriteLine("Entrez un nombre entre 1 et 10:");
        reussite = int.TryParse(Console.ReadLine(), out nombrePropose);
    }
    while(!reussite || nombrePropose < 1 || nombrePropose > 10);

    // ---------------------------
    // Comparaison avec le nombre à deviner
    // ---------------------------

    if (nombrePropose > nombreADeviner)
    {
        // La proposition est trop grande → le nombre à deviner est plus petit:
        Console.WriteLine("Le nombre à deviner est plus petit");

        // On consomme une tentative:
        tentatives++;

        // Affiche le nombre de tentatives restantes:
        Console.WriteLine($"Il vous reste {TENTATIVES_MAX - tentatives}/{TENTATIVES_MAX} tentatives");
    } 
    else if (nombrePropose < nombreADeviner)
    {
        // La proposition est trop petite → le nombre à deviner est plus grand:
        Console.WriteLine("Le nombre à deviner est plus grand");
        tentatives++;
        Console.WriteLine($"Il vous reste {TENTATIVES_MAX - tentatives}/{TENTATIVES_MAX} tentatives");
    }
    else
    {
        // Si ce n'est ni plus grand ni plus petit, alors c'est égal → gagné:
        Console.WriteLine($"Bravo, c'est gagné. Le nombre à deviner était bien {nombreADeviner}. Vous avez trouvé en {tentatives} tentatives");

        // On passe la variable gagne à true pour arrêter la boucle:
        gagne = true;
    }
}

// La boucle continue tant que :
// - le joueur n'a pas gagné
// ET
// - il reste des tentatives disponibles:
while (!gagne && tentatives < TENTATIVES_MAX);

// Si le joueur n'a pas gagné (il a épuisé toutes ses tentatives),
// on affiche un message de défaite et le nombre à deviner:
if (!gagne)
{
    Console.WriteLine($"Perdu ! Le nombre à deviner était {nombreADeviner}.");
}

Console.WriteLine();

#region En-tête en couleur

Console.ForegroundColor = ConsoleColor.DarkCyan; //change la couleur de l'écriture dans la console
Console.WriteLine("-------------------------------");
Console.WriteLine("    Le juuuuste priiiiix");
Console.WriteLine("-------------------------------");
Console.WriteLine();
Console.ForegroundColor = currentColor; // retour à la couleur originale
#endregion
