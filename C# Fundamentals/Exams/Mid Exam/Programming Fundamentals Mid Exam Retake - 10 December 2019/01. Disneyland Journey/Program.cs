using System;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double journeyBudget = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double budget = 0;

            for (int i = 1; i <= months; i++)
            {
                if (i != 1 && i %2 == 1)
                {
                    budget -= budget * 0.16;
                }

                if (i % 4 == 0)
                {
                    budget *= 1.25;
                }

                budget += 0.25 * journeyBudget;
            }

            if (budget >= journeyBudget)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {budget-journeyBudget:f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {journeyBudget-budget:f2}lv. more.");
            }
        }
    }
}
