using System;

namespace Nested_Conditional_Statements___More_Exercises___06._Truck_D
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double budget = 0;

            if (kmPerMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    budget = 0.75 * kmPerMonth;
                }
                else if (season == "Summer")
                {
                    budget = 0.9 * kmPerMonth;
                }
                else if (season == "Winter")
                {
                    budget = 1.05 * kmPerMonth;
                }
            }
            else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    budget = 0.95 * kmPerMonth;
                }
                else if (season == "Summer")
                {
                    budget = 1.1 * kmPerMonth;
                }
                else if (season == "Winter")
                {
                    budget = 1.25 * kmPerMonth;
                }
            }
            else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
            {
                budget = 1.45 * kmPerMonth;
            }
            budget *= 4;
            budget *= 0.9;
            Console.WriteLine($"{budget:f2}");
        }
    }
}
