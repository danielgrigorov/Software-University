using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\+[359]+(\s|-)2\1[\d]{3}\1[\d]{4}\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

                Console.WriteLine(string.Join (", ", matches));
        }
    }
}
