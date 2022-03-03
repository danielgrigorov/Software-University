using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var set = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var current = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < current.Length; j++)
                {
                    set.Add(current[j]);
                }
            }

            Console.WriteLine(string.Join(" ", set));
        }
    }
}
