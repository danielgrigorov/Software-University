using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();

            int pointsFirstPlayer = 0;
            int pointsSecondPlayer = 0;

            string input = Console.ReadLine();

            bool voina = false;

            while (input != "End of game")
            {
                int cardFirstPlayer = int.Parse(input);
                int cardSecondPlayer = int.Parse(Console.ReadLine());

                if (cardFirstPlayer > cardSecondPlayer)
                {
                    pointsFirstPlayer += cardFirstPlayer - cardSecondPlayer;
                }
                else if (cardSecondPlayer > cardFirstPlayer)
                {
                    pointsSecondPlayer += cardSecondPlayer - cardFirstPlayer;
                }
                else if (cardFirstPlayer == cardSecondPlayer)
                {
                    Console.WriteLine("Number wars!");
                    int voinaCardFirstPlayer = int.Parse(Console.ReadLine());
                    int voinaCardSecondPlayer = int.Parse(Console.ReadLine());

                    if (voinaCardFirstPlayer > voinaCardSecondPlayer)
                    {
                        Console.WriteLine($"{firstPlayer} is winner with {pointsFirstPlayer} points");
                    }
                    else
                    {
                        Console.WriteLine($"{secondPlayer} is winner with {pointsSecondPlayer} points");
                    }
                    voina = true;
                    break;
                }

                input = Console.ReadLine();
            }
            if (!voina)
            {
                Console.WriteLine($"{firstPlayer} has {pointsFirstPlayer} points");
                Console.WriteLine($"{secondPlayer} has {pointsSecondPlayer} points");
            }
        }
    }
}
