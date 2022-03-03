using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] token = command.Split();

                if (token.Length == 2)
                {
                    list.RemoveAll(x => x == int.Parse(token[1]));
                }
                else
                {
                    list.Insert(int.Parse(token[2]), int.Parse(token[1]));
                }
            }
            Console.WriteLine(string.Join (" ", list));
        }
    }
}
