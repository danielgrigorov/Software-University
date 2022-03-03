using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var attackedList = new List<string>();
            var destroyedList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();

                var pattern = @"S|s|T|t|A|a|R|r";

                int currentEnigma = 0;

                MatchCollection collection = Regex.Matches(current, pattern);

                foreach (Match item in collection)
                {
                    currentEnigma++;
                }

                string encryptedCurrent = string.Empty;

                for (int j = 0; j < current.Length; j++)
                {
                    encryptedCurrent += (char)(current[j] - currentEnigma);
                }

                var pattern2 = @"@(?<planetName>[A-Za-z]+)([^\@\-\!:>]*)?:(?<population>\d+)([^\@\-\!:>]*)!(?<attackType>A|D)!([^\@\-\!:>]*)->(?<soldiersCount>\d+)";

                MatchCollection collection2 = Regex.Matches(encryptedCurrent, pattern2);

                foreach (Match item in collection2)
                {
                    var planetName = item.Groups["planetName"].Value;
                    var planetType = item.Groups["attackType"].Value;

                    if (planetType == "A")
                    {
                        attackedList.Add(planetName);
                    }
                    else
                    {
                        destroyedList.Add(planetName);
                    }
                }

                attackedList.Sort();
                destroyedList.Sort();
            }

            Console.WriteLine($"Attacked planets: {attackedList.Count}");

            foreach (var item in attackedList)
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedList.Count}");

            foreach (var item in destroyedList)
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
