// Exercice 1 : Saisie d'un nombre décimal entre Min et Max
// Créer une fonction qui permet à l'utilisateur de saisir un nombre décimal correcte ce situant entre Min et Max et renvoie la valeur (On est coincé dans une boucle tant qu'il entre des bêtises)
// Note : Attention, ça doit marcher avec 12.5 comme 12,5



    double DemanderDecimal(double min, double max)
    {
        bool reussite;
        double decimalDemander;
        do
        {
            Console.WriteLine($"Entrez un nombre decimal entre {min} et {max}");

            reussite = double.TryParse(Console.ReadLine(), out decimalDemander);

        } while (!reussite || decimalDemander < min || decimalDemander > max);
        return decimalDemander;
    }


double nombre = DemanderDecimal(0.5, 14.5);
Console.WriteLine($"Le nombre généré : {nombre}");



