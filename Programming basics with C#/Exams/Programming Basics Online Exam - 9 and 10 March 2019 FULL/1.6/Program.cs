using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournament = Console.ReadLine();

            int gamesPlayed = 0;
            int gamesWon = 0;
            int gamesLost = 0;

            while (tournament != "End of tournaments")
            {
                int n = int.Parse(Console.ReadLine());


                for (int i = 1; i <= n; i++)
                {
                    int scoreDesiTeam = int.Parse(Console.ReadLine());
                    int scoreRivalryTeam = int.Parse(Console.ReadLine());

                    if (scoreDesiTeam > scoreRivalryTeam)
                    {
                        gamesWon++;
                        Console.WriteLine($"Game {i} of tournament {tournament}: win with {scoreDesiTeam - scoreRivalryTeam} points.");
                    }
                    else
                    {
                        gamesLost++;
                        Console.WriteLine($"Game {i} of tournament {tournament}: lost with {scoreRivalryTeam - scoreDesiTeam} points.");
                    }

                    gamesPlayed++;
                }
                tournament = Console.ReadLine();

            }
            Console.WriteLine($"{gamesWon * 1.0 / gamesPlayed * 100:f2}% matches win");
            Console.WriteLine($"{gamesLost * 1.0 / gamesPlayed * 100:f2}% matches lost");
        }
    }
}
