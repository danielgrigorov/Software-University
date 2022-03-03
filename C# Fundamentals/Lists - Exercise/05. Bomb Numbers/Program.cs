using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int specialNumber = input[0];
            int power = input[1];
            int specialIndex = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (specialNumber == list[i])
                {
                    specialIndex = i;
                    for (int j = 0; j < power; j++)
                    {
                        if (i-1 >= 0)
                        {
                            list.RemoveAt(i - 1);
                            i--;
                        }
                        
                    }
                    for (int k = 0; k < power; k++)
                    {
                        if (i+1 <= list.Count-1)
                        {
                            list.RemoveAt(i + 1);

                        }
                    }
                }
            }
            list.RemoveAll(x => x == specialNumber);
            int sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
        }
    }
}
