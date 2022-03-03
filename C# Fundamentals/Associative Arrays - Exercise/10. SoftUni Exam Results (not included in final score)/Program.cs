using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            var pointsDict = new Dictionary<string, List<int>>();
            var languagesDict = new Dictionary<string, int>();

            string userName = string.Empty;
            string language = string.Empty;
            int points = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                string[] token = input.Split("-");

                 userName = token[0];

                if (token.Length == 3)
                {
                     language = token[1];
                     points = int.Parse(token[2]);

                    if (!pointsDict.ContainsKey(userName))
                    {
                        pointsDict[userName] = new List<int>();
                    }

                    pointsDict[userName].Add(points);

                    if (!languagesDict.ContainsKey(language))
                    {
                        languagesDict[language] = 0;
                    }

                    languagesDict[language] += 1;
                }

                if (token.Length == 2)
                {
                    pointsDict.Remove(userName);
                }
            }

            pointsDict = pointsDict
                .OrderByDescending(x => x.Value.Max())
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results:");

            foreach (var item in pointsDict)
            {
                Console.WriteLine($"{item.Key} | {item.Value.Max()}");
            }

            languagesDict = languagesDict
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Submissions:");

            foreach (var item in languagesDict)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }
    }
}
