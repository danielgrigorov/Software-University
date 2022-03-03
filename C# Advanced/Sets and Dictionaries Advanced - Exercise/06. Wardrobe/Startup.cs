using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var current = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string currentColor = current[0];

                var items = current[1].Split(",");

                for (int j = 0; j < items.Length; j++)
                {
                    if (!dict.ContainsKey(currentColor))
                    {
                        dict[currentColor] = new Dictionary<string, int>();
                    }



                    if (!dict[currentColor].ContainsKey(items[j]))
                    {
                        dict[currentColor][items[j]] = 0;
                    }


                    dict[currentColor][items[j]]++;
                }
            }

            var result = Console.ReadLine().Split();

            string resultColor = result[0];
            string resultItem = result[1];

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var item2 in item.Value)
                {
                    if (resultColor == item.Key && resultItem == item2.Key)
                    {
                        Console.WriteLine($"* {item2.Key} - {item2.Value} (found!)");
                    }

                    else
                    {
                        Console.WriteLine($"* {item2.Key} - {item2.Value}");
                    }
                }
            }
        }
    }
}
