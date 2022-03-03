using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] token = input.Split(" -> ");

                string companyName = token[0];
                string employeeId = token[1];

                if (!dict.ContainsKey(companyName))
                {
                    dict[companyName] = new List<string>();
                }
                if (!dict[companyName].Contains(employeeId))
                {
                    dict[companyName].Add(employeeId);
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key);

                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"-- {item2}");
                }
            }
        }
    }
}
