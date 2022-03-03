using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string typeOfVacation = "";
            double cashToSpend = 0;

            if (budget <= 100)
            {
                {
                    destination = "Bulgaria";
                }
                if (season == "summer")
                {
                    typeOfVacation = "Camp";
                    cashToSpend = 0.3 * budget;
                }
                else if (season == "winter")
                {
                    typeOfVacation = "Hotel";
                    cashToSpend = 0.7 * budget;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                {
                    destination = "Balkans";
                }
                if (season == "summer")
                {
                    typeOfVacation = "Camp";
                    cashToSpend = 0.4 * budget;
                }
                else if (season == "winter")
                {
                    typeOfVacation = "Hotel";
                    cashToSpend = 0.8 * budget;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                typeOfVacation = "Hotel";
                cashToSpend = 0.9 * budget;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfVacation} - {cashToSpend:f2}");
        }
    }
}
