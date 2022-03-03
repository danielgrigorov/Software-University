using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int wincounter = 0;
            int losecounter = 0;
            double currentMoney = 0;
            double totalMoney = 0;
            int wincounterPerDay = 0;
            int losecounterPerDay = 0;


            for (int i = 1; i <= days; i++)
            {
                string input = Console.ReadLine();

                while (input != "Finish")
                {
                   string result = Console.ReadLine();

                    if (result == "win")
                    {
                        wincounter++;
                        currentMoney += 20;
                    }
                    else
                    {
                        losecounter++;
                    }
                    input = Console.ReadLine();
                }
                if (wincounter > losecounter)
                {
                    totalMoney = totalMoney + currentMoney * 1.10;
                    wincounterPerDay++;
                }
                else
                {
                    totalMoney += currentMoney;
                    losecounterPerDay++;
                }
                currentMoney = 0;
                wincounter = 0;
                losecounter = 0;
            }
            if (wincounterPerDay > losecounterPerDay)
            {
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney *= 1.20:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}
