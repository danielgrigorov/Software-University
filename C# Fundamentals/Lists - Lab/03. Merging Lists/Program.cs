using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> resultList = new List<int>();

            if (list1.Count > list2.Count)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    resultList.Add(list1[i]);

                    if (i <= list2.Count - 1)
                    {
                        resultList.Add(list2[i]);

                    }
                }

            }
            else
            {
                for (int i = 0; i < list2.Count; i++)
                {

                    if (i <= list1.Count -1)
                    {
                        resultList.Add(list1[i]);


                    }
                    resultList.Add(list2[i]);

                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
