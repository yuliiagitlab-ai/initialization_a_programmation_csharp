// Exercice 2 : Saisie d'un tableau de nombre décimaux
// Créer une procédure, qui, pour un tableau donné en paramètre, permet d'encoder pour chaque case un nombre décimal entre 0 et 20 (oh, ce qu'on a fait à l'exercice 1 :))
// Permettre à l'utilisateur d'entrer la taille souhaitée de son tableau (valeur valide entre 1 et 20) (oh, c'est l'exercice 1 Bis !), créer ce tableau et testez votre fonction

void SaisirTableauDecimaux(double[] tableau)
{
    for (int i = 0; i < tableau.Length; i++)
    {
        Console.WriteLine($"Case {i} :");
        tableau[i] = DemanderDecimal(0, 20); // réutilisation de l'exercice 1
    }
}

// ---------- Code “principal” ----------

Console.WriteLine("== Exercice 2 : Saisie d'un tableau de nombres décimaux ==");

// on demande la taille du tableau (entre 1 et 20)
int taille = DemanderEntier(1, 20);

// on crée le tableau
double[] tab = new double[taille];

// on appelle la procédure pour remplir le tableau
SaisirTableauDecimaux(tab);

// petit affichage pour vérifier
Console.WriteLine("Contenu du tableau :");
for (int i = 0; i < tab.Length; i++)
{
    Console.WriteLine($"tab[{i}] = {tab[i]}");
}