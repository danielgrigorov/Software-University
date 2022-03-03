using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());

            var list = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] %n != 0)
                {
                    list.Add(input[i]);
                }
            }

            list.Reverse();

            Console.WriteLine(string.Join(" ",list));
        }
    }
}
