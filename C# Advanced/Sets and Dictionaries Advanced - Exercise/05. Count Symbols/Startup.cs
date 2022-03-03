using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Startup
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var dict = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dict.ContainsKey(input[i]))
                {
                    dict[input[i]] = 0;
                }

                dict[input[i]]++;
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

            //var kon = new List<string>();

            //kon.Add("pipi");
            //kon.Add("dobrin");

            //kon = kon.OrderBy(x=>x).ToList();

            //foreach (var item in kon)
            //{
            //    Console.WriteLine(item);
            //}


        }
    }
}
