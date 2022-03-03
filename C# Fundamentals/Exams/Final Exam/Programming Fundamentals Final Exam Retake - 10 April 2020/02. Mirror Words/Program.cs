using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            string pattern = @"(#|@)(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";

            MatchCollection collection = Regex.Matches(line, pattern);

            var list = new List<string>();

            if (collection.Count == 0)
            {
                Console.WriteLine($"No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{collection.Count} word pairs found!");
            }

            string current = string.Empty;
            string kon = string.Empty;
            string kobila = string.Empty;

            foreach (Match item in collection)
            {
                current = item.Groups["firstWord"].Value;

                StringBuilder pacha = new StringBuilder();

                for (int i = current.Length - 1; i >= 0; i--)
                {
                    pacha.Append(current[i]);
                }

                if (item.Groups["secondWord"].Value == pacha.ToString())
                {
                    string huinq = current + " <=> " + pacha;
                    list.Add(huinq);

                    kon = current;
                    kobila = pacha.ToString();
                }
            }

            if (list.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");

                    Console.WriteLine(string.Join(", ", list));
            }
        }
    }
}
