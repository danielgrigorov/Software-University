using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var result = new List<int>();

            var result2 = new List<int>();
            var result3 = new List<int>();

            int start = input[0];
            int final = input[1];

            for (int i = start; i <= final; i++)
            {
                result.Add(i);
            }

            string command = Console.ReadLine();

            if (command == "odd")
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] %2 == 1 || result[i] %2 == -1)
                    {
                        result2.Add(result[i]);
                    }
                }
                Console.WriteLine(string.Join(" ",result2));
            }
            else if (command == "even")
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] % 2 == 0 || result[i] % 2 == 0)
                    {
                        result3.Add(result[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", result3));
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
