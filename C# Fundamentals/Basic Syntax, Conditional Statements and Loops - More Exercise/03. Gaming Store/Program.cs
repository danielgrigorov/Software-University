using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double totalSpent = 0;

            string currentGame = Console.ReadLine();

            while (currentGame != "Game Time")
            {
               
                
                if (currentGame == "OutFall 4")
                {

                    if (budget >= 39.99)
                    {
                        budget -= 39.99;
                        totalSpent += 39.99;
                        Console.WriteLine($"Bought {currentGame}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (currentGame == "CS: OG")
                {
                    if (budget >= 15.99)
                    {
                        budget -= 15.99;
                        totalSpent += 15.99;
                        Console.WriteLine($"Bought {currentGame}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (currentGame == "Zplinter Zell")
                {
                    if (budget >=19.99)
                    {
                        Console.WriteLine($"Bought {currentGame}");
                        totalSpent += 19.99;
                        budget -= 19.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (currentGame == "Honored 2")
                {
                    if (budget >= 59.99)
                    {
                        Console.WriteLine($"Bought {currentGame}");
                        totalSpent += 59.99;
                        budget -= 59.99;
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (currentGame == "RoverWatch")
                {
                    if (budget >= 29.99)
                    {
                        Console.WriteLine($"Bought {currentGame}");
                        totalSpent += 29.99;
                        budget -= 29.99;
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (currentGame == "RoverWatch Origins Edition")
                {
                    if (budget >= 39.99)
                    {
                        Console.WriteLine($"Bought {currentGame}");
                        totalSpent += 39.99;
                        budget -= 39.99;
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                    
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (budget == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                currentGame = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${budget:f2}");
        }
    }
}
