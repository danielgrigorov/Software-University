using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Sets_of_Elements
{
    class Startup
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split();

            var setN = new HashSet<int>();
            var setM = new HashSet<int>();

            int n = int.Parse(numbers[0]);
            int m = int.Parse(numbers[1]);

            for (int i = 0; i < n; i++)
            {
                setN.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                setM.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in setN)
            {
                if (setM.Contains(item))
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
