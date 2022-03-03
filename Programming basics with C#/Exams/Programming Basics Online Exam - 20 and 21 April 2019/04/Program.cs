using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int startAmount = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            bool enoughEggs = true;

            int soldEggs = 0;

            while (command != "Close")
            {
                int currentAmount = int.Parse(Console.ReadLine());

                if (command == "Buy" && startAmount < currentAmount)
                {
                    Console.WriteLine("Not enough eggs in store!");
                    Console.WriteLine($"You can buy only {startAmount}.");
                    enoughEggs = false;
                    break;
                }
                if (command == "Buy")
                {
                    startAmount -= currentAmount;
                    soldEggs += currentAmount;
                }
                else if (command == "Fill")
                {
                    startAmount += currentAmount;
                }

               
                command = Console.ReadLine();
            }
            if (enoughEggs)
            {
                Console.WriteLine($"Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
            }

        }
    }
}
