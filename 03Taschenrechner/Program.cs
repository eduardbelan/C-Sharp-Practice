// Aufgabe
//Erstelle einen einfachen Taschenrechner.
//Der User soll zuerst eine Zahl eingeben, dannach das Zeichen für die rechenart, und anschließend die zweite Zahl.
//(+ - * / reicht vollkommen aus)
//Anschließend wird die Berechnung in der Konsole ausgegeben. 


// Meine Lösung (unfinished)

// define variables
double num1;
double num2;
double result = 0;

// formulas
double Add(double num1, double num2)
{
    return num1 + num2;
}

double Subtract(double num1, double num2)
{
    return num1 - num2;
}

double Multiply(double num1, double num2)
{
    return num1 * num2;
}

double Divide(double num1, double num2)
{
    return num1 / num2;
}

// input num1 bulletproof as function
void inputNumOne()
{
    while (true)
    {
        try
        {
            Console.WriteLine("num1:");
            num1 = Convert.ToDouble(Console.ReadLine());
            break;
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Invalid Input num1. Enter num1.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

// input num2 bulletproof as function
void inputNumTwo()
{
    while (true)
    {
        try
        {
            Console.WriteLine("num2:");
            num2 = Convert.ToDouble(Console.ReadLine());
            break;
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Invalid Input num2. Enter num2.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

// ask math op
string askMathOperation()
{
    Console.WriteLine("+, -, *, /");
    return Console.ReadLine();
}

// determine conditions & calculate
void conditions(string operation)
{
    switch (operation)
    {
        case "+":
        case "add":
        case "plus":
            result = Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {result}");
            break;

        case "-":
        case "subtract":
        case "minus":
            result = Subtract(num1, num2);
            Console.WriteLine($"{num1} - {num2} = {result}");
            break;

        case "*":
        case "multiply":
        case "times":
        case "mal":
            result = Multiply(num1, num2);
            Console.WriteLine($"{num1} * {num2} = {result}");
            break;

        case "/":
        case "divide":
        case "division":
        case "geteilt":
        case "geteilt durch":
        case "durch":
        case "geteiltdurch":
            result = Divide(num1, num2);
            Console.WriteLine($"{num1} / {num2} = {result}");
            break;

        default:
            Console.WriteLine("Invalid operation.");
            break;
    }
}

// ask keep number
bool keepNum()
{
    while (true)
    {
        Console.WriteLine("\nKeep calculating with number? (y/n)");
        string keepNumber = Console.ReadLine();

        if (keepNumber == "y")
        {
            num1 = result;
            return true;
        }

        else if (keepNumber == "n")
        {
            return false;
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Invalid Input.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

// go again
bool goAgain()
{
    while (true)
    {
        Console.WriteLine("Another Calculation? (y/n)");
        string goCalc = Console.ReadLine();

        if (goCalc == "y")
        {
            return true;
        }

        else if (goCalc == "n")
        {
            return false;
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Invalid Input.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

// method calls for program to run wie eine Nähmaschine
while (true)
{
    inputNumOne();
    while (true)
    {
        inputNumTwo();
        string operation = askMathOperation();
        conditions(operation);
        if (!keepNum())
            break;
    }
    if (!goAgain())
        break;
}


//// Lösung Unterricht
//double zahl1;
//double zahl2;
//double ergebnis = 0;
//string rechenart;

//Console.WriteLine("Hallo User!\nBitte gib deine erste Zahl ein.");
//zahl1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Bitte gib nun die Art der Berechnung an.");
//rechenart = Console.ReadLine();
//Console.WriteLine("Bitte gib nun deine zweite zahl ein.");
//zahl2 = Convert.ToDouble(Console.ReadLine());

//switch (rechenart)
//{
//    case "+":
//        ergebnis = zahl1 + zahl2;
//        Console.WriteLine($"{zahl1} {rechenart} {zahl2} = {ergebnis}");
//        break;

//    case "-":
//        ergebnis = zahl1 - zahl2;
//        Console.WriteLine($"{zahl1} {rechenart} {zahl2} = {ergebnis}");
//        break;

//    case "*":
//        ergebnis = zahl1 * zahl2;
//        Console.WriteLine($"{zahl1} {rechenart} {zahl2} = {ergebnis}");
//        break;

//    case "/":
//        ergebnis = zahl1 / zahl2;
//        Console.WriteLine($"{zahl1} {rechenart} {zahl2} = {ergebnis}");
//        break;

//    default:
//        Console.WriteLine("Ungültiger Operator.");
//        break;

//}