using System;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();

            double successfulCounter = 0;
            double notSuccessfulCounter = 0;
            double points = 301;
            bool reachedZero = false;

            string input = Console.ReadLine();

            while (input != "Retire")
            {
                double currentPoints = double.Parse(Console.ReadLine());

                if (input == "Single" && points >= currentPoints)
                {
                    points -= currentPoints;
                    successfulCounter++;
                }
                else if (input == "Double" && points >= currentPoints * 2)
                {
                    points -= currentPoints * 2;
                    successfulCounter++;

                }
                else if (input == "Triple" && points >= currentPoints *3)
                {
                    points -= currentPoints * 3;
                    successfulCounter++;

                }
                else
                {
                    notSuccessfulCounter++;
                }

                if (points == 0)
                {
                    Console.WriteLine($"{playerName} won the leg with {successfulCounter} shots.");
                    reachedZero = true;
                }

                input = Console.ReadLine();
            }
            if (!reachedZero)
            {
                Console.WriteLine($"{playerName} retired after {notSuccessfulCounter} unsuccessful shots.");
            }
        }
    }
}
