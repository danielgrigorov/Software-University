using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());

            double price = 0;
            double priceAfterDiscount = 0;
            double priceAfterDiscount2 = 0;

            if (season == "Spring")
            {
                price = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else if (season == "Winter")
            {
                price = 2600;
            }

            if (fishermans <= 6)
            {
                priceAfterDiscount = price - 0.1 * price;
            }
            else if (fishermans >= 7 && fishermans <= 11)
            {
                priceAfterDiscount = price - 0.15 * price;
            }
            else if (fishermans >= 12)
            {
                priceAfterDiscount = price - 0.25 * price;
            }
            if (fishermans %2 == 0 && season != "Autumn")
            {
                priceAfterDiscount2 = priceAfterDiscount - 0.05 * priceAfterDiscount;
            }
            else
            {
                priceAfterDiscount2 = priceAfterDiscount;
            }
            if (budget>= priceAfterDiscount2)
            {
                Console.WriteLine($"Yes! You have {(budget - priceAfterDiscount2):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(priceAfterDiscount2 - budget):f2} leva.");
            }
        }
    }
}
