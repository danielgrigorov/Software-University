using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double tournaments = double.Parse(Console.ReadLine());
            double startingPoints = double.Parse(Console.ReadLine());
            string stageReached = Console.ReadLine();

            double wins = 0;
            double totalPoints = 0;

            for (int i = 0; i < tournaments; i++)
            {
                if (stageReached == "W")
                {
                    startingPoints += 2000;
                    wins++;
                    totalPoints += 2000;
                }
                else if (stageReached == "F")
                {
                    startingPoints += 1200;
                    totalPoints += 1200;
                }
                else if (stageReached == "SF")
                {
                    startingPoints += 720;
                    totalPoints += 720;
                }
                stageReached = Console.ReadLine();
            }
            Console.WriteLine($"Final points: {startingPoints}");
            Console.WriteLine($"Average points: {Math.Floor(totalPoints/tournaments)}");
            Console.WriteLine($"{(wins/tournaments) * 100:f2}%");
        }
    }
}
