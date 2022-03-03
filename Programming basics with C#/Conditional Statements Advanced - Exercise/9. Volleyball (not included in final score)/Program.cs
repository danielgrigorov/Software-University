using System;

namespace _9._Volleyball__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double weekendsInSofia = 48 - h;
            double weekendGamesInSofia = weekendsInSofia * 0.75;
            double holidayGames = p * 2 / 3;
            double overallGames = weekendGamesInSofia + h + holidayGames;
            double leapGames = 0.15 * overallGames;
            double overallLeapGames = overallGames + leapGames;

            if (year == "normal")
            {
                Console.WriteLine($"{Math.Floor(overallGames)}");
            }
            else if (year == "leap")
            {
                Console.WriteLine($"{Math.Floor(overallLeapGames)}");
            }
        }
    }
}
