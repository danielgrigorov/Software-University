using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>(input);

            var result = new List<int>();

            foreach (var item in queue)
            {
                if (item %2 == 0)
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
