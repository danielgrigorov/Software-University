using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var current = Console.ReadLine().Split();

                string continent = current[0];
                string coiuntry = current[1];
                string city = current[2];

                if (!dict.ContainsKey(continent))
                {
                    dict[continent] = new Dictionary<string, List<string>>();

                    if (!dict[continent].ContainsKey(coiuntry))
                    {
                        dict[continent][coiuntry] = new List<string>();
                    }
                    dict[continent][coiuntry].Add(city);
                }

                else
                {
                    if (!dict[continent].ContainsKey(coiuntry))
                    {
                        dict[continent][coiuntry] = new List<string>();
                    }
                        dict[continent][coiuntry].Add(city);
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"{item2.Key} -> {string.Join(", ", item2.Value)}");
                }
            }
        }
    }
}
