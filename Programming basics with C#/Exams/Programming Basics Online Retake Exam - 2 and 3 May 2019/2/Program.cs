using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double litersFuel = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double price = 0;
            double finalPrice = 0;

            if (day == "Saturday")
            {
                price = litersFuel * 2.1 + 100;
                finalPrice = price * 0.9;
            }
            else if (day == "Sunday")
            {
                price = litersFuel * 2.1 + 100;
                finalPrice = price * 0.8;
            }
            if (budget >= finalPrice)
            {
                Console.WriteLine($"Safari time! Money left: {budget - finalPrice:F2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {finalPrice - budget:f2} lv.");
            }
        }
    }
}
