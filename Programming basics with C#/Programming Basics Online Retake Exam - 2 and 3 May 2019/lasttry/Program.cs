using System;

namespace lasttry
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int counter = 0;
            double price = 0;

            bool hasMoney = true;

            while (command != "Stop")
            {
                double currentPrice = double.Parse(Console.ReadLine());

                counter++;

                if (counter % 3 == 0)
                { 
                    currentPrice = currentPrice / 2;
                }

                if (currentPrice > budget - price)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {currentPrice - (budget - price):f2} leva!");
                    hasMoney = false;
                    break;
                }


                if (counter % 3 == 0)
                {
                    price = price + currentPrice;
                }
                else
                {
                    price = price + currentPrice;
                }

                command = Console.ReadLine();
            }
            if (hasMoney)
            {
                Console.WriteLine($"You bought {counter} products for {price:f2} leva.");
            }
        }
    }
}
