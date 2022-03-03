using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Easter_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();

                string[] token = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = token[0];
                string firstCommand = token[1];
                int secondCommand = 0;

                if (token.Length == 3)
                {
                    secondCommand = int.Parse(token[2]);
                }

                if (action == "Include")
                {
                    list.Add(firstCommand);
                }

                else if (action == "Visit" && secondCommand <= list.Count && secondCommand >= 0)
                {
                    if (firstCommand == "first")
                    {
                        for (int j = 0; j < secondCommand; j++)
                        {
                            list.RemoveAt(0);
                        }
                    }
                    else if (firstCommand == "last")
                    {
                        for (int k = 0; k < secondCommand; k++)
                        {
                            list.RemoveAt(list.Count - 1);
                        }
                    }
                }

                else if (action == "Prefer" && int.Parse(firstCommand) >= 0 && list.Count > int.Parse(firstCommand) && secondCommand >= 0 && list.Count > secondCommand)
                {
                    string firstShop = list[int.Parse(firstCommand)];
                    string secondShop = list[secondCommand];

                    list[int.Parse(firstCommand)] = secondShop;
                    list[secondCommand] = firstShop;
                }

                else if (action == "Place" && list.Count > secondCommand + 1 && secondCommand >= -1)
                {
                    list.Insert(secondCommand + 1, firstCommand);
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", list));
        }
    }
}