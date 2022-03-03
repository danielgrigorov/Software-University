using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string commmand = Console.ReadLine();

                if (commmand == "end")
                {
                    break;
                }

                string[] token = commmand.Split();

                if (token[0] == "Add")
                {
                    list.Add(int.Parse(token[1]));
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (int.Parse(token[0]) + list[i] <= maxCapacity)
                        {
                            list[i] += int.Parse(token[0]);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join (" ", list));
        }
    }
}
