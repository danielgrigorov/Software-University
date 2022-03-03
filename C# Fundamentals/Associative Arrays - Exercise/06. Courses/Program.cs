using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] token = command.Split(" : ");

                string courseName = token[0];
                string studentName = token[1];

                if (!dict.ContainsKey(courseName))
                {
                    dict.Add(courseName, new List<string>());
                }
                    dict[courseName].Add(studentName);

            }

            foreach (var item in dict.OrderByDescending(x =>x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var item2 in item.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {item2}");
                }
            }
        }
    }
}
