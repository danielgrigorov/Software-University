using System;

namespace _01._Easter_Cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double floorPrice = double.Parse(Console.ReadLine());
            double eggsPrice = 0.75 * floorPrice;
            double milkPricePerLiter = 1.25 * floorPrice;
            double milkPrice = 0.25 * milkPricePerLiter;

            double overallPrice = floorPrice + eggsPrice + milkPrice;

            int eggsReceived = 0;
            int counter = 0;

            while (budget - overallPrice >= 0)
            {
                budget -= overallPrice;
                eggsReceived += 3;
                counter++;

                if (counter %3 == 0)
                {
                    eggsReceived -= counter - 2;
                }
            }
            Console.WriteLine($"You made {counter} cozonacs! Now you have {eggsReceived} eggs and {budget:f2}BGN left.");
        }
    }
}
