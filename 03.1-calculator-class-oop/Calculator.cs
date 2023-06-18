namespace _calculator_class_oop
{
    internal class Calculator
    {
        public void RunCalculator()
        {
            bool calculateAgain;

            do
            {
                double num1 = inputNumOne();
                double num2 = inputNumTwo();

                string operation = askMathOperation();
                double result = calculation(num1, num2, operation);

                Console.Write("\nresult:\t\t" + Math.Round(result, 2));

                while (true)
                {
                    calculateAgain = keepNum(num1, result);

                    if (!calculateAgain)
                    {
                        break;
                    }
                    else
                    {
                        num1 = result;
                        num2 = inputNumTwo();
                        operation = askMathOperation();
                        result = calculation(result, num2, operation);
                    }

                    Console.Write("\nresult:\t\t" + Math.Round(result, 2));
                }
            } while (goAgain());
        }

        private static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        private static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        private static double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }

        private static double Divide(double num1, double num2)
        {
            return (num1 / num2);
        }

        private static double inputNumOne()
        {
            while (true)
            {
                try
                {
                    Console.Write("num1:\t\t");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    return num1;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nenter num1.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private static double inputNumTwo()
        {
            while (true)
            {
                try
                {
                    Console.Write("num2:\t\t");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    return num2;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nenter num2.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private static string askMathOperation()
        {
            bool validOperator = false;
            string operation = "";
            do
            {
                Console.WriteLine("\n+, -,");
                Console.Write("*, /\t\t");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                    case "add":
                    case "plus":
                    case "addieren":
                        validOperator = true;
                        operation = "+";
                        break;

                    case "-":
                    case "subtract":
                    case "minus":
                    case "subtrahieren":
                        validOperator = true;
                        operation = "-";
                        break;

                    case "*":
                    case "multiply":
                    case "mal":
                    case "multiplizieren":
                        validOperator = true;
                        operation = "*";
                        break;

                    case "/":
                    case "divide":
                    case "divide by":
                    case "geteilt":
                    case "durch":
                    case "geteilt durch":
                    case "dividieren":
                        validOperator = true;
                        operation = "/";
                        break;

                    default:
                        break;
                }
            } while (!validOperator);

            return operation;
        }

        private static double calculation(double num1, double num2, string operation)
        {
            if (operation == "+")
            {
                return Add(num1, num2);
            }
            else if (operation == "-")
            {
                return Subtract(num1, num2);
            }
            else if (operation == "*")
            {
                return Multiply(num1, num2);
            }
            else
            {
                return Divide(num1, num2);
            }
        }

        private static bool keepNum(double num1, double result)
        {
            while (true)
            {
                Console.Write("\n\n\ncalculate with result? (y/n):\t");
                string keepNumber = Console.ReadLine();

                if (keepNumber == "y")
                {
                    return true;
                }
                else if (keepNumber == "n")
                {
                    return false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\ninvalid input.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private static bool goAgain()
        {
            while (true)
            {
                Console.Write("\nagain? (y/n):\t");
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
                    Console.WriteLine($"\ninvalid input.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}