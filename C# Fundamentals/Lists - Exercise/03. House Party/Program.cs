using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                string[] token = command.Split();

                if (token.Length == 3)
                {
                    if (list.Contains(token[0]))
                    {
                        Console.WriteLine($"{token[0]} is already in the list!");
                    }
                    else
                    {
                        list.Add(token[0]);
                    }
                }
                else if (token.Length == 4)
                {
                    if (list.Contains(token[0]))
                    {
                        list.Remove(token[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{token[0]} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
