using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._The_V_Logger__not_included_in_final_score_
{
    class Startup
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            while (true)
            {
                var current = Console.ReadLine().Split();

                string command = current[0];
                
                if (command == "Statistics")
                {
                    break;
                }

                string decision = current[1];
                string winner = current[2];

                 if (decision == "joined")
                {
                    if (!dict.ContainsKey(command))
                    {
                        dict[command] = new Dictionary<string, List<string>>();
                        dict[command]["followers"] = new List<string>();
                        dict[command]["following"] = new List<string>();
                    }
                }
                else if (decision == "followed")
                {
                    if (dict.ContainsKey(command) && dict.ContainsKey(winner) && command != winner)
                    {
                        if (!dict[winner]["followers"].Contains(command))
                        {
                            dict[winner]["followers"].Add(command);
                            dict[command]["following"].Add(winner);
                        }
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {dict.Count} vloggers in its logs.");

            dict = dict.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x=>x.Value["following"].Count).ToDictionary(x=>x.Key,x=>x.Value);

            

            foreach (var item in dict)
            {
                Console.WriteLine($"1. {item.Key} : {item.Value["followers"].Count()} followers, {item.Value["following"].Count} following");

                item.Value["followers"] = item.Value["followers"].OrderBy(x => x).ToList();

                foreach (var item2 in item.Value["followers"])
                {
                    Console.WriteLine($"*  {item2}");
                }

                dict.Remove(item.Key);
                break;
            }


            dict = dict.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x=>x.Value["following"].Count).ToDictionary(x => x.Key, x => x.Value);

            int kon = 2;

            foreach (var item in dict)
            {
                Console.WriteLine($"{kon}. {item.Key} : {item.Value["followers"].Count} followers, {item.Value["following"].Count} following");
                kon++;
            }
        }
    }
}
