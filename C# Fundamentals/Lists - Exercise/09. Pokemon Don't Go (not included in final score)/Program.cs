using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            int currentNumber = 0;

            while (list.Count > 0)
            {
                int currentIndex = int.Parse(Console.ReadLine());

                if (currentIndex < 0)
                {
                    currentNumber = list[0];
                    list.RemoveAt(0);
                    list.Insert(0, list[list.Count - 1]);
                    sum += currentNumber;
                }
                else if (currentIndex > list.Count-1)
                {
                    currentNumber = list[list.Count - 1];
                    list.RemoveAt(list.Count - 1);
                    list.Insert(list.Count, list[0]);
                    sum += currentNumber;

                }
                else
                {
                    currentNumber = list[currentIndex];
                    list.RemoveAt(currentIndex);
                    sum += currentNumber;
                }


                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] <= currentNumber)
                    {
                        list[i] += currentNumber;
                    }
                    else if (list[i] > currentNumber)
                    {
                        list[i] -= currentNumber;
                    }
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
