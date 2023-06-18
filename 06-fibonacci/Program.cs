//Der user soll angeben können, wieviele Zahlen der Fibonacci-Folge er berechnet haben möchte.
//Gib in der Konsole dann die entsprechenden Fibonacci-Zahlen aus.
//Die Fibonacci-Folge beginnt mit den Zahlen 0 und 1. Jede weitere Zahl ergibt sich, in dem man die beiden vorherigen Zahlen
//zusammenzählt.
//Als Beispiel die ersten zehn Zahlen:
//0 1 1 2 3 5 8 13 21 34


// Meine Lösung

using System.Data;

int range = 0;
ulong fibonacci;
bool validInput = false, goAgain = false, goAgainInput = false;
string again;

do
{
    do
    {
        validInput = false;

        try
        {
            Console.WriteLine("enter fibonacci range:\n");
            range = Convert.ToInt32(Console.ReadLine());

            if (range <= 0)
            {
                Console.WriteLine("\npositive numbers.");
            }
            else
            {
                validInput = true;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("\ninvalid input.");
        }
    } while (!validInput);

    // clear console
    Console.Clear();
    Console.WriteLine($"fibonacci sequence of range {range}\n");

    // reset values
    ulong a = 0, b = 1;

    // print the first two fibonacci numbers
    if (range == 1)
    {
        Console.WriteLine("0");
    }
    else if (range == 2)
    {
        Console.WriteLine("0");
        Console.WriteLine("1");
    }
    else
    {
        Console.WriteLine("0");
        Console.WriteLine("1");
        // for loop to determine the range of fibonacci numbers
        for (int i = 2; i < range; ++i)
        {
            fibonacci = a + b;
            Console.WriteLine(string.Format("{0:N0}", fibonacci));

            a = b;
            b = fibonacci;
        }
    }

    do
    {
        Console.WriteLine("\nagain? (y/n)");
        again = Console.ReadLine().ToLower();

        switch (again)
        {
            case "y":
            case "yes":
            case "ja":
            case "yea":
            case "yeah":
            case "jap":
            case "jep":
            case "jo":
            case "ok":
            case "okay":
                goAgainInput = true;
                Console.Clear();
                break;

            case "n":
            case "no":
            case "nope":
            case "njet":
            case "nah":
            case "nein":
            case "nö":
                goAgain = true;
                goAgainInput = true;
                break;

            default:
                Console.Clear();
                break;
        }
    } while (!goAgainInput);
} while (!goAgain);


// Lösung Unterricht
//ulong a = 0, b = 1;

//Console.WriteLine("Hallo User!\nGib an, wieviele Zahlen der Fibonacci-Folge du berechnet haben möchtest.");
//int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Hier sind die {n} Zahlen:");
//Console.WriteLine(a);
//Console.WriteLine(b);

//for (int i = 2; i < n; i++)
//{
//    ulong c = a + b;
//    Console.WriteLine(c);

//    a = b;
//    b = c;
//}