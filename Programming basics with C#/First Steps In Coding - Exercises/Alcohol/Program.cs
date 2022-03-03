using System;

namespace Alcohol
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskyPRice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double whiskyQuantity = double.Parse(Console.ReadLine());
            double rakiaPrice = whiskyPRice / 2;
            double winePrice = rakiaPrice - 0.4 * rakiaPrice;
            double beerPrice = rakiaPrice - 0.8 * rakiaPrice;
            double sum = whiskyPRice * whiskyQuantity + beerPrice * beerQuantity + winePrice * wineQuantity + rakiaPrice * rakiaQuantity;
            Console.WriteLine($"{sum:f2}");

        }
    }
}
