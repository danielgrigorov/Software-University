using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var current = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string currentName = current[0];
                int currentAge = int.Parse(current[1]);

                dict[currentName] = currentAge;
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            if (condition == "older")
            {
                dict = dict.Where(x => x.Value >= age).ToDictionary(x=>x.Key, x=>x.Value);
            }
            else if (condition == "younger")
            {
                dict = dict.Where(x => x.Value <= age).ToDictionary(x => x.Key, x => x.Value);

            }

            if (format == "name")
            {
                foreach (var item in dict)
                {
                    Console.WriteLine(item.Key);
                }
            }

            else if (format == "age")
            {
                foreach (var item in dict)
                {
                    Console.WriteLine(item.Value);
                }
            }

            else if (format == "name age")
            {
                foreach (var item in dict)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
