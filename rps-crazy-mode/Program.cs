// Crazy Mode

// define general variables
string computerChoice;
string computerChoiceIcon;
string userChoice;
string userChoiceIcon;
int randomChoiceComputer;
int randomChoiceUser;
// points counter
int pointsComputer = 0;
int pointsUser = 0;
int pointsTie = 0;
// set game length
int rounds;


// art
string genPath = "C:\\Users\\eduar\\Umschulung\\SE-Grundlagen\\Uebungen\\rps-crazy-mode";

string welcomePath = $"{genPath}\\welcome.txt";
string rockPath = $"{genPath}\\rock.txt";
string paperPath = $"{genPath}\\paper.txt";
string scissorsPath = $"{genPath}\\scissors.txt";

string welcome = File.ReadAllText(welcomePath);
string rock = File.ReadAllText(rockPath);
string paper = File.ReadAllText(paperPath);
string scissors = File.ReadAllText(scissorsPath);


// random comp choice: create list with all choices
List<string> choicesComputer = new List<string>
    {
        "rock",
        "paper",
        "scissors"
    };
// generate a random number with the range of list choices
Random randomComputer = new Random();
randomChoiceComputer = randomComputer.Next(0, choicesComputer.Count);
computerChoiceIcon = choicesComputer[randomChoiceComputer];
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


Console.WriteLine("Enter Rounds, 1 - 10:");
rounds = Convert.ToInt16(Console.ReadLine());


// print welcome and computer choice
Console.WriteLine(welcome);
Console.WriteLine();
Console.WriteLine($"User: {pointsUser}, Computer: {pointsComputer}, Ties: {pointsTie}");
Console.WriteLine();
Console.WriteLine("The Machine Chooses:\n" +
    $"{computerChoiceIcon}\n" +
    $"{computerChoice}\n");


for (int i = 0; i < rounds;  i++)
{
    while (true)
    {
        // random user choice: create list with all choices
        List<string> choicesUser = new List<string>
        {
            "rock",
            "paper",
            "scissors"
        };
        // generate a random number with the range of list choices
        Random randomUser = new Random();
        randomChoiceUser = randomUser.Next(0, choicesUser.Count);
        userChoiceIcon = choicesComputer[randomChoiceUser];
        // get random computer choice
        if (userChoiceIcon == "rock")
        {
            userChoiceIcon = rock;
            userChoice = "rock";
        }
        else if (userChoiceIcon == "paper")
        {
            userChoiceIcon = paper;
            userChoice = "paper";
        }
        else
        {
            userChoiceIcon = scissors;
            userChoice = "scissors";
        }
    
    
        // print user choice shuffle
        Console.WriteLine("The User Chooses:\n" +
        $"{userChoiceIcon}\n" +
        $"{userChoice}\n");
    
    
        // sleep timer and clear for shuffle effect
        Thread.Sleep(350);
        Console.Clear();
    
    
        // print the rest for static effect (variables for computer choice don't change)
        Console.WriteLine(welcome);
        Console.WriteLine();
        Console.WriteLine($"User: {pointsUser}, Computer: {pointsComputer}, Ties: {pointsTie}");
        Console.WriteLine();
        Console.WriteLine("The Machine Chooses:\n" +
            $"{computerChoiceIcon}\n" +
            $"{computerChoice}\n");
    
    
        // wait for enter key to be pressed
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            if (keyInfo.Key == ConsoleKey.Spacebar)
                break;
        }
    
    }
    
    
    // evaluate
    //// determine winner
    if (userChoice == computerChoice)
    {
        Console.WriteLine("tie.");
        pointsTie += 1;
    }
    else if (userChoice == "rock" && computerChoice == "scissors" || userChoice == "paper" && computerChoice == "rock" || userChoice == "scissors" && computerChoice == "paper")
    {
        Console.WriteLine("you win.");
        pointsUser += 1;
    }
    else
    {
        Console.WriteLine("you loose.");
        pointsComputer += 1;
    }


    //// end program when sum of rounds reaches the number of choosen rounds
    //if (pointsTie + pointsUser + pointsComputer == rounds)
    //{
    //    Environment.Exit(0);
    //}
}