// ==================================================
// PROGRAMME PRINCIPAL (tests + programme final)
// ==================================================

// --------------------------------------------------
// ÉTAPE 0 : Tests rapides (pour vérifier les fonctions)
// --------------------------------------------------


// Test 1 : saisie d'un pourcentage entre 0 et 100
double pourcentage = SaisieDouble(0, 100);
Console.WriteLine($"Vous avez tapé {pourcentage} %");

Console.WriteLine();

// Test 2 : saisie d'une note entre 0 et 20
double noteTest = SaisieDouble(0, 20);
Console.WriteLine($"Vous avez eu {noteTest}/20");


// --------------------------------------------------
// ÉTAPE 1 : Début du programme final (création du tableau de notes)
// --------------------------------------------------


Console.WriteLine();
Console.WriteLine("Bienvenue, nous allons créer votre fichier de notes");

// On demande le nombre d'élèves (valeur contrôlée entre 1 et 30)
Console.WriteLine("Combien avez-vous d'élèves dans votre classe ?");
int nombreEleves = SaisieEntier(1, 30);


// On crée le tableau qui contiendra les notes de chaque élève
double[] notes = new double[nombreEleves];


// --------------------------------------------------
// ÉTAPE 2 : Remplissage du tableau (notes sur 20)
// --------------------------------------------------

Console.WriteLine();
Console.WriteLine("Veuillez remplir les notes de vos élèves (sur 20) :");
SaisieNotes(notes);


// --------------------------------------------------
// ÉTAPE 3 : Affichage du tableau (notes sur 20)
// --------------------------------------------------

Console.WriteLine();
Console.WriteLine("Récapitulatif des notes des élèves (sur 20) :");
AfficherTableau(notes);


// --------------------------------------------------
// ÉTAPE 4 : Calcul de la moyenne (sur 20)
// --------------------------------------------------

Console.WriteLine();
double moyenne = CalculMoyenne(notes);
Console.WriteLine($"La moyenne de la classe est {moyenne:0.00}/20");


// --------------------------------------------------
// ÉTAPE 5 : Recherche de la note maximale (sur 20)
// --------------------------------------------------

Console.WriteLine();
double noteMax = MaxTableau(notes);
Console.WriteLine($"La note maximale de la classe est {noteMax:0.00}/20");


// --------------------------------------------------
// ÉTAPE 6 : Nouveau barème (conversion sur 100)
// --------------------------------------------------

Console.WriteLine();
Console.WriteLine("Mince, on s'est trompé : les notes n'étaient pas sur 20 mais sur 100 !");

// Option 2 (recommandée) : on crée une COPIE du tableau convertie sur 100
double[] notesSur100 = ModifierBaremeBis(notes);

// Affichage des deux versions pour comparaison
Console.WriteLine();
Console.WriteLine("Notes sur 20 (original) :");
AfficherTableau(notes);

Console.WriteLine();
Console.WriteLine("Notes sur 100 (copie convertie) :");
AfficherTableau(notesSur100);

// --------------------------------------------------
// Fonctions & Procédures
// --------------------------------------------------
// C'est ici qu'on va déclarer/créer nos fonctions
// --------------------------------------------------

#region Exercice 1 : Saisie d'un nombre décimal entre Min et Max
// Créer une fonction qui permet à l'utilisateur de saisir un nombre décimal correct se situant entre Min et Max et renvoie la valeur (On est coincé dans une boucle tant qu'il entre des bêtises)
// Note : Attention, ça doit marcher avec 12.5 comme 12,5
#endregion

#region Explications fonction SaisieDouble
// Fonction qui s'appelle SaisieDouble, qui a besoin d'un nombre minimum min qui sera un double et d'un nombre maximum max qui sera un double. Cette fonction, renvoie à la fin du traitement, un nombre de type double
#endregion
double SaisieDouble(double min, double max)
{
    double nombre;
    bool reussiteConversion;
    // Demander à l'utilisateur d'entrer un nombre tant qu'il n'a pas rentré un nombre valide qui se trouve entre min et max
    do
    {
        Console.WriteLine($"Entrez un nombre décimal entre {min} et {max} :");

        string entreeUtilisateur = Console.ReadLine().Replace('.', ',');

        reussiteConversion = double.TryParse(entreeUtilisateur, out nombre);

    } while (!reussiteConversion || nombre < min || nombre > max);

    // Renvoyer ce nombre
    return nombre;
}

#region Exercice 1 Bis : Saisie d'un nombre entier entre Min et Max
// Faire pareil mais avec un nombre entier
#endregion

int SaisieEntier(int min, int max)
{
    int nombre;
    bool reussite;

    do
    {
        Console.WriteLine($"Entrez un nombre entier entre {min} et {max} :");
        reussite = int.TryParse(Console.ReadLine(), out nombre);

        if (!reussite || nombre < min || nombre > max)
        {
            Console.WriteLine("Saisie invalide. Veuillez réessayer.");
        }

    } while (!reussite || nombre < min || nombre > max);

    return nombre;
}

#region Exercice 2 : Saisie d'un tableau de nombre décimaux
// Créer une procédure, qui, pour un tableau donné en paramètre,
// permet d'encoder pour chaque case un nombre décimal entre 0 et 20
// (oh, ce qu'on a fait à l'exercice 1 :))
// Permettre à l'utilisateur d'entrer la taille souhaitée de son tableau
// (valeur valide entre 1 et 20)
// (oh, c'est l'exercice 1 Bis !),
// créer ce tableau et testez votre fonction
#endregion

void SaisieNotes(double[] notes)
{
    for (int i = 0; i < notes.Length; i++)
    {
        Console.WriteLine($"Note {i + 1}/{notes.Length} (entre 0 et 20) :");
        notes[i] = SaisieDouble(0, 20);
    }
}

#region Exercice 3 : Affichage d'un tableau de décimaux
// Créer une procédure qui permet d'afficher n'importe quel tableau de nombre décimaux
#endregion

// Affiche le contenu d'un tableau de double (une valeur par ligne)
void AfficherTableau(double[] tableau)
{
    // Sécurité : si le tableau est null, on évite une erreur
    if (tableau == null)
    {
        Console.WriteLine("Tableau inexistant (null).");
        return;
    }

    // Si le tableau est vide, on l'indique simplement
    if (tableau.Length == 0)
    {
        Console.WriteLine("Tableau vide.");
        return;
    }

    // Parcourt toutes les cases du tableau et affiche chaque valeur
    for (int i = 0; i < tableau.Length; i++)
    {
        Console.WriteLine($"[{i}] = {tableau[i]}");
    }
}

#region Exercice 4 : Moyenne d'un tableau de nombre décimaux
// Créer une fonction qui permet d'obtenir la moyenne de n'importe quel tableau de nombre décimaux reçu en paramètre.
// Testez votre fonction par exemple, sur le tableau créé avec l'exercice 2 🙂
#endregion

double CalculMoyenne(double[] tableau)
{
    // Sécurité : si le tableau est null ou vide, on ne peut pas calculer de moyenne.
    if (tableau == null || tableau.Length == 0)
    {
        return 0; // (ou throw / message, mais 0 est simple pour l'exercice)
    }

    // On additionne toutes les valeurs du tableau
    double somme = 0;

    for (int i = 0; i < tableau.Length; i++)
    {
        somme += tableau[i];
    }

    // Moyenne = somme / nombre d'éléments
    return somme / tableau.Length;
}

#region Exercice 5 : Maximum
// Créer une procédure qui permet d'afficher le nombre décimal le plus grand parmi un tableau reçu en paramètre
#endregion

double MaxTableau(double[] tableau)
{
    // Sécurité : si le tableau est null ou vide, on ne peut pas trouver de maximum
    if (tableau == null || tableau.Length == 0)
    {
        return 0; // valeur par défaut pour l'exercice
    }

    // On initialise le maximum avec la première valeur du tableau
    double max = tableau[0];

    // On parcourt le reste du tableau pour trouver la plus grande valeur
    for (int i = 1; i < tableau.Length; i++)
    {
        if (tableau[i] > max)
        {
            max = tableau[i];
        }
    }

    return max;
}

#region Exercice 6 : Nouveau barème
// Mince, on s'est trompé, notre tableau de notes n'était pas sur 20 mais sur 100. 🙁

// Créer au choix :
// une procédure qui permet de transformer toutes les notes d'un tableau passé en paramètre pour avoir la même mais sur 100
// une fonction qui permet d'avoir une copie de notre tableau mais avec les valeurs sur 100 au loeu de 20
#endregion


// Option 1 : Procédure qui transforme directement le tableau (sur 20 -> sur 100)


void ModifierBareme(double[] notes)
{
    // Sécurité : si le tableau est null, on ne fait rien
    if (notes == null)
        return;

    // Chaque note sur 20 est multipliée par 5 pour obtenir la note sur 100
    for (int i = 0; i < notes.Length; i++)
    {
        notes[i] = notes[i] * 5;
    }
}

// Option 2 : Fonction qui crée une copie du tableau (sur 20 -> sur 100) sans modifier l'original


double[] ModifierBaremeBis(double[] notes)
{
    // Sécurité : si le tableau est null, on renvoie un tableau vide
    if (notes == null)
        return Array.Empty<double>();

    // On crée un nouveau tableau de la même taille
    double[] notesSur100 = new double[notes.Length];

    // On copie chaque valeur en la convertissant sur 100
    for (int i = 0; i < notes.Length; i++)
    {
        notesSur100[i] = notes[i] * 5;
    }

    return notesSur100;
}
