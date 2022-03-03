using System;
using System.Numerics;

namespace _05._Orders
{
    class Program
    {
        static void PrintResult(double result)
        {
            Console.WriteLine($"{result:f2}");
        }
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int qunatity = int.Parse(Console.ReadLine());

            double coffeePrice = 1.50;
            double waterPrice = 1.00;
            double cokePrice = 1.40;
            double snacksPrice = 2.00;

            double result = 0;

            if (product == "coffee")
            {
                result = (coffeePrice * qunatity);
                PrintResult(result);
            }
            if (product == "water")
            {
                result = (waterPrice * qunatity);
                PrintResult(result);

            }
            if (product == "coke")
            {
                result = (cokePrice * qunatity);
                PrintResult(result);

            }
            if (product == "snacks")
            {
                result = (snacksPrice * qunatity);
                PrintResult(result);

            }
        }
    }
}
