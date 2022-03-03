using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                StringBuilder newMessage = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    char currentLetter = (char)(input[i] - n);
                    newMessage.Append(currentLetter);
                }

                string pattern1 = @"@(?<kidName>[A-Za-z]+)[^@\-!:>]*!(?<behaviour>G)!";

                if (Regex.IsMatch(newMessage.ToString(), pattern1))
                {
                    MatchCollection collection = Regex.Matches(newMessage.ToString(), pattern1);

                    foreach (Match item in collection)
                    {
                        Console.WriteLine(item.Groups["kidName"].Value);
                    }
                }


            }
        }
    }
}
