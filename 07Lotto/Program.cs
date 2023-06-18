//Aufgabe 1: Lottozahlen
//Erstelle ein int[]-Array nahmens lottozahlenmit der Länge von 49
//Schreibe dann einen Code, der dieses Arrya automatisch mit den Zahlen 1 - 49 befüllt.


// Meine Lösung

// init int array of length 49
int[] lottozahlen = new int[49];

// for loop that appends numbers to array from 1 to 49
for (int i = 0; i < lottozahlen.Length; i++)
{
    lottozahlen[i] = i + 1;
}


//Aufgabe 2: Ziehung der Lottozahlen
//Aus dem Array unserer Lottozahlen sollen nun sechs Zahlen zufällig gezogen werden.
//Diese sechs Zahlen müssen in einem neuem Array abgelegt werden.
//Verwende random für die zufällige Ziehung.
//Bei gezogenen Zahlen darf es zu keiner Dopplung kommen.


// Meine Lösung

// new array for 6 random nums
int range = 6;
int[] winners = new int[range];

// Ranom instance variable
Random random = new Random();

// loop in range of numWinners
for (int i = 0; i < range; i++)
{
    // random number variable
    int randomNumber;

    // do-while loop to pick random num from lottozahlen array
    do
    {
        // random number is picked
        randomNumber = random.Next(0, lottozahlen.Length);
    // as long as winners doesn't already contain the picked random number
    } while (winners.Contains(randomNumber));

    // at index i, set the random number that was picked
    winners[i] = randomNumber;
}

// view winners - cheat mode
Array.Sort(winners);
Console.WriteLine();
Console.Write("Lotto:\t\t");

// loop to view the winners
foreach (int num in winners)
{
    if (num <= 9)
    {
        Console.Write(" " + num + "\t");
    }
    else
    {
        Console.Write(num + "\t");
    }
}
Console.Write("\t\tcheat mode enabled");
Console.WriteLine("");
//Aufgabe 3: User-Eingabe und Gewinnausgabe
//Der User soll in der Lage sein, sechs Zahlen einzugeben.
//Diese werden in einem Array abgelegt.
//Danach soll überprüft werden, wieviele Zahlen der User im Vergleich zu den gezogenen Lottozahlen richtig getippt
//hat. Sprich, wieviele Zahlen in den beiden Arrays gleich sind.
//Gib in der Konsole aus wieviele Richtig getippt wurden.


// Meine Lösung

// new array for 6 tipps
int[] tipp = new int[range];
int tippInput = 0;

// for loop in given range
for (int i = 0; i < range; i++)
{
    // set flag for valid input check nums
    bool validInput = false;
    // input validation do-while for nums range 1 - 49
    do
    {
        // set flag for valid input check alpha
        bool inputNoAlpha = false;
        // input validation do-while for alpha
        do
        {
            try
            {
                // ask for tipp numbers
                Console.Write($"tipp {i + 1}:\t");
                tippInput = Convert.ToInt32(Console.ReadLine());
                inputNoAlpha = true;
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("nums only\n");
            }
        } while (!inputNoAlpha);

        // input check for numbers range 1 - 49
        if (tippInput <= 0 || tippInput > 49)
        {
            Console.WriteLine("numbers from 1 - 49\n");
        }
        // input check for doubles
        else if (tipp.Contains(tippInput))
        {
            Console.WriteLine("num already tipped\n");
        }
        // input valid, exit loop
        else
        {
            validInput = true;
            Console.WriteLine("");
        }

    } while (!validInput);

    // append tipp number
    tipp[i] = tippInput;
}


// view tipps
Console.Clear();
Console.Write("Your Tipps:\t");

// sort arrays by ascending nums
Array.Sort(tipp);
Array.Sort(winners);

// loop to view the tipps
foreach (int num in tipp)
{
    if (num <= 9)
    {
        Console.Write(" " + num + "\t");
    }
    else
    {
        Console.Write(num + "\t");
    }
}

// view winners
Console.WriteLine();
Console.Write("Lotto:\t\t");

// loop to view the winners
foreach (int num in winners)
{
    if (num <= 9)
    {
        Console.Write(" " + num + "\t");
    }
    else
    {
        Console.Write(num + "\t");
    }
}


// check for doubles
int equalsSum = 0;
List<int> equals = new List<int>();

foreach (int n1 in winners)
{
    foreach (int n2 in tipp)
    {
        if (n1 == n2)
        {
            equalsSum++;
            equals.Add(n1);
        }
    }
}

// show sum equals
Console.WriteLine("\n");
Console.WriteLine($"total equals:\t{equalsSum}");
Console.Write("equal nums:\t\t");

// show all equals
foreach (int num in equals)
{
    Console.Write(num + "\t");
}


// Aufgabe 1: Lösung Unterricht
//int[] lottozahlen = new int[49];

//for (int i = 0; i < lottozahlen.Length; i++)
//{
//    lottozahlen[i] = i + 1;
//}


// Aufgabe 2: Lösung Unterricht
//Aus der Aufgabe heraus notwendige Variablen
//Random rnd = new Random(); //Zur erzeugung einer Zufallszahl
//int[] gezogeneZahlen = new int[6]; //das Array für die gezogenen Zahlen

//for (int i = 0; i < 6; i++)
//{
//    //Variablen die für die weitere Logik notwendig sind
//    int zufallsIndex;
//    int gezogeneZahl;
//    int bereitsGezogen = -1;

//    do
//    {
//        zufallsIndex = rnd.Next(0, lottozahlen.Length); //Die Variable rnd erzeugt mit der Next()-Methode eine zufällige Zahl
//                                                        //zwischen 0 und 48 die sie als Wert speichert. Dieser Wert wird zufallsIndex
//                                                        //als wert zugewiesen.
//        gezogeneZahl = lottozahlen[zufallsIndex]; //Der Wert von zufallsIndex ist der Index den wir uns im Array lottozahlen[]
//                                                  //ansehen und der Variablen gezogeneZahl zuweisen.
//    }
//    while (gezogeneZahl == bereitsGezogen); //Die Kondition der do-while-Schleife prüft nun, ob der Wert von gezogeneZahl gleich
//                                            //dem Wert von bereitsgezogen, also -1, ist. Ist das der fall, wird die Schleife ein 
//                                            //weiteres mal ausgeführt. Nur wenn ein anderer Wert als -1 in gezogeneZahl steckt kann
//                                            //die Schleife verlassen werden.

//    lottozahlen[zufallsIndex] = bereitsGezogen; //Der Wert, der im Array lottozahlen[] mit der Variablen zufallsIndex bestimmt
//                                                //wurde, bekommt nun den Wert von bereitsGezogen zugewiesen. Wir überschreiben
//                                                //den Wert also mit -1.
//    gezogeneZahlen[i] = gezogeneZahl; //Der in gezogeneZahl gespeicherte Wert wird nun in das Array gezogeneZahlen[] geschrieben.
//                                      //Und zwar an die Indexstelle, die uns durch die for-Zählerschleife gerade angegeben wird.
//}


// Aufgabe 3: Lösung Unterricht
//foreach (int i in gezogeneZahlen)
//{
//    Console.WriteLine(i);
//}

//int[] tippZahlen = new int[6];

//Console.WriteLine("Hallo User!\nBitte gib sechs Zahlen zwischen 1 und 49 ein.\nBestätige jede eingabe mit Enter.");

////Minimallösung:
////tippZahlen[0] = Convert.ToInt32(Console.ReadLine());
////tippZahlen[1] = Convert.ToInt32(Console.ReadLine());
////tippZahlen[2] = Convert.ToInt32(Console.ReadLine());
////tippZahlen[3] = Convert.ToInt32(Console.ReadLine());
////tippZahlen[4] = Convert.ToInt32(Console.ReadLine());
////tippZahlen[5] = Convert.ToInt32(Console.ReadLine());

////Die Minimallösung kann mit Hilfe einer for-schleife "automatisiert" werden:
////for(int i = 0; i < tippZahlen.Length; i++)
////{
////    tippZahlen[i] = Convert.ToInt32(Console.ReadLine());
////}

////Die Automatisierung erweitert um die Prüfung auf doppelte Eingabe und Zahlen außerhalb von 1 bis 49:
//for (int i = 0; i < tippZahlen.Length; i++)
//{
//    bool doppelt;
//    do
//    {
//        doppelt = false;
//        tippZahlen[i] = Convert.ToInt32(Console.ReadLine());

//        //Diese for-Schleife dient zur überprüfung ob die eingegebene Zahl schon einmal eingegeben wurde.
//        //Alle bisher eingegebenen Zahlen (j) werden mit der gerade eingegebenen Zahl (i) über die if-Abfrage verglichen.
//        //Stimmt der Wert überein, setzen wir einen Bool auf true. Dieser boolsche Wert wird dann in der while-Kondition überprüft.

//        for (int j = 0; j < i; j++)
//        {
//            if (tippZahlen[j] == tippZahlen[i])
//            {
//                doppelt = true;
//            }
//        }
//    }
//    while (tippZahlen[i] <= 0 || tippZahlen[i] > 49 || doppelt);//Die do-while-Schleife hat nichts mit der Befüllung des Arrays ansich zu tun.
//                                                                //Sie dient lediglich zur Überprüfung ob der User nur Zahlen im Bereich zwischen 1 und 49 eingegeben
//                                                                //hat, und ob ein Wert doppelt eingegeben wurde.
//                                                                //Durch die while-Kondition wird der User so lange gezwungen eine Zahl für diesen Index einzugeben
//                                                                //bis diese den Anforderungen entspricht.

//}

//int anzahlRichtige = 0;

//for (int j = 0; j < gezogeneZahlen.Length; j++)
//{
//    //Minimallösung:
//    //if (tippZahlen[0] == gezogeneZahlen[j])
//    //{
//    //    anzahlRichtige++;
//    //}
//    //if (tippZahlen[1] == gezogeneZahlen[j])
//    //{
//    //    anzahlRichtige++;
//    //}
//    //if (tippZahlen[2] == gezogeneZahlen[j])
//    //{
//    //    anzahlRichtige++;
//    //}
//    //if (tippZahlen[3] == gezogeneZahlen[j])
//    //{
//    //    anzahlRichtige++;
//    //}
//    //if (tippZahlen[4] == gezogeneZahlen[j])
//    //{
//    //    anzahlRichtige++;
//    //}
//    //if (tippZahlen[5] == gezogeneZahlen[j])
//    //{
//    //    anzahlRichtige++;
//    //}

//    //Die Minimallösung wird mit Hilfe einer weiteren, inneren for-schleife "automatisiert"
//    for (int z = 0; z < tippZahlen.Length; z++)
//    {
//        if (tippZahlen[z] == gezogeneZahlen[j])
//        {
//            anzahlRichtige++;
//            break;
//        }
//    }
//}


//Console.WriteLine($"Du hast {anzahlRichtige} Richtige");