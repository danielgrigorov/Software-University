using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            string splitpattern = @"\s*,\s*";

            string[] input = Regex.Split(Console.ReadLine(), splitpattern);

            var dict = new SortedDictionary<string, Dictionary<double, double>>();

            for (int i = 0; i < input.Length; i++)
            {
                var pattern = @"[^0-9+\-*\/.]";

                double currentHealth = 0;

                if (Regex.IsMatch(input[i], pattern))
                {
                    MatchCollection collection = Regex.Matches(input[i], pattern);

                    foreach (Match item in collection)
                    {
                        currentHealth += char.Parse(item.Value);
                    }
                }

                var pattern2 = @"[*\/]";

                double multiplicationsCount = 0;
                double divisionsCount = 0;

                var pattern4 = @"-?\d+\.?\d*";
                double currentDamage = 0;

                if (Regex.IsMatch(input[i], pattern4))
                {
                    MatchCollection collection4 = Regex.Matches(input[i], pattern4);

                    foreach (Match item in collection4)
                    {
                        currentDamage += double.Parse(item.Value);
                    }
                }

                MatchCollection collection2 = Regex.Matches(input[i], pattern2);

                foreach (Match item in collection2)
                {
                    if (item.Value == "*")
                    {
                        currentDamage *= 2;
                    }
                    else
                    {
                        currentDamage /= 2;
                    }
                }

                dict.Add(input[i], new Dictionary<double, double>());
                dict[input[i]].Add(currentHealth, currentDamage);
            }

            foreach (var item in dict)
            {
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"{item.Key} - {item2.Key} health, {item2.Value:f2} damage");
                }
            }
        }
    }
}
