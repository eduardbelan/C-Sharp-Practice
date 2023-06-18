//Programmire ein Schere, Stein, Papier Spiel.
//Der User soll eines der Handzeichen auswählen können.
//Der Computer wählt per Zufall ein eigenes Zeichen.
//(Hierzu bitte selbsständig Random für C# Recherchieren)
//Dem User soll dann ausgegeben werden, welches Zeichen der Computer gewählt hat,
//und ob man Gewonnen, Verloren oder ein Unentschieden hat.
//Danach kann sich der User entscheiden eine weitere Runde zu spielen oder nicht.


// Meine Lösung
// define general variables
//string userChoice = string.Empty;
//string computerChoice = string.Empty;
//string computerChoiceIcon;
//bool validInput = false;
int randomChoice;
bool goAgain = false;
bool firstRun = true;


// ascii art
string genPath = "C:\\Users\\eduar\\Umschulung\\SE-Grundlagen\\02-Uebungen\\04-rock-paper-scissors";

string welcomePath = $"{genPath}\\welcome.txt";
string rockPath = $"{genPath}\\rock.txt";
string paperPath = $"{genPath}\\paper.txt";
string scissorsPath = $"{genPath}\\scissors.txt";
string helicopterPath = $"{genPath}\\helicopter.txt";

string welcome = File.ReadAllText(welcomePath);
string rock = File.ReadAllText(rockPath);
string paper = File.ReadAllText(paperPath);
string scissors = File.ReadAllText(scissorsPath);
string helicopter = File.ReadAllText(helicopterPath);



while (!goAgain)
{

    bool validInput = false;
    string userChoice = string.Empty;
    string computerChoice = string.Empty;
    string computerChoiceIcon;

    // random comp choice: create list with all choices
    List<string> choices = new List<string>
    {
        "rock",
        "paper",
        "scissors"
    };
    // generate a random number with the range of list choices
    Random random = new Random();
    randomChoice = random.Next(0, choices.Count);
    computerChoiceIcon = choices[randomChoice];
    // get random computer choice
    if (computerChoiceIcon == "rock")
    {
        computerChoiceIcon = rock;
        computerChoice = "rock";
    }
    else if (computerChoiceIcon == "paper")
    {
        computerChoiceIcon = paper;
        computerChoice = "paper";
    }
    else
    {
        computerChoiceIcon = scissors;
        computerChoice = "scissors";
    }


    // user input
    while (!validInput)
    {
        // greet
        Console.Clear();
        Console.WriteLine(welcome);

        // get user input
        Console.WriteLine("choose:\n" +
            "1. (r)ock,\n" +
            "2. (p)aper,\n" +
            $"3. (s)cissors\t\t\t\tcheat mode: {computerChoice}\n");
        //"3. (s)cissors\n");
        userChoice = Console.ReadLine();
        Console.Clear();

        // check user input
        switch (userChoice)
        {
            case "1":
            case "1.":
            case "r":
            case "(r)":
            case "rock":
            case "(r)ock":
            case "1. (r)ock":
            case "1. rock":
            case "1.(r)ock":
            case "1.rock":
                validInput = true;
                userChoice = "rock";
                Console.Clear();
                Console.WriteLine(welcome);
                Console.WriteLine("You Choose:\n" +
                    $"{rock}\n");
                break;

            case "2":
            case "2.":
            case "p":
            case "(p)":
            case "paper":
            case "(p)aper":
            case "1. (p)aper":
            case "1. paper":
            case "1.(p)aper":
            case "1.paper":
                validInput = true;
                userChoice = "paper";
                Console.Clear();
                Console.WriteLine(welcome);
                Console.WriteLine("You Choose:\n" +
                    $"{paper}\n");
                break;

            case "3":
            case "3.":
            case "s":
            case "(s)":
            case "scissors":
            case "(s)cissors":
            case "1. (s)cissors":
            case "1. scissors":
            case "1.(s)cissors":
            case "1.scissors":
                validInput = true;
                userChoice = "scissors";
                Console.Clear();
                Console.WriteLine(welcome);
                Console.WriteLine("You Choose:\n" +
                    $"{scissors}\n");
                break;

            default:
                break;
        }
    }


    // helicopter and jokes - only on first run
    if (firstRun)
    {
        //Console.WriteLine("Computer Choose:\n");
        Thread.Sleep(500); // 500
        Console.Write(". ");
        Thread.Sleep(500);
        Console.Write(". ");
        Thread.Sleep(500);
        Console.WriteLine(".");
        Thread.Sleep(500);
        Console.WriteLine("Calculating...");
        Thread.Sleep(2000); // 2
        Console.WriteLine("Estimating Parameters...");
        Thread.Sleep(2000);
        Console.WriteLine("Thinking about how to destroy Planet Earth...");
        Thread.Sleep(3000); // 3
        Console.WriteLine("...just kidding.");
        Thread.Sleep(2000); // 2
        Console.WriteLine("I already know your pick so this is easy...");
        Thread.Sleep(3000); // 3
        Console.WriteLine("While you wait, take a look at this Helicopter.");
        Thread.Sleep(2000); // 2
        Console.WriteLine(helicopter);
        Thread.Sleep(2000);
        Console.WriteLine("It can fly, look!");
        Thread.Sleep(1000);



        // helicopter
        // console sleep timer for rotor animation
        int timer = 1050;
        for (int i = 0; i < 10; i++)
        {
            // upper rotor
            Thread.Sleep(timer);
            Console.SetCursorPosition(0, 48);
            Console.Write("                                        !roflroflrofl");
            Console.SetCursorPosition(0, 49);
            Console.Write("          roflroflrofl!             /=====\\");

            Thread.Sleep(timer);
            Console.SetCursorPosition(0, 48);
            Console.Write("                            roflroflrofl!            ");
            Console.SetCursorPosition(0, 49);
            Console.Write("                      !roflroflrofl /=====\\");

            // reduce timer gradually for smooth animation
            if (timer < 100)
            {
                timer = 50;
            }
            else
            {
                timer -= 200;
            }
        }

        int animationHeight = 48;
        int sleepDuration = 126;
        int one = animationHeight;
        int two = animationHeight + 1;
        int three = animationHeight + 2;
        int four = animationHeight + 3;
        int five = animationHeight + 4;
        int six = animationHeight + 5;
        int clearingPoint = 28;

        // Animation loop
        while (one > 0)
        {
            // Clear the previous lines
            Console.SetCursorPosition(0, one);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, two);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, three);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, four);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, five);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, six);
            Console.Write(new string(' ', Console.WindowWidth));

            // Set cursor position for flight
            if (one > clearingPoint)
            {
                Console.SetCursorPosition(0, one - 1);
                Console.Write("                            roflroflrofl!roflroflrofl");
            }
            if (two > clearingPoint)
            {
                Console.SetCursorPosition(0, two - 1);
                Console.Write("          roflroflrofl!roflroflrofl /=====\\");
            }
            if (three > clearingPoint)
            {
                Console.SetCursorPosition(0, three - 1);
                Console.Write("                     |===\\_________/_  o  |");
            }
            if (four > clearingPoint)
            {
                Console.SetCursorPosition(0, four - 1);
                Console.Write("                    /_]    o o  o o____   /");
            }
            if (five > clearingPoint)
            {
                Console.SetCursorPosition(0, five - 1);
                Console.Write("                   <_]___[]_______<____>/");
            }
            if (six > clearingPoint)
            {
                Console.SetCursorPosition(0, six - 1);
                Console.Write("                       o              o");
            }

            // rotor animation
            if (one > clearingPoint)
            {
                for (int i = 0; i < 1; i++)
                {
                    Thread.Sleep(50);
                    Console.SetCursorPosition(0, one - 1);
                    Console.Write("                                        !roflroflrofl");
                    Console.SetCursorPosition(0, two - 1);
                    Console.Write("          roflroflrofl!             /=====\\");
                    Thread.Sleep(50);
                    Console.SetCursorPosition(0, one - 1);
                    Console.Write("                            roflroflrofl!            ");
                    Console.SetCursorPosition(0, two - 1);
                    Console.Write("                      !roflroflrofl /=====\\");
                }
            }

            if (six == clearingPoint)
            {
                break;
            }

            // Decrease dot and dash positions
            one--;
            two--;
            three--;
            four--;
            five--;
            six--;

            // Pause between steps
            Thread.Sleep(sleepDuration);

            // accelerate ascend
            if (sleepDuration > 26)
            {
                sleepDuration -= 25;
            }
            else
            {
                sleepDuration = 10;
            }
        }


        // continue with program
        Console.SetCursorPosition(0, 54);
        Console.Write(new string(' ', Console.WindowWidth));

        Console.SetCursorPosition(0, 24);
        Thread.Sleep(500);
        Console.Write("Computer Choose:\n");
        Thread.Sleep(500); // 500
        Console.Write(". ");
        Thread.Sleep(500);
        Console.Write(". ");
        Thread.Sleep(500);
        Console.WriteLine(".");
        Thread.Sleep(500);
        Console.WriteLine($"{computerChoiceIcon}");


        // end of first run
        firstRun = false;
    }
    // continue with program on consecutive runs
    else
    {
        Console.Write("Computer Choose:\n");
        Console.WriteLine($"{computerChoiceIcon}");
    }


    //// determine winner
    if (userChoice == computerChoice)
    {
        Console.WriteLine("tie.");
    }
    else if (userChoice == "rock" && computerChoice == "scissors" || userChoice == "paper" && computerChoice == "rock" || userChoice == "scissors" && computerChoice == "paper")
    {
        Console.WriteLine("you win.");
    }
    else
    {
        Console.WriteLine("you loose.");
    }


    // go again
    bool againCheck = false;
    while (!againCheck)
    {
        Console.WriteLine("play again? (y/n):");
        string loop = Console.ReadLine().ToLower();
        // check input
        switch (loop)
        {
            case "y":
            case "yes":
            case "ye":
            case "yea":
            case "yeah":
            case "ja":
            case "jap":
            case "jep":
            case "jo":
            case "ok":
            case "okay":
            case "okey":
            case "go":
            case "oki":
            case "jawohl, herr kommandant!":
                goAgain = false;
                againCheck = true;
                Console.Clear();
                Console.WriteLine(welcome);
                break;

            case "n":
            case "no":
            case "nope":
            case "nein":
            case "njet":
            case "nö":
                goAgain = true;
                againCheck = true;
                Console.Clear();
                Console.WriteLine(welcome);
                break;

            default:
                Console.Clear();
                Console.WriteLine(welcome);
                break;
        }
    }
}


//// Lösung Unterricht
//string userWahl;
//Random rnd = new Random();
//int computerWahl;
//bool continueGame;

//do
//{
//    continueGame = false;
//    Console.Clear();
//    Console.WriteLine("Hallo User!\nWähle PAPIER, STEIN oder SCHERE");
//    userWahl = Console.ReadLine().ToLower();
//    computerWahl = rnd.Next(1, 4);

//    if (userWahl == "papier" || userWahl == "stein" || userWahl == "schere")
//    {
//        if (computerWahl == 1)
//        {
//            Console.WriteLine("\nDer Computer hat PAPIER gewählt");
//            if (userWahl == "schere")
//            {
//                Console.WriteLine("Du hast gewonnen.");
//            }
//            else if (userWahl == "stein")
//            {
//                Console.WriteLine("Du hast verloren.");
//            }
//            else
//            {
//                Console.WriteLine("Das war ein Unentschieden.");
//            }
//        }
//        else if (computerWahl == 2)
//        {
//            Console.WriteLine("\nDer Computer hat STEIN gewählt.");
//            if (userWahl == "papier")
//            {
//                Console.WriteLine("Du hast gewonnen.");
//            }
//            else if (userWahl == "schere")
//            {
//                Console.WriteLine("Du hast verloren.");
//            }
//            else
//            {
//                Console.WriteLine("Das war ein Unentschieden.");
//            }
//        }
//        else if (computerWahl == 3)
//        {
//            Console.WriteLine("\nDer Computer hat SCHERE gewählt");
//            if (userWahl.Equals("stein")) //.Equals kann als ersatz für == verwendet werdenm, vergleicht nur auf einer tieferen Ebene.
//            {
//                Console.WriteLine("Du hast gewonnen.");
//            }
//            else if (userWahl.Equals("papier"))
//            {
//                Console.WriteLine("Du hast verloren.");
//            }
//            else
//            {
//                Console.WriteLine("Das war ein Unentschieden.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Entschuldige. Der Computer konnte sich wohl nicht entscheiden.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Unzulässige Eingabe.");
//    }

//    Console.WriteLine("\nMöchtest du eine weitere Runde spielen? J/N");
//    string eingabe = Console.ReadLine().ToLower();
//    if (eingabe.Equals("j"))
//    {
//        continueGame = true;
//    }
//    else
//    {
//        Console.WriteLine("\nVielen Dank fürs Spielen. Drücke Enter zum Beenden.");
//        Console.ReadLine();
//    }
//}
//while (continueGame);