using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();

                string pattern = @"^(\$|\%)(?<name>[A-Z][a-z]{2,})\1: \[(?<first>\d+)\]\|\[(?<second>\d+)\]\|\[(?<third>\d+)\]\|$";

                if (!Regex.IsMatch(current, pattern))
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    MatchCollection collection = Regex.Matches(current, pattern);

                    foreach (Match item in collection)
                    {
                        int first = int.Parse(item.Groups["first"].Value.ToString());
                        char firstLetterASCII = (char)first;

                        int second = int.Parse(item.Groups["second"].Value.ToString());
                        char secondLetterASCII = (char)second;

                        int third = int.Parse(item.Groups["third"].Value.ToString());
                        char thirdLetterASCII = (char)third;

                        Console.WriteLine($"{item.Groups["name"]}: {firstLetterASCII}{secondLetterASCII}{thirdLetterASCII}");
                    }
                }
            }
        }
    }
}
