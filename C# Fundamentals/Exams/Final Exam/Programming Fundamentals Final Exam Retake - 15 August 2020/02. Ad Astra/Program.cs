using System;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            BigInteger totalCalories = 0;

            string pattern = @"(\||#)(?<name>[A-Za-z]+\s?[A-Za-z]+)\1(?<date>03|06|01|02|04|05|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31)\/(?<month>01|02|03|04|05|06|07|08|09|10|11|12)\/(?<year>\d{2})\1(?<calories>[\d]{1,4}|10000)\1";

            MatchCollection collection = Regex.Matches(input, pattern);

            foreach (Match item in collection)
            {
                totalCalories += int.Parse(item.Groups["calories"].Value);
            }

            Console.WriteLine($"You have food to last you for: {totalCalories/2000} days!");

            if (collection.Count >0)
            {
                foreach (Match item in collection)
                {
                    Console.WriteLine($"Item: {item.Groups["name"].Value}, Best before: {$"{item.Groups["date"].Value}/{item.Groups["month"].Value}/{item.Groups["year"].Value}"}, Nutrition: {item.Groups["calories"].Value}");
                }
            }
            
           
        }
    }
}
