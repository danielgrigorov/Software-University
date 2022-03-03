using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            while (true)
            {
                string current = Console.ReadLine();

                if (current == "end of shift")
                {
                    break;
                }

                var pattern = @"%(?<name>[A-Z][a-z]+)%([^\|\$\.%\d]*)?<(?<product>\w+)>([^\|\$\.%\d]*)?\|(?<count>\d+)\|([^\|\$\.%\d]*)?(?<price>\d+|\d+.\d+)\$";

                MatchCollection collection = Regex.Matches(current, pattern);

                foreach (Match item in collection)
                {
                    string name = item.Groups["name"].Value;
                    string prodcut = item.Groups["product"].Value;
                    double count = double.Parse(item.Groups["count"].Value);
                    double price = double.Parse(item.Groups["price"].Value);
                    Console.WriteLine($"{name}: {prodcut} - {count*price:f2}");
                    sum += count * price;
                }
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
