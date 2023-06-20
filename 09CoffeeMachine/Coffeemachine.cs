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
