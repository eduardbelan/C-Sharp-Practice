//Erstellen sie einen Algorithmus der das Spiel FizzBuzz bis zur 100 durchführt.
//Regeln siehe https://de.wikipedia.org/wiki/Fizz_buzz
//Modulo gibt den rest einer Division als Ganzzahl zurück. Das zeichen für den Operator ist %
//Beispiel: 4 % 2 = 0


// Meine Lösung

int range = 101;

for (int i = 0; i < range; ++i)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}


// short version
// using a ternary operator and string interpolation
// In this version, a ternary operator is used to check the conditions and assign the appropriate string value
// to the output variable. The ToString() method is used to convert the integer i to a string
// when it doesn't meet any of the conditions for "Fizz", "Buzz", or "FizzBuzz".
//int range = 101;

//for (int i = 0; i < range; ++i)
//{
//    string output = (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" : (i % 3 == 0) ? "Fizz" : (i % 5 == 0) ? "Buzz" : i.ToString();
//    Console.WriteLine(output);
//}


// Lösung Unterricht
//for (int i = 1; i <= 100; i++)
//{
//    if (i % 15 == 0)
//    {
//        Console.WriteLine("FizzBuzz");
//    }
//    else if (i % 3 == 0)
//    {
//        Console.WriteLine("Fizz");
//    }
//    else if (i % 5 == 0)
//    {
//        Console.WriteLine("Buzz");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//}