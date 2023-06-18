//Der User soll angeben können, wieviel Bier in Litern getrunken wurde.
//Daraus wird die Menge des Reinalkohols in Gramm berechnet.
//Getrunkene Menge in Milliliter * Alkohlgehalt * Dichte des Ethanols.
//Bei Bier also: Getrunkene Menge in Milliliter * 0.05 * 0.8
//Der User soll auch sein gewicht in Kilogramm angeben.
//Dann wird der Blutalkoholgehalt in Promille berechnet.
//c = A / (0.65 * G)
//c ist der Promillewert, A der aufgenommene Alkohol in Gramm und G das Körpergewicht in kg.
//Es soll dann eine Ausgabe, abhängig vom Promillewert folgen:
//bis 0.3: "Noch akzeptabel. Dennoch vorsichtig sein."
//bis 0.5: "Achtung! Hände weg vom Steuer."
//bis 0.8: "Das ist schon ganz schön ordentlich."
//ab 0.8: "Kein Kommentar......"
//Wählen sie die passenden Datentypen für die jeweils notwendigen Variablen.
//Etwaige Eingabefehler sollen über einen else-Block angefangen werden.


//Meine Lösung

const float BIER = 0.05f;
const float DICHTE_ETH = 0.8f;

// user input, calc ltr in milliltr, bulletproof
double milliltr = 0;
while (true)
{
    try
    {
        Console.WriteLine("Menge in Ltr.:");
        milliltr = Convert.ToDouble(Console.ReadLine()) * 1000d;
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Input.");
    }
}

// user input, weight in kg, bulletproof
double gewicht = 0;
while (true)
{
    try
    {
        Console.WriteLine("Gewicht in kg:");
        gewicht = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Input.");
    }
}

// calc alc in g
double alkMenge = Math.Round((milliltr * BIER * DICHTE_ETH), 2);

// calc blood alc
double promille = Math.Round((alkMenge / (0.65 * gewicht)), 2);

// output all info
Console.WriteLine($"\nGetrunkene Menge in Ltr:\t{milliltr / 1000d} ltr.\n"
                  + $"Getrunkene Menge in Milliltr:\t{milliltr} ml.\n"
                  + $"Körpergewicht in kg:\t\t{gewicht} kg.\n"
                  + $"Promillewert:\t\t\t{promille} \u2030\n");

// statements
if (promille < 0.3)
{
    Console.WriteLine("\nEmpfehlung:\nAcceptable to drive.");
}
else if (promille < 0.5)
{
    Console.WriteLine("\nEmpfehlung:\nAttention! Don't drive.");
}
else if (promille < 0.8)
{
    Console.WriteLine("\nEmpfehlung:\nSlow down drinking.");
}
else if (promille >= 0.8)
{
    Console.WriteLine("\nEmpfehlung:\nFun evening but slow down on the drinking.");
}
else
{
    Console.WriteLine("Invalid Input.");
}



//// Lösung Unterricht
//double getrunkeneMenge;
//double gewicht;
//double alkoholGehalt = 0.05d;
//double ethDichte = 0.8d;
//double reinAlk;
//double promille;

//Console.WriteLine("Hallo user! Wieviel Liter Bier hast du getrunken?");
//getrunkeneMenge = Convert.ToDouble(Console.ReadLine()) * 1000d;

//Console.WriteLine("Nenne mir jetzt bitte dein gewicht in Kilogramm.");
//gewicht = Convert.ToDouble(Console.ReadLine());

//reinAlk = getrunkeneMenge * alkoholGehalt * ethDichte;

//promille = Math.Round(reinAlk / (0.65d * gewicht), 2);

//Console.WriteLine($"{promille} Promille");

//if (promille <= 0.3d)
//{
//    Console.WriteLine("Noch akzeptabel. Dennoch vorsichtig sein!");
//}
//else
//{
//    if (promille > 0.3d && promille <= 0.5d)
//    {
//        Console.WriteLine("Achtung! Hände weg vom Steuer.");
//    }
//    else
//    {
//        if (promille > 0.5d && promille <= 0.8d)
//        {
//            Console.WriteLine("Das ist schon ganz schön Ordentlich.");
//        }
//        else
//        {
//            if (promille > 0.8d)
//            {
//                Console.WriteLine("Kein Kommentar....");
//            }
//            else
//            {
//                Console.WriteLine("Da ist etwas schief gelaufen. Etwa schon betrunken?");
//            }
//        }
//    }
//}