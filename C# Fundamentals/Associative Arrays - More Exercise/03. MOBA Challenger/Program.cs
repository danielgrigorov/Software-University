using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            string player = string.Empty;
            string position = string.Empty;
            int skill = 0;

            string player1 = string.Empty;
            string player2 = string.Empty;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Season end")
                {
                    break;
                }

                if (input.Contains("->"))
                {
                    string[] token = input.Split(" -> ");

                    player = token[0];
                    position = token[1];
                    skill = int.Parse(token[2]);

                    if (!dict.ContainsKey(player))
                    {
                        dict[player] = new Dictionary<string, int>();
                        dict[player].Add(position, skill);
                    }
                    else
                    {
                        if (!dict[player].ContainsKey(position))
                        {
                            dict[player].Add(position, skill);
                        }
                        else
                        {
                            if (dict[player][position] < skill)
                            {
                                dict[player][position] = skill;
                            }
                        }
                    }
                }

                else
                {
                    string[] token = input.Split(" vs ");

                    player1 = token[0];
                    player2 = token[1];

                    bool hasDuel = false;

                    if (dict.ContainsKey(player1) && dict.ContainsKey(player2))
                    {
                        foreach (var item in dict[player1])
                        {
                            foreach (var item2 in dict[player2])
                            {
                                if (item.Key == item2.Key)
                                {
                                    hasDuel = true;
                                    break;
                                }
                            }
                            if (hasDuel)
                            {
                                break;
                            }
                        }

                        if (hasDuel)
                        {
                            if (dict[player1].Values.Sum() > dict[player2].Values.Sum())
                            {
                                dict.Remove(player2);
                            }
                            else if (dict[player1].Values.Sum() < dict[player2].Values.Sum())
                            {
                                dict.Remove(player1);
                            }
                        }

                    }
                }
            }

            foreach (var item in dict.OrderByDescending(x =>x.Value.Values.Sum()).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()} skill");

                foreach (var item2 in dict[item.Key].OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"- {item2.Key} <::> {item2.Value}");
                }
            }
        }
    }
}
