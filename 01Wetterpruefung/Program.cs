//Der User soll dir mitteilen, ob das Wetter gerade "sonning" oder "regnerisch" ist.
//Auch die Temperatur soll der User angeben können.
//Liegt die Temperatur bei oder über 20°C und es ist sonning, empfehle dem User ein T-Shirt zu tragen.
//Liegt die Temperatur unter 20°C und es ist sonnig, empfehle eine Jacke anzuziehen.
//Bei regnerischen Wetter werden ebenfalls die zur Temperatur passenden Kleidungsempfehlungen ausgesprochen
//und der User soll darauf hingewiesen werden, dass er einen Regenschirm mitnehmen soll.
//Etwaige falsche Eingaben sollen über einen else-Block abgefangen werden. 


// Meine Lösung
using System.Globalization;

// get weather
string wetter;
Console.WriteLine("Eingabe: 's' für sonnig, 'r' für regnerisch:");
wetter = Console.ReadLine().ToLower();


//// get temp(nur Ganzzahlig)
//Console.WriteLine("Temperatur, nur Ganzzahlig:");
//int temp = Convert.ToInt32(Console.ReadLine());

// get temp (auch durch komma separiert)
Console.WriteLine("Temperatur, auch Kommazahl:");
string komma = Console.ReadLine();
// create a CultureInfo object based on the users locale settings
CultureInfo culture = CultureInfo.CurrentCulture;
// use NumberFormat.NumberDecimalSeparator and .Replace to replace the comma
string decimalSeparator = culture.NumberFormat.NumberDecimalSeparator;
string normalizedInput = komma.Replace(",", decimalSeparator);
// now we can convert to double
double temp = Convert.ToDouble(normalizedInput);
Console.WriteLine(temp);


////temp >= 20, sonnig
//if (temp >= 20 && wetter == "s")
//{
//    if (temp == 20)
//    {
//        Console.WriteLine($"sonnig, {temp} = 20 shirt.");
//    }
//    else
//    {
//        Console.WriteLine($"sonnig, {temp} > 20 shirt.");
//    }
//}
////temp < 20, sonnig
//else if (temp < 20 && wetter == "s")
//{
//    Console.WriteLine($"sonnig, {temp} < 20 jacke.");
//}
////temp >= 20, regen
//else if (temp >= 20 && wetter == "r")
//{
//    if (temp == 20)
//    {
//        Console.WriteLine($"regnerisch, {temp} = 20 shirt + shirm.");
//    }
//    else
//    {
//        Console.WriteLine($"regnerisch, {temp} > 20 shirt + shirm.");
//    }
//}
////temp < 20, regen
//else if (temp < 20 && wetter == "r")
//{
//    Console.WriteLine($"regnerisch, {temp} > 20 jacke + shirm.");
//}
////falsche eingabe
//else
//{
//    Console.WriteLine("Falsche Eingabe.");
//}


// other version using interpolated strings
// Let's break it down step by step:
// 1: The interpolated string is defined using the $ symbol at the beginning: $"sonnig, {temp} {(temp == 20 ? "=" : ">")} 20 shirt."
// 2: Inside the interpolated string, we have {temp} which is a placeholder for the temp variable's value.
// 3: Next, we have the conditional expression(temp == 20 ? "=" : ">").This is the conditional operator (?:) syntax.
//      - It checks whether temp is equal to 20.
//      - If the condition is true(temp == 20), it evaluates to "=".
//      - If the condition is false(temp != 20), it evaluates to ">".
// 4: The result of the conditional expression("=" or ">") is then inserted into the interpolated string.
// So, depending on the value of temp, the interpolated string will dynamically include either = or > in the output.
// This eliminates the need for separate if statements or additional conditional logic to handle the equality comparison.
if (wetter == "s")
{
    if (temp >= 20)
    {
        Console.WriteLine($"sonnig, {temp} {(temp == 20 ? "=" : ">")} 20 shirt.");
    }
    else
    {
        Console.WriteLine($"sonnig, {temp} < 20 jacke.");
    }
}
else if (wetter == "r")
{
    if (temp >= 20)
    {
        Console.WriteLine($"regnerisch, {temp} {(temp == 20 ? "=" : ">")} 20 shirt + shirm.");
    }
    else
    {
        Console.WriteLine($"regnerisch, {temp} < 20 jacke + shirm.");
    }
}
else
{
    Console.WriteLine("Falsche Eingabe.");
}


// Python version using interpolated strings

//wetter = input("Enter the weather (sunny or rainy): ")
//temp = float(input("Enter the temperature: "))

//if wetter == "s":
//    if temp >= 20:
//        print(f"sonnig, {temp} {'=' if temp == 20 else '>'} 20 shirt.")
//    else:
//        print(f"sonnig, {temp} < 20 jacke.")
//elif wetter == "r":
//    if temp >= 20:
//        print(f"regnerisch, {temp} {'=' if temp == 20 else '>'} 20 shirt + shirm.")
//    else:
//        print(f"regnerisch, {temp} < 20 jacke + shirm.")
//else:
//    print("Falsche Eingabe.")


//// Lösung Unterricht
//string wetterBedingung;
//int temperatur;

//Console.WriteLine("Hallo User! ist es gerade sonnig oder regnerisch?");
//wetterBedingung = Console.ReadLine().ToLower(); //ToLower() Konvertiert den eingegebenen Text in Kleinbuchstaben.
//Console.WriteLine("Und wieviel Grad beträgt gerade die Temperatur?");
//temperatur = Convert.ToInt32(Console.ReadLine());

//if (temperatur >= 20 && wetterBedingung == "sonnig")
//{
//    Console.WriteLine("Das ist ja mal gutes Wetter. Da sollte ein T-Shirt reichen.");
//}
//else
//{
//    if (temperatur >= 20 && wetterBedingung == "regnerisch")
//    {
//        Console.WriteLine("T-Shirt zeit! Aber nimm einen Regenschirm mit!");
//    }
//    else
//    {
//        if (temperatur < 20 && wetterBedingung == "sonnig")
//        {
//            Console.WriteLine("Voll schön draußen. Aber nimm eine Jacke mit.");
//        }
//        else
//        {
//            if (temperatur < 20 && wetterBedingung == "regnerisch")
//            {
//                Console.WriteLine("Ist ja nicht so gutes Wetter. Nimm besser einen Schirm und Jacke mit.");
//            }
//            else
//            {
//                Console.WriteLine("Oh je, da ist etwas schief gelaufen. Überprüfe bitte deine eingaben.");
//            }
//        }
//    }
//}