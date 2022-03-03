using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> player2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            for (int i = 0; 0 < Math.Min(player1.Count, player2.Count); i++)
            {
                
                    if (player1[0] > player2[0])
                    {
                        player1.Add(player1[0]);
                        player1.Add(player2[0]);
                        player1.RemoveAt(0);
                        player2.RemoveAt(0);
                    }
                    else if (player2[0] > player1[0])
                    {
                        player2.Add(player2[0]);
                        player2.Add(player1[0]);
                        player2.RemoveAt(0);
                        player1.RemoveAt(0);
                    }
                    else if (player1[0] == player2[0])
                    {
                        player1.RemoveAt(0);
                        player2.RemoveAt(0);
                    }
            }
            if (player1.Count == 0)
            {
                for (int j = 0; j < player2.Count; j++)
                {
                    sum += player2[j];
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");

            }
            else if (player2.Count == 0)
            {
                for (int k = 0; k < player1.Count; k++)
                {
                    sum += player1[k];

                }
                Console.WriteLine($"First player wins! Sum: {sum}");

            }
        }
    }
}
