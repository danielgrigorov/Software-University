using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int counter = 0;

            bool noMoreMoney = false;

            double totalPrice = 0;

            while (command != "Stop")
            {
                double currentPrice = double.Parse(Console.ReadLine());

                if (budget < currentPrice)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {currentPrice - budget:f2} leva!");
                    noMoreMoney = true;
                    break;
                }

                counter++;
                if (counter %3 == 0)
                {
                    budget -= currentPrice/2;
                    totalPrice += currentPrice/2;
                }
                else
                {
                    budget -= currentPrice;
                    totalPrice += currentPrice;
                }

                command = Console.ReadLine();

            }
            if (!noMoreMoney)
            {
                Console.WriteLine($"You bought {counter} products for {totalPrice:f2} leva.");
            }
        }
    }
}
