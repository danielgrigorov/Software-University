using System;

namespace _04._Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerEggs = int.Parse(Console.ReadLine());
            int secondPlayerEggs = int.Parse(Console.ReadLine());

            string result = Console.ReadLine();

            bool endOfBattle = false;

            while (result != "End of battle")
            {
                if (result == "one")
                {
                    secondPlayerEggs--;
                }
                else if (result == "two")
                {
                    firstPlayerEggs--;
                }

                if (firstPlayerEggs == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left.");
                    endOfBattle = true;
                    break;
                }
                else if (secondPlayerEggs == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggs} eggs left.");
                    endOfBattle = true;
                    break;
                }

                result = Console.ReadLine();
            }

            if (!endOfBattle)
            {
                Console.WriteLine($"Player one has {firstPlayerEggs} eggs left.");
                Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
            }
        }
    }
}
