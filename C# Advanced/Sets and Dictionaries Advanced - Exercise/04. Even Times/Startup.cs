using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(current))
                {
                    dict[current] = 0;
                }

                dict[current]++;
            }

            foreach (var item in dict)
            {
                if (item.Value %2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
