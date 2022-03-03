using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Ranking__not_included_in_final_score_
{
    class Startup
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            var dict2 = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var current = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);

                string command = current[0];

                if (command == "end of contests")
                {
                    break;
                }

                string password = current[1];

                dict[command] = password;
            }

            while (true)
            {
                var current = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string commandTry = current[0];

                if (commandTry == "end of submissions")
                {
                    break;
                }

                string passwordTry = current[1];
                string username = current[2];
                int points = int.Parse(current[3]);

                if (dict.ContainsKey(commandTry))
                {
                    if (dict[commandTry] == passwordTry)
                    {
                        if (!dict2.ContainsKey(username))
                        {
                            dict2[username] = new Dictionary<string, int>();
                        }


                        if (dict2.ContainsKey(username))
                        {
                            if (dict2[username].ContainsKey(commandTry))
                            {
                                if (dict2[username][commandTry] < points)
                                {
                                    dict2[username][commandTry] = points;
                                }
                            }
                            else
                            {
                                dict2[username][commandTry] = points;
                            }
                        }
                        else
                        {
                            dict2[username][commandTry] = points;
                        }

                    }
                }
            }

            int bestPoints = 0;
            string bestStudent = string.Empty;

            foreach (var item in dict2)
            {
                int currentSum = 0;

                foreach (var item2 in item.Value)
                {
                    currentSum += item2.Value;
                }

                if (currentSum > bestPoints)
                {
                    bestPoints = currentSum;
                    bestStudent = item.Key;
                }

            }

            Console.WriteLine($"Best candidate is {bestStudent} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");

            dict2 = dict2.OrderBy(x=>x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in dict2)
            {
                Console.WriteLine($"{item.Key}");

                foreach (var item2 in item.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {item2.Key} -> {item2.Value}");
                }
            }
        }
    }
}
