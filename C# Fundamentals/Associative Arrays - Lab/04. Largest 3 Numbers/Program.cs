using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numbersDict = new SortedDictionary<int, int>();

            foreach (var number in numbers)
            {
                numbersDict[number] = 0;
            }

                var result = numbersDict.Keys.TakeLast(3).ToArray().Reverse();
                Console.WriteLine(string.Join(" ", result));
        }
    }
}
