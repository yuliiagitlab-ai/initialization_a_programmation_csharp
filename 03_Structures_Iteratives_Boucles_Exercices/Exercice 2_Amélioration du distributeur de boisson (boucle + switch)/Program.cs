Console.OutputEncoding = System.Text.Encoding.UTF8;

//------------------------------------------------------------------------------------------
// Exercices Iteratives Boucles :
//------------------------------------------------------------------------------------------

#region Exercice 2 : Amélioration du distributeur de boisson (boucle + switch)
// Améliorez l’algorithme du distributeur de boissons pour qu’il demande au client s’il désire une autre boisson
// (jusqu’à ce qu’il n’en ait plus envie)
#endregion

#region En-tête en couleur
// Console.ForegroundColor : récupère la couleur actuelle du texte dans la console.
// ConsoleColor currentColor : stocke cette couleur dans une variable.
// Le but est de sauvegarder la couleur actuelle avant de la modifier, afin de pouvoir la restaurer plus tard.

ConsoleColor currentColor = Console.ForegroundColor; // pour sauvegarder la couleur avant de la changer
// ----------------------------------------------------------------------------------------------------
// Exercice 2 : Amélioration du distributeur de boisson (boucle + switch)
// ----------------------------------------------------------------------------------------------------
Console.ForegroundColor = ConsoleColor.DarkGreen; //change la couleur de l'écriture dans la console
Console.WriteLine("\n-----------------------------------------");
Console.WriteLine("\tDistributeur de boisson ");
Console.WriteLine("-----------------------------------------");
Console.WriteLine();
Console.ForegroundColor = currentColor; // retour à la couleur originale
#endregion

// Stocks initiaux : nombre de boissons disponibles pour chaque produit:
int stockCocAlgo = 1;
int stockHTheML = 1;
int stockFantAlgebrik = 0;

// Variables pour stocker les saisies de l'utilisateur:
string choix;
string continuer;

do
{
    // Affiche le menu et demande à l'utilisateur de choisir une boisson via un code:
    Console.WriteLine("\nQuelle boisson désirez-vous ?");
    Console.WriteLine("\t010 : Coc'Algo");
    Console.WriteLine("\t021 : H'Thé'ML");
    Console.WriteLine("\t002 : Fant'Algébrik");
    Console.WriteLine("\tQ : Quitter"); // solution avec un choix pour quitter

    // Lecture du choix de l'utilisateur (ex : 010, 021, 002, Q...):
    choix = Console.ReadLine();


    // Exécute une action selon le code saisi:

    switch (choix)
    {
        case "010":
            // Si le stock est disponible, on distribue la boisson et on décrémente le stock:
            if (stockCocAlgo > 0)
            {
                Console.WriteLine("Voici votre Coc'Algo");
                stockCocAlgo--;   // équivalent à stockCocAlgo = stockCocAlgo - 1;
            }
            else  // Stock vide : on informe l'utilisateur:
            {
                Console.WriteLine("Nous n'avons plus de Coc'Algo :'(");
            }
            break;
        case "021":
            if (stockHTheML > 0)
            {
                Console.WriteLine("Voici votre H'Thé'ML");
                stockHTheML--;
            }
            else
            {
                Console.WriteLine("Nous n'avons plus de H'Thé'ML :'(");
            }
            break;
        case "002":
            if (stockFantAlgebrik > 0)
            {
                Console.WriteLine("Voici votre Fant'Algrébrik");
                stockFantAlgebrik--;
            }
            else
            {
                Console.WriteLine("Nous n'avons plus de Fant'Algrébik :'(");
            }
            break;

        // Permet de quitter si l'utilisateur saisit Q ou q:
        case "Q":
        case "q":
            Console.WriteLine("Merci, au revoir");
            break;

        // Si l'utilisateur saisit un code inconnu:
        default:
            Console.WriteLine("Choix invalide !");
            break;

    } // fin du switch

    // Si l'utilisateur choisit Q, on sort de la boucle do...while:
    if (choix.ToUpper() == "Q")
    {
        break; // sort de la boucle
    }

    // Demande à l'utilisateur s'il souhaite commander une autre boisson
    // N'importe quelle touche = continuer / N = arrêter

    Console.WriteLine("Voulez vous une autre boisson ? N'importe quelle touche pour oui, N pour non\n");
    continuer = Console.ReadLine();

    // La boucle continue tant que :
    // 1) l'utilisateur ne répond pas "N"
    // ET
    // 2) il reste au moins une boisson en stock (somme des stocks > 0)


} // fin du Do

// La boucle continue tant que l'utilisateur ne répond pas "N" et qu'il reste des boissons en stock:
while (continuer.ToUpper() != "N" && ((stockCocAlgo + stockHTheML + stockFantAlgebrik) > 0));

// Si tous les stocks sont à 0, on affiche un message de fin:
if (stockCocAlgo + stockHTheML + stockFantAlgebrik == 0)
{
    Console.WriteLine("Plus de boissons désolés");
}


#region En-tête en couleur

Console.ForegroundColor = ConsoleColor.DarkGreen; //change la couleur de l'écriture dans la console
Console.WriteLine("\n-----------------------------------------");
Console.WriteLine("\tBonne journée ! ");
Console.WriteLine("-----------------------------------------");
Console.WriteLine();
Console.ForegroundColor = currentColor; // retour à la couleur originale
#endregion