using System;

namespace _06._Tournament_of_Christmas2
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int winsPerDay = 0;
            int losesPerDay = 0;
            int overallWins = 0;
            int overallLoses = 0;
            double money = 0;
            double totalMoney = 0;

            for (int i = 0; i < days; i++)
            {
                string sport = Console.ReadLine();

                while (sport != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        money += 20;
                        winsPerDay++;
                    }

                    else
                    {
                        losesPerDay++;
                    }

                    sport = Console.ReadLine();
                }
                if (winsPerDay > losesPerDay)
                {
                    money *= 1.10;
                    overallWins++;
                }
                else
                {
                    overallLoses++;
                }
                winsPerDay = 0;
                losesPerDay = 0;
                totalMoney += money;
                money = 0;
            }
            if (overallWins > overallLoses)
            {
                totalMoney *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}
