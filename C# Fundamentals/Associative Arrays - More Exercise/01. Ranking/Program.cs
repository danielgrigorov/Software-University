using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestDict = new Dictionary<string, string>();

            var pointsDict = new SortedDictionary<string, Dictionary<string, int>>();

            string contest = string.Empty;
            string password = string.Empty;

            string contestTry = string.Empty;
            string passwordTry = string.Empty;
            string userName = string.Empty;
            int points = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }

                string[] token = input.Split(":");

                contest = token[0];
                password = token[1];

                contestDict[contest] = password;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of submissions")
                {
                    break;
                }

                string[] token = input.Split("=>");

                contestTry = token[0];
                passwordTry = token[1];
                userName = token[2];
                points = int.Parse(token[3]);

                if (contestDict.ContainsKey(contestTry))
                {
                    if (contestDict[contestTry] == passwordTry)
                    {
                        if (!pointsDict.ContainsKey(userName))
                        {
                            pointsDict[userName] = new Dictionary<string, int>();
                        }

                        if (pointsDict[userName].ContainsKey(contestTry))
                        {
                            if (pointsDict[userName][contestTry] < points)
                            {
                                pointsDict[userName].Remove(contestTry);
                            }
                            else
                            {
                                continue;
                            }
                        }
                       
                        pointsDict[userName].Add(contestTry, points);
                    }
                }
            }

            var pointsDict2 = pointsDict.OrderByDescending(x => x.Value.Values.Sum())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in pointsDict2)
            {
                Console.WriteLine($"Best candidate is {item.Key} with total {item.Value.Values.Sum()} points.");
                break;
            }

            Console.WriteLine("Ranking: ");

            foreach (var item in pointsDict)
            {
                Console.WriteLine(item.Key);

                foreach (var item2 in pointsDict[item.Key].OrderByDescending(x =>x.Value))
                {
                    Console.WriteLine($"#  {item2.Key} -> {item2.Value}");
                }
            }
        }
    }
}
