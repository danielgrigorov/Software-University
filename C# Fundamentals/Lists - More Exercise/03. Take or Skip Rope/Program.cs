using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Take_or_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToList();

            List<int> resultList = new List<int>();

            List<int> constrainsList = new List<int>();

            List<int> finalList = new List<int>();

            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }
            if (firstList.Count > secondList.Count)
            {
                constrainsList.Add(firstList[firstList.Count - 1]);
                constrainsList.Add(firstList[firstList.Count - 2]);
            }
            else if (secondList.Count > firstList.Count)
            {
                constrainsList.Add(secondList[secondList.Count - 1]);
                constrainsList.Add(secondList[secondList.Count - 2]);
            }

            constrainsList.Sort();

            for (int i = 0; i < resultList.Count; i++)
            {
                if (constrainsList[0] < resultList[i] && constrainsList[1] > resultList[i])
                {
                    finalList.Add(resultList[i]);
                }
            }

            finalList.Sort();

            Console.WriteLine(string.Join (" ", finalList));
        }
    }
}
