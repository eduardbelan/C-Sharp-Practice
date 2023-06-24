using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09CoffeeMachine
{
    internal class Coffeemachine
    {
        // declare instance variables waterlvl and coffeelvl
        private int waterlvl;
        private int coffeelvl;
        // declare static variables maxWaterlvl and maxCoffeelvl
        private static int maxWaterlvl = 100;
        private static int maxCoffeelvl = 50;


        // generate constructor
        public Coffeemachine(int waterlvl, int coffeelvl, int maxWaterlvl, int maxCoffeelvl)
        {
            Waterlvl = waterlvl;
            Coffeelvl = coffeelvl;
            Coffeemachine.maxWaterlvl = maxWaterlvl;
            Coffeemachine.maxCoffeelvl = maxCoffeelvl;
        }


        // encapsulate fields (and use property)
        public int Waterlvl { get => waterlvl; set => waterlvl = value; }
        public int Coffeelvl { get => coffeelvl; set => coffeelvl = value; }
        public static int MaxWaterlvl { get => maxWaterlvl; set => maxWaterlvl = value; }
        public static int MaxCoffeelvl { get => maxCoffeelvl; set => maxCoffeelvl = value; }


        // method to make one coffee, water and coffee levels go down
        private void MakeCoffee()
        {

            if (EnoughWater() && EnoughCoffee())
            {
                Waterlvl -= 10;
                Coffeelvl -= 5;
                Console.WriteLine("\n\tone coffee.\n");
            }
            // tell user to refill if insufficient stats
            else
            {
                Console.WriteLine("\n\trefill coffee machine.\n");
            }
        }


        // check if sufficient water
        private bool EnoughWater()
        {
            if (Waterlvl >= 10)
                return true;
            return false;
        }
        // check if sufficient coffee
        private bool EnoughCoffee()
        {
            if (Coffeelvl >= 5)
                return true;
            return false;
        }


        // refill water to max level
        private void RefillWater()
        {
            Waterlvl = maxWaterlvl;
            Console.WriteLine($"\n\trefill water.\n");

            // animation for refilling water
            int increase = 500;
            string u = "\u2588";
            for (int i = 0; i < 40; i++)
            {

                if (increase >= 50)
                    increase -= 25;
                else if (increase == 25)
                    increase = 25;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(u);
                Thread.Sleep(increase);
            }

            Console.ResetColor();
            Console.WriteLine($"\n\nwater:\t{Waterlvl}\n");
        }
        // refill coffee to max level
        private void RefillCoffee()
        {
            Coffeelvl = maxCoffeelvl;
            Console.WriteLine($"\n\trefill coffee.\n");

            // animation for refilling coffee
            int increase = 500;
            string u = "\u2588";
            for (int i = 0; i < 40; i++)
            {

                if (increase >= 50)
                    increase -= 25;
                else if (increase == 25)
                    increase = 25;

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(u);
                Thread.Sleep(increase);
            }

            Console.ResetColor();
            Console.WriteLine($"\n\ncoffee:\t{Coffeelvl}\n");
        }


        // input and validation for multiple coffees
        public int Order()
        {
            // set flag variable and define order variable
            bool validInput = false;
            int order = 0;

            do
            {
                validInput = false;

                try
                {
                    Console.Write("how many coffees?: ");
                    order = Convert.ToInt32(Console.ReadLine());

                    if (order <= 0)
                    {
                        Console.WriteLine("\n\tpositive numbers.\n");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n\tinvalid input.\n");
                }

            } while (!validInput);

            return order;
        }

        public void ClearOrder()
        {
            // set order variable from order method
            int order = Order();
            if (order == 0)
                return;
            // set order variable to view number of coffee
            int orderNum = 0;
            // loop until all orders are done
            while (order > 0)
            {

                // make coffee when sufficient stats
                if (EnoughWater() && EnoughCoffee())
                {
                    orderNum++;
                    Console.Write($"\ncoffee num:\t{orderNum}");
                    MakeCoffee();
                    order--;
                }

                // prompt user if insufficient stats
                else
                {
                    Console.WriteLine("\ninsufficient stats:\n" +
                        $"water:\t{Waterlvl}\n" +
                        $"coffee:\t{Coffeelvl}");

                    // loop until sufficient stats
                    while (true)
                    {
                        Console.Write("\n\tpress (w) to refill water:");
                        Console.Write("\n\tpress (c) to refill coffee:");
                        Console.Write("\n\tpress (a) to refill all:");
                        Console.Write("\n\tpress (x) to exit:");
                        Console.WriteLine();
                        string inputRefill = Console.ReadLine();

                        if (inputRefill == "w")
                        {
                            RefillWater();
                        }
                        else if (inputRefill == "c")
                        {
                            RefillCoffee();
                        }
                        else if (inputRefill == "a")
                        {
                            RefillWater();
                            RefillCoffee();
                        }
                        else if (inputRefill == "x")
                        {
                            Console.WriteLine("\n\tgoodbye.\n");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("\n\tinvalid input.\n");
                        }

                        if (EnoughWater() && EnoughCoffee())
                            break;
                    }
                }
            }
            ClearOrder();
        }
    }
}


// Lösung Unterricht
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _09Kaffeemaschine
//{
//    internal class Kaffeemaschine
//    {
//        //Deklarierung der Felder, die für unsere Kaffeemaschinen-Objekte gebraucht werden.
//        //Alle Felder stehen auf private, was im Zuge der Datenkapselung so sein sollte.
//        private int wasserstand;
//        private int bohnenmenge;
//        //Die beiden folgenden Felder sind statische Felder. Das bedeutet, sie sind für alle Objekte dieser Klasse gleich.
//        //Kein Objekt hat dafür einen individuellen Wert.
//        private static int maxWasserstand = 100;
//        private static int maxBohnenmenge = 100;


//        //Der Konstruktor, den wir aus den nicht statischen Eigenschaften generiert haben.
//        public Kaffeemaschine(int wasserstand, int bohnenmenge)
//        {
//            Wasserstand = wasserstand;
//            Bohnenmenge = bohnenmenge;
//        }


//        //Die Eigenschaften unserer Klasse
//        //Diese haben wir aus den Feldern erstellen lassen.
//        public int Wasserstand { get => wasserstand; set => wasserstand = value; }
//        public int Bohnenmenge { get => bohnenmenge; set => bohnenmenge = value; }
//        public static int MaxWasserstand { get => maxWasserstand; set => maxWasserstand = value; }
//        public static int MaxBohnenmenge { get => maxBohnenmenge; set => maxBohnenmenge = value; }


//        public void KaffeeZapfen()
//        {
//            //Console.WriteLine("Drücke 1 für small, 2 für medium, 3 für grande");
//            //string auswahl = Console.ReadLine();

//            //switch(auswahl)
//            //{
//            //    case "1":
//            //        Wasserstand = Wasserstand - 10;
//            //        Bohnenmenge = Bohnenmenge - 2;
//            //        Console.WriteLine("Hier bitte. Dein kleiner Kaffee. *hust* Geizhals *hust*");
//            //        break;

//            //    case "2":
//            //        Wasserstand = Wasserstand - 15;
//            //        Bohnenmenge = Bohnenmenge - 5;
//            //        Console.WriteLine("Hier bitte. Dein medium Kaffee. So schmeckt er auch. Eher Mittel ;)");
//            //        break;

//            //    case "3":
//            //        Wasserstand = Wasserstand - 20;
//            //        Bohnenmenge = Bohnenmenge - 8;
//            //        Console.WriteLine("Hier bitte. Dein großer Kaffee. Arbeiten wir etwa in der Programmierung?");
//            //        break;

//            //    default:
//            //        Console.WriteLine("Fehler.... bitte nicht so viel Kaffee trinken.");
//            //        break;
//            //}

//            //Wie gewohnt erfolgt die Prüfung in den runden Klammern nach if bzw else if.
//            //Statt Variablen verwenden wir jedoch Methoden zur Prüfung der jeweiligen Füllmenge.
//            //Diese geben einen boolschen Wert zurück der dann geprüft wird.

//            if (Wasserstandspruefung() && Bohnenmengenpruefung())
//            {
//                Wasserstand = Wasserstand - 20;
//                Bohnenmenge = Bohnenmenge - 8;
//                Thread.Sleep(3000);
//                Console.WriteLine("Hier bitte. Dein Kaffee.");
//                Thread.Sleep(3000);
//            }
//            else if (Wasserstandspruefung() == false && Bohnenmengenpruefung() == false)
//            {
//                Console.WriteLine("Bitte Wasser und Bohnen auffüllen.");
//                Thread.Sleep(3000);
//            }
//            else if (Wasserstandspruefung() == false && Bohnenmengenpruefung())
//            {
//                Console.WriteLine("Bitte Wasser auffüllen.");
//                Thread.Sleep(3000);
//            }
//            else if (Wasserstandspruefung() && Bohnenmengenpruefung() == false)
//            {
//                Console.WriteLine("Bitte Bohnen auffüllen.");
//                Thread.Sleep(3000);
//            }
//            //Dieses else dient um etwaige Fehler im Code abzufangen und so einen Systemabsturz zu vermeinden.
//            //Es empfielt sich immer das else nicht für den letzten möglichen, beabsichtigten Fall zu nehmen,
//            //sondern zum Abfangen von Fehlern.
//            //Also ähnlich dem default in einem Switch
//            else
//            {
//                Console.WriteLine("Schwerer Ausnahmefehler. Bitte Techniker rufen.");
//                Thread.Sleep(3000);
//            }
//        }

//        //Zwei Methoden um jeweils den Stand der Wasser- und Bohnenmenge zu prüfen.
//        //Da diese Methoden nur innerhalb der Klasse aufgerufen werden, kann und sollte der Zugriffsmodifikator private sein.
//        //Wir wollen mit den beiden Methoden prüfen ob ausreichend Wasser und Bohnen vorhanden sind um einen Kaffee zu machen.
//        //Dafür geben wir als Rückgabetyp bool an und benötigen in jedem Codepfad, also den geschweiften Klammern nach if und
//        //else, einen return.
//        //Da es sich um einen boolschen Wert handelt, reicht es nach dem return nur true oder false zu schreiben.

//        private bool Wasserstandspruefung()
//        {
//            if (Wasserstand < 20)
//            {
//                return false;
//            }
//            else
//            {
//                return true;
//            }
//        }

//        private bool Bohnenmengenpruefung()
//        {
//            if (Bohnenmenge < 8)
//            {
//                return false;
//            }
//            else
//            {
//                return true;
//            }
//        }

//        //Zwei Methoden die jeweils Wasser bzw Bohnen auf das Maximum auffüllen
//        public void WasserAuffuellen()
//        {
//            int auffuellmenge;
//            auffuellmenge = MaxWasserstand - Wasserstand;
//            Wasserstand = Wasserstand + auffuellmenge;
//            Console.WriteLine($"Wasser wieder aufgefüllt.\nEs wurden {auffuellmenge} Einheiten Wasser dafür gebraucht.");
//            Thread.Sleep(3000);
//        }

//        public void BohnenAuffuellen()
//        {
//            int auffuellmenge;
//            auffuellmenge = MaxBohnenmenge - Bohnenmenge;
//            Bohnenmenge = Bohnenmenge + auffuellmenge;
//            Console.WriteLine($"Bohnen wieder aufgefüllt.\nEs wurden {auffuellmenge} Einheiten Bohnen dafür gebraucht.");
//            Thread.Sleep(3000);
//        }

//        //Die folgende Methode ist das Menü zur Bedienung der Kaffeemaschine.
//        //Mit ihr können wir die einzelnen Methodenaufrufe aus der Program.cs in die Klasse verlagern.
//        //Daher könnte man sämtliche anderen Methoden mit ihren Zugriffsmodifikator auf private setzen.
//        public void KaffeeMenue()
//        {
//            do
//            {
//                Console.Clear();
//                Console.WriteLine("Bitte wähle die Ziffer für den auszuführenden Vorgang:");
//                Console.WriteLine("\t1 Kaffee Machen");
//                Console.WriteLine("\t2 Wasser auffüllen");
//                Console.WriteLine("\t3 Bohnen auffüllen");
//                Console.WriteLine("Eingabe: ");
//                string eingabe = Console.ReadLine();


//                //Hier das if / else if statement in der Kurzschreibweise ohne geschweifte Klammern
//                if (eingabe == "1")
//                    KaffeeZapfen();
//                else if (eingabe == "2")
//                    WasserAuffuellen();
//                else if (eingabe == "3")
//                    BohnenAuffuellen();
//                else
//                {
//                    Console.WriteLine("Ungültige Eingabe. Bitte wähle aus den gegebenen Optionen");
//                    Thread.Sleep(3000);
//                }
//            } while (true);
//        }
//    }
//}