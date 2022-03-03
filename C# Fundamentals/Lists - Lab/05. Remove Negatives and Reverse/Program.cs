using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> newList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                {
                    newList.Add(list[i]);
                }
            }
            newList.Reverse();

            if (newList.Count <= 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", newList));

            }
        }
    }
}
