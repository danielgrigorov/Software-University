using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentName = Console.ReadLine();
                double currentGrade = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(currentName))
                {
                    dict[currentName] = new List<double>();
                }
                dict[currentName].Add(currentGrade);
            }

            foreach (var item in dict.OrderByDescending(x =>x.Value.Average()).Where(x =>x.Value.Average() >= 4.50))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }

        }
    }
}
