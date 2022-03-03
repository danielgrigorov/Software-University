using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double average = list.Sum() / list.Count;

            List<int> resultList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > average)
                {
                    resultList.Add(list[i]);
                }
            }

            if (resultList.Count == 0)
            {
                Console.WriteLine("No");
            }

            else if (resultList.Count <= 5)
            {
                resultList.Sort();
                resultList.Reverse();
                Console.WriteLine(string.Join(" ", resultList));
            }

            else if (resultList.Count > 5)
            {
                resultList.Sort();
                resultList.Reverse();

                List<int> bigList = new List<int>();

                for (int i = 0; i < 5; i++)
                {
                    bigList.Add(resultList[i]);
                }

                Console.WriteLine(string.Join(" ", bigList));
            }

            

        }
    }
}
