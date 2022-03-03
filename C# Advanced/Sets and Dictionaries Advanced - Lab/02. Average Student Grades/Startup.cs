using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Average_Student_Grades
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                var current = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string currentStudent = current[0];
                decimal currentGrade = decimal.Parse(current[1]);

                if (!dictionary.ContainsKey(currentStudent))
                {
                    dictionary[currentStudent] = new List<decimal>();
                }
                dictionary[currentStudent].Add(currentGrade);
            }

            foreach (var item in dictionary)
            {
                Console.Write($"{item.Key} -> ");

                foreach (var item2 in item.Value)
                {
                    Console.Write($"{item2:f2} ");
                }
                Console.WriteLine($"(avg: {item.Value.Average():f2})");

            }
        }
    }
}
