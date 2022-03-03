using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern1 = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";

            MatchCollection collection = Regex.Matches(input, pattern1);

            foreach (Match item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
