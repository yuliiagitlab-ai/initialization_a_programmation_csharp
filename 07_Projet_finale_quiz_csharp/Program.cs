using QuizBelgique;

// Ctrl + K + D -> Reformat file
#region // Summary
/// <summary>
/// Point d'entrée de l'application console.
/// Ce fichier s'occupe uniquement :
/// - d'afficher l'en-tête du quiz
/// - de gérer le joueur courant
/// - de lancer le quiz
/// - d'afficher le résultat et la réaction
/// - de sauvegarder et afficher la "base de données" des joueurs
/// Toute la logique des questions se trouve dans les classes Quiz et Question.
/// </summary>
#endregion

// 1) On affiche l'en-tête du quiz
#region L'en-tête du quiz
// Permet d'afficher correctement les caractères spéciaux (█, emoji, accents, etc.)
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
#region // Drapeau de la Belgique

// Nous sauvegardons la couleur actuelle du texte afin de pouvoir la restaurer plus tard.
// En effet, après avoir changé les couleurs pour dessiner le drapeau, la console
// continuerait d'utiliser ces nouvelles couleurs. En gardant l'ancienne valeur,
// nous pouvons revenir à la couleur d'origine une fois le dessin terminé.

var oldFg = Console.ForegroundColor;

// Longueur de chaque partie
int width = 40;

// Partie NOIRE (Gris foncé, car le noir se fond avec le fond noir)
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(new string('█', width));

// Partie JAUNE
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(new string('█', width));

// Partie ROUGE
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(new string('█', width));

// Renvoyer les couleurs telles qu'elles étaient
Console.ForegroundColor = oldFg;
#endregion
Console.WriteLine("\n========================================================================================================================");
Console.WriteLine("( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("========================================================================================================================");
Console.WriteLine("                                           QUIZ : L'HISTOIRE DE LA BELGIQUE                                             ");
Console.WriteLine("========================================================================================================================");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~( • )~");
Console.WriteLine("========================================================================================================================");
#region // Drapeau de la Belgique
var oldFg2 = Console.ForegroundColor;
int width2 = 40;
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(new string('█', width2));
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(new string('█', width2));
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(new string('█', width2));
Console.ForegroundColor = oldFg2;
#endregion
Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------\n");
#endregion

// 2) On demande le nom du joueur et on crée l'objet Player correspondant.

// DemanderNomJoueur()    : méthode qui demande et vérifie le nom (voir plus bas).
// new Player(playerName) : appel du constructeur pour créer un nouveau joueur - on crée l'objet Player
string playerName = DemanderNomJoueur();
Player player = new Player(playerName);


// 3) On crée la liste des questions (données du quiz)
#region La liste des questions

// List < ...>          : collection de listes en C#, de l'espace de noms System.Collections.Generic.
// List < Question >    : liste d'objets de type Question ».
// new List<Question>() : appel du constructeur de liste sans paramètres (liste vide).

List<Question> questions = new List<Question>
            {
                new Question(
                    // text : variable de Question.cs : string text
                    "\nQuestion # 1\nEn quelle année la Belgique devient-elle indépendante ?\n",
                    new string[]  // options : variable de Question.cs : string[] options
                    {
                        "1789",   // index 0
                        "1830",   // index 1  ← bonne réponse
                        "1914",   // index 2
                        "1945\n"  // index 3
                    },
                    1 // correctIndex : variable de Question.cs : int correctIndex
                ),
                new Question(
                    "\nQuestion # 2\nQui est le premier roi des Belges ?\n",
                    new string[]
                    {
                        "Léopold Ier",
                        "Léopold II",
                        "Albert Ier",
                        "Baudouin\n"
                    },
                    0
                ),
                new Question(
                    "\nQuestion # 3\nQuelle est la capitale de la Belgique ?\n",
                    new string[]
                    {
                        "Anvers",
                        "Liège",
                        "Bruges",
                        "Bruxelles\n"
                    },
                    3
                ),
                new Question(
                    "\nQuestion # 4\nQuelles sont les trois langues officielles de la Belgique ?\n",
                    new string[]
                    {
                        "français, néerlandais, anglais",
                        "néerlandais, français, allemand",
                        "français, allemand, anglais",
                        "flamand, français, allemand\n"
                    },
                    1
                ),
                new Question(
                    "\nQuestion # 5\nQuel pays africain fut une colonie belge ?\n",
                    new string[]
                    {
                        "Algérie",
                        "Congo",
                        "Maroc",
                        "Angola\n"
                    },
                    1
                ),
                new Question(
                    "\nQuestion # 6\nCombien de régions principales compte la Belgique ?\n",
                    new string[]
                    {
                        "2",
                        "3",
                        "4",
                        "5\n"
                    },
                    1
                ),
                new Question(
                    "\nQuestion # 7\nOù a eu lieu la célèbre bataille qui marque la défaite de Napoléon en 1815 ?\n",
                    new string[]
                    {
                        "Liège",
                        "Anvers",
                        "Waterloo",
                        "Namur\n"
                    },
                    2
                ),
                new Question(
                    "\nQuestion # 8\nQuelle ville fut capitale provisoire de la Belgique lors de la Première Guerre mondiale ?\n",
                    new string[]
                    {
                        "Bruges",
                        "Anvers",
                        "Le Havre",
                        "Liège\n"
                    },
                    2
                ),
                new Question(
                    "\nQuestion # 9\nEn quelle année la Belgique a-t-elle adopté officiellement l’euro ?\n",
                    new string[]
                    {
                        "1995",
                        "1999",
                        "2001",
                        "2002\n"
                    },
                    3
                ),
                new Question(
                    "\nQuestion # 10\nQuelle guerre a conduit à la Révolution belge de 1830 ?\n",
                    new string[]
                    {
                        "La guerre napoléonienne",
                        "La guerre austro-prussienne",
                        "La révolution de juillet en France",
                        "La guerre de succession d'Espagne\n"
                    },
                    2
                ),
            };
#endregion


// 4) On crée un objet Quiz avec la liste de questions, puis on lance le quiz pour ce joueur.

// Quiz est votre classe(dans le fichier Quiz.cs).
// quiz est une variable qui stockera un objet de type Quiz.
// new Quiz(questions) est un appel au constructeur de la classe Quiz.
// Run est une méthode de la classe Quiz (Quiz.cs)

Quiz quiz = new Quiz(questions);  // l'objet Quiz connaît toutes les questions
quiz.Run(player);                 // le quiz pose les questions et met à jour le score du joueur


// 5) On calcule le pourcentage de bonnes réponses
double percent = (double)player.Score / questions.Count * 100;

#region // ASCII image + court message, selon le résultat
string face;
string shortMessage;
ConsoleColor msgColor;

if (percent == 100)
{
    face = @"
                                                  __________
                                                 / ___  ___ \
                                                / / @ \/ @ \ \
                                                \ \___/\___/ /\
                                                 \____\/____/||
                                                /     /\\\\\//
                                               |     |\\\\\\
                                                \      \\\\\\
                                                  \______/\\\\
                                                   _||_||_
";
    shortMessage = "                                              Vous avez gagné !";
    msgColor = ConsoleColor.Green;
}
else if (percent >= 60)
{
    face = @"
                                                    __,__
                                           .--.  .-""     ""-.  .--.
                                          / .. \/  .-. .-.  \/ .. \
                                         | |  '|  /   Y   \  |'  | |
                                         | \   \  \ 0 | 0 /  /   / |
                                          \ '- ,\.-""`` ``""-./, -' /
                                           `'-' /_   ^ ^   _\ '-'`
                                               |  \._   _./  |
                                               \   \ `~` /   /
                                        jgs     '._ '-=-' _.'
                                                   '~---~'
";
    shortMessage = "                                                   Bonne !";
    msgColor = ConsoleColor.Yellow;
}
else
{
    face = @"
                                                   \|||/
                                                   (o o)
                                        --------ooO-(_)-Ooo---------
";
    shortMessage = "                                                  Ooops...";
    msgColor = ConsoleColor.Red;
}
#endregion

// 6) On affiche une petite "réaction" (ASCII image et un court message) selon le résultat (Ooops / Bonne / Vous avez gagné)
Console.WriteLine();
Console.WriteLine(face);
Console.ForegroundColor = msgColor;
Console.WriteLine(shortMessage);
Console.ResetColor();
Console.WriteLine(); // ligne vide avant le bloc RÉSULTAT

// 7) On affiche le résultat du joueur
#region Bloc de résultats des joueurs
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n--<o>   <o>--<o>--<o>   <o>--<o>--<o>--<o>--<o>   RÉSULTAT   <o>--<o>--<o>--<o>--<o>   <o>--<o>--<o>   <o>--");
Console.ResetColor();
Console.WriteLine("\nJoueur : " + player.Name);
Console.WriteLine("Score : " + player.Score + " / " + questions.Count);
Console.WriteLine("Pourcentage : " + percent.ToString("F1") + " %");


if (percent == 100)
{
    Console.WriteLine($"\nExcellent, {playerName} ! Vous connaissez très bien l'histoire de la Belgique ! 🎉");
}
else if (percent >= 60)
{
    Console.WriteLine($"\nBon résultat, {playerName} ! Encore un peu de révision et ce sera parfait 🙂");
}
else
{
    Console.WriteLine($"\nCe n'est pas grave, {playerName}, il suffit de revoir un peu l'histoire. Courage ! 💪");
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n<o>--<o>--<o>--<o>--<o>--<o>--<o>--<o>--<o>--<o>--<o>--<o>--<o>--<o>--<o>--<o>--<o>--<o>--<o>--<o>--<o>--<o>\n");
Console.ResetColor();
#endregion

//// 8) On enregistre le joueur dans la "base de données" (fichier texte)
//PlayerDatabase db = new PlayerDatabase("players.txt");
//db.SavePlayer(player);

//// On laisse le temps au joueur de lire son résultat avant d'afficher l'historique
//Console.WriteLine("\nAppuyez sur une touche pour voir les autres joueurs...");
//Console.ReadKey();

//// On efface l'écran puis on affiche la liste complète des joueurs enregistrés
//Console.Clear();
//db.ShowAllPlayers();

//Console.WriteLine("\nAppuyez sur une touche pour quitter...");
//Console.ReadKey();

// 8) On enregistre le joueur dans une base de données SQL.

string connectionString = @"Data Source=YULIIA;Initial Catalog=QuizBelgique;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

PlayerDatabase db = new PlayerDatabase(connectionString);
db.SavePlayer(player);

Console.WriteLine("\nAppuyez sur une touche pour voir les autres joueurs...");
Console.ReadKey();

Console.Clear();
db.ShowAllPlayers();

#region
ConsoleColor currentColor = Console.ForegroundColor; 
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("(c) Yuliia Korotenko. Initiation à la programmation. BF digital");
Console.WriteLine();
Console.ForegroundColor = currentColor;
#endregion




// On creer une methode pour demande et verifier un nom qu'on utilise dans le Main pour creer un objet Player.
#region DemanderNomJoueur
static string DemanderNomJoueur()
{
    // On demande le nom du joueur et on vérifie qu'il n'est pas vide puis après on crée la variable playerName
    // Si l'utilisateur n'entre rien, on utilise "Inconnu" comme nom par défaut.
    Console.Write("Entrez votre nom : ");
    string playerName = Console.ReadLine();

    // Apres avec boocle if on verifier le nom
    if (string.IsNullOrWhiteSpace(playerName)) // if (playerName == "" || playerName == null)
    {
        playerName = "Inconnu";
    }

    // Message de bienvenue avec le nom (ou "Inconnu" si rien n'a été saisi) en coleur jaune
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"\n<o>--<o>--<o>   <o>--<o>--<o>--<o>--<o>     Bonjour, {playerName} ! C'est parti !     <o>--<o>--<o>--<o>--<o>   <o>--<o>--<o>");

    //// Renvoie la couleur de texte par défaut
    Console.ResetColor();

    return playerName;
}
#endregion


