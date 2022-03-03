using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Custom_Comparator__not_included_in_final_score_
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var list = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    list.Add(input[i]);
                }
            }

            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            var list2 = new List<int>();


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] %2 == 1 || input[i] %2 == -1)
                {
                    list2.Add(input[i]);
                }
            }

            list2.Sort();

            Console.WriteLine(string.Join(" ",list2));
        }
    }
}
