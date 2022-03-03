using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bought furniture:");

            double sum = 0;

            while (true)
            {
                string current = Console.ReadLine();

                if (current == "Purchase")
                {
                    break;
                }

                var pattern = @">>(?<product>[A-Za-z]+)<<(?<price>[\d]+\.[\d]+|[\d]+)!(?<quantity>\d+)";

                MatchCollection collection = Regex.Matches(current, pattern);

                foreach (Match item in collection)
                {
                    string product = item.Groups["product"].Value;
                    double currentPrice = double.Parse(item.Groups["price"].Value) * double.Parse(item.Groups["quantity"].Value);

                    Console.WriteLine(product);
                    sum += currentPrice;
                }
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
