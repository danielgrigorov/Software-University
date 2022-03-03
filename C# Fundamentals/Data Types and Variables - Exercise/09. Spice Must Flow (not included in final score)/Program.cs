using System;

namespace _09._Spice_Must_Flow__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int profit = 0;

            int counter = 0;

            while (startingYield >= 100)
            {
                profit += startingYield;

                if (profit >= 26)
                {
                    profit -= 26;
                }

                startingYield -= 10;

                counter++;
            }

            if (profit >= 26)
            {
                profit -= 26;
            }

            Console.WriteLine(counter);
            Console.WriteLine(profit);
        }
    }
}
