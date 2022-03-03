using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Same_Values_in_Array
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var dictionary = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dictionary.ContainsKey(input[i]))
                {
                    dictionary[input[i]] = 0;
                }

                dictionary[input[i]]++;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
