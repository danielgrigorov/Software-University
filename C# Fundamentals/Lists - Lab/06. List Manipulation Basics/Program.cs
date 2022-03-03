using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            while (true)
            {
            string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();

                if (tokens[0] == "Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                }
                else if (tokens[0] == "Remove")
                {
                    numbers.Remove(int.Parse(tokens[1]));
                }
                else if (tokens[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(tokens[1]));
                }
                else if (tokens[0] == "Insert")
                {
                    numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
