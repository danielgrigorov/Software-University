using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            var dictTotalPoints = new Dictionary<string, int>();

            string userName = string.Empty;
            string contest = string.Empty;
            int points = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "no more time")
                {
                    break;
                }

                string[] token = input.Split(" -> ");

                userName = token[0];
                contest = token[1];
                points = int.Parse(token[2]);

                if (!dict.ContainsKey(contest))
                {
                    dict[contest] = new Dictionary<string, int>();
                }
                if (dict[contest].ContainsKey(userName))
                {
                    if (dict[contest][userName] < points)
                    {
                        dictTotalPoints[userName] -= dict[contest][userName];

                        dict[contest][userName] = points;

                            dictTotalPoints[userName] += points;
                    }
                }
                else
                {
                    dict[contest].Add(userName, points);

                    if (dictTotalPoints.ContainsKey(userName))
                    {
                        dictTotalPoints[userName] += points;
                    }
                    else
                    {
                        dictTotalPoints[userName] = 0;
                        dictTotalPoints[userName] += points;
                    }
                }

            }

            //dict = dict.OrderByDescending(x =>x.Value.Values).ThenBy(x =>x.Value.Keys).ToDictionary(x =>x.Key, x=>x.Value);

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Count} participants");

                int position = 1;

                foreach (var item2 in dict[item.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{position}. {item2.Key} <::> {item2.Value}");
                    position++;
                }
            }

            Console.WriteLine("Individual standings:");

            int poistionIvan = 1;

            foreach (var item in dictTotalPoints.OrderByDescending(x =>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{poistionIvan}. {item.Key} -> {item.Value}");

                poistionIvan++;
            }

        }
    }
}
