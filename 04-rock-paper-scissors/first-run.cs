// First run of the program

////Console.WriteLine("Computer Choose:\n");
//Thread.Sleep(100); // 500
//Console.Write(". ");
//Thread.Sleep(100);
//Console.Write(". ");
//Thread.Sleep(100);
//Console.WriteLine(".");
//Thread.Sleep(100);
//Console.WriteLine("Calculating...");
//Thread.Sleep(100); // 2
//Console.WriteLine("Estimating Parameters...");
//Thread.Sleep(100);
//Console.WriteLine("Thinking about how to destroy Planet Earth...");
//Thread.Sleep(100); // 3
//Console.WriteLine("...just kidding.");
//Thread.Sleep(100); // 2
//Console.WriteLine("I already know your pick so this is easy...");
//Thread.Sleep(100); // 3
//Console.WriteLine("While you wait, take a look at this Helicopter.");
//Thread.Sleep(100); // 2
//Console.WriteLine(helicopter);
//Thread.Sleep(100);
//Console.WriteLine("It can fly, look!");
//Thread.Sleep(100);



//// helicopter
//// console sleep timer for rotor animation
//int timer = 1050;
//for (int i = 0; i < 10; i++)
//{
//    // upper rotor
//    Thread.Sleep(timer);
//    Console.SetCursorPosition(0, 48);
//    Console.Write("                                        !roflroflrofl");
//    Console.SetCursorPosition(0, 49);
//    Console.Write("          roflroflrofl!             /=====\\");

//    Thread.Sleep(timer);
//    Console.SetCursorPosition(0, 48);
//    Console.Write("                            roflroflrofl!            ");
//    Console.SetCursorPosition(0, 49);
//    Console.Write("                      !roflroflrofl /=====\\");

//    // reduce timer gradually for smooth animation
//    if (timer < 100)
//    {
//        timer = 50;
//    }
//    else
//    {
//        timer -= 200;
//    }
//}

//int animationHeight = 48;
//int sleepDuration = 126;
//int one = animationHeight;
//int two = animationHeight + 1;
//int three = animationHeight + 2;
//int four = animationHeight + 3;
//int five = animationHeight + 4;
//int six = animationHeight + 5;
//int clearingPoint = 28;

//// Animation loop
//while (one > 0)
//{
//    // Clear the previous lines
//    Console.SetCursorPosition(0, one);
//    Console.Write(new string(' ', Console.WindowWidth));
//    Console.SetCursorPosition(0, two);
//    Console.Write(new string(' ', Console.WindowWidth));
//    Console.SetCursorPosition(0, three);
//    Console.Write(new string(' ', Console.WindowWidth));
//    Console.SetCursorPosition(0, four);
//    Console.Write(new string(' ', Console.WindowWidth));
//    Console.SetCursorPosition(0, five);
//    Console.Write(new string(' ', Console.WindowWidth));
//    Console.SetCursorPosition(0, six);
//    Console.Write(new string(' ', Console.WindowWidth));

//    // Set cursor position for flight
//    if (one > clearingPoint)
//    {
//        Console.SetCursorPosition(0, one - 1);
//        Console.Write("                            roflroflrofl!roflroflrofl");
//    }
//    if (two > clearingPoint)
//    {
//        Console.SetCursorPosition(0, two - 1);
//        Console.Write("          roflroflrofl!roflroflrofl /=====\\");
//    }
//    if (three > clearingPoint)
//    {
//        Console.SetCursorPosition(0, three - 1);
//        Console.Write("                     |===\\_________/_  o  |");
//    }
//    if (four > clearingPoint)
//    {
//        Console.SetCursorPosition(0, four - 1);
//        Console.Write("                    /_]    o o  o o____   /");
//    }
//    if (five > clearingPoint)
//    {
//        Console.SetCursorPosition(0, five - 1);
//        Console.Write("                   <_]___[]_______<____>/");
//    }
//    if (six > clearingPoint)
//    {
//        Console.SetCursorPosition(0, six - 1);
//        Console.Write("                       o              o");
//    }

//    // rotor animation
//    if (one > clearingPoint)
//    {
//        for (int i = 0; i < 1; i++)
//        {
//            Thread.Sleep(50);
//            Console.SetCursorPosition(0, one - 1);
//            Console.Write("                                        !roflroflrofl");
//            Console.SetCursorPosition(0, two - 1);
//            Console.Write("          roflroflrofl!             /=====\\");
//            Thread.Sleep(50);
//            Console.SetCursorPosition(0, one - 1);
//            Console.Write("                            roflroflrofl!            ");
//            Console.SetCursorPosition(0, two - 1);
//            Console.Write("                      !roflroflrofl /=====\\");
//        }
//    }

//    if (six == clearingPoint)
//    {
//        break;
//    }

//    // Decrease dot and dash positions
//    one--;
//    two--;
//    three--;
//    four--;
//    five--;
//    six--;

//    // Pause between steps
//    Thread.Sleep(sleepDuration);

//    // accelerate ascend
//    if (sleepDuration > 26)
//    {
//        sleepDuration -= 25;
//    }
//    else
//    {
//        sleepDuration = 10;
//    }
//}


//// continue with program
//Console.SetCursorPosition(0, 54);
//Console.Write(new string(' ', Console.WindowWidth));

//Console.SetCursorPosition(0, 24);
//Thread.Sleep(100);
//Console.Write("Computer Choose:\n");
//Thread.Sleep(100); // 500
//Console.Write(". ");
//Thread.Sleep(100);
//Console.Write(". ");
//Thread.Sleep(100);
//Console.WriteLine(".");
//Thread.Sleep(100);
//Console.WriteLine($"{computerChoiceIcon}");