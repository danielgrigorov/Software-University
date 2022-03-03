using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstMatch = Console.ReadLine();
            string secondMatch = Console.ReadLine();
            string thirdMatch = Console.ReadLine();

            char firstMatch1 = firstMatch[0];
            char firstMatch2 = firstMatch[2];

            char secondMatch1 = secondMatch[0];
            char secondMatch2 = secondMatch[2];

            char thirdMatch1 = thirdMatch[0];
            char thirdMatch2 = thirdMatch[2];

            int winCounter = 0;
            int drawCounter = 0;
            int loseCounter = 0;

            if (firstMatch1 > firstMatch2)
            {
                winCounter++;
            }
            else if (firstMatch1 == firstMatch2)
            {
                drawCounter++;
            }
            else if (firstMatch1 < firstMatch2)
            {
                loseCounter++;
            }
            if (secondMatch1 > secondMatch2)
            {
                winCounter++;
            }
            else if (secondMatch1 == secondMatch2)
            {
                drawCounter++;
            }
            else if (secondMatch1 < secondMatch2)
            {
                loseCounter++;
            }
            if (thirdMatch1 > thirdMatch2)
            {
                winCounter++;
            }
            else if (thirdMatch1 == thirdMatch2)
            {
                drawCounter++;
            }
            else if (thirdMatch1 < thirdMatch2)
            {
                loseCounter++;
            }
            Console.WriteLine($"Team won {winCounter} games.");
            Console.WriteLine($"Team lost {loseCounter} games.");
            Console.WriteLine($"Drawn games: {drawCounter}");
        }
    }
}
