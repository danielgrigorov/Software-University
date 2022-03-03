using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int currentNumber = 0;

            int counter = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                int currentIndex = int.Parse(command);


                if (currentIndex < 0 || currentIndex > list.Count-1)
                {
                    continue;
                }

                currentNumber = list[currentIndex];


                for (int i = 0; i < list.Count; i++)
                {
                    if (i == currentIndex)
                    {
                        list[currentIndex] = -1;
                        continue;
                    }

                    else if (list[i] > currentNumber && list[i] != -1)
                    {
                        list[i] -= currentNumber;
                    }

                    else if (list[i] <= currentNumber && list[i] != -1)
                    {
                        list[i] += currentNumber;
                    }
                }
                counter++;
            }
            Console.Write($"Shot targets: {counter} -> ");
            Console.Write(string.Join(" ", list));
        }
    }
}
