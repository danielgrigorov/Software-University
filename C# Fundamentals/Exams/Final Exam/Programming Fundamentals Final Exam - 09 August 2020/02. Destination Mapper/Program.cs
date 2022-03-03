using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            string pattern = @"(=|\/)(?<destinationName>[A-Z][A-Za-z]{2,})\1";

            MatchCollection collection = Regex.Matches(line, pattern);

            var list = new List<string>();
            int sum = 0;

            foreach (Match item in collection)
            {
                list.Add(item.Groups["destinationName"].Value);
                sum += item.Groups["destinationName"].Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", list)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
