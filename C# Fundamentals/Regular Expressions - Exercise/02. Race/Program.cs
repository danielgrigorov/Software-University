using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ").ToList();

            var dict = new Dictionary<string, int>();

            while (true)
            {
                string current = Console.ReadLine();

                if (current == "end of race")
                {
                    break;
                }

                var pattern = @"[A-Za-z]+";

                MatchCollection collection = Regex.Matches(current, pattern);

                string currentRacer = string.Empty;

                foreach (Match item in collection)
                {
                    currentRacer += item.Value;
                }

                var pattern2 = @"\d";

                MatchCollection collection2 = Regex.Matches(current, pattern2);

                int currentRacerKm = 0;

                foreach (Match item in collection2)
                {
                    currentRacerKm += int.Parse(item.Value);
                }

                if (participants.Contains(currentRacer))
                {
                    if (!dict.ContainsKey(currentRacer))
                    {
                        dict.Add(currentRacer, currentRacerKm);
                    }
                    else
                    {
                        dict[currentRacer] += currentRacerKm;
                    }
                }
            }

            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            int kon = 1;

            foreach (var item in dict)
            {

                if (kon == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (kon == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else if (kon == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
                else
                {
                    break;
                }
                kon++;
            }
        }
    }
}
