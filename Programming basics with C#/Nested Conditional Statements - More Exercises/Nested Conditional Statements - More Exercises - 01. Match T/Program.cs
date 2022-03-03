using System;

namespace Nested_Conditional_Statements___More_Exercises___01._Match_T
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleCount = int.Parse(Console.ReadLine());

            if (peopleCount >= 1 && peopleCount <= 4)
            {
                budget = budget - 0.75 * budget;
            }
            else if (peopleCount >= 5 && peopleCount <= 9)
            {
                budget = budget - 0.60 * budget;
            }
            else if (peopleCount >= 10 && peopleCount <= 24)
            {
                budget = budget - 0.50 * budget;
            }
            else if (peopleCount >= 25 && peopleCount <= 49)
            {
                budget = budget - 0.40 * budget;
            }
            else if (peopleCount > 50)
            {
                budget = budget - 0.25 * budget;
            }

            if (category == "VIP")
            {
                budget = budget - peopleCount * 499.99;
                if (budget >= 0)
                {
                    Console.WriteLine($"Yes! You have {budget:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {Math.Abs(budget):f2} leva.");
                }
            }
            else if (category == "Normal")
            {
                budget = budget - peopleCount * 249.99;
                if (budget >= 0)
                {
                    Console.WriteLine($"Yes! You have {budget:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {Math.Abs(budget):f2} leva.");
                }
            }
        }
    }
}