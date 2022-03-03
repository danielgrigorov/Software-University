using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            int quantityVegetables = int.Parse(Console.ReadLine());
            int quantityFruits = int.Parse(Console.ReadLine());
            double totalVegetables = priceVegetables * quantityVegetables;
            double totalFruits = priceFruits * quantityFruits;
            double totalBGN = totalVegetables + totalFruits;
            double totalEUR = totalBGN / 1.94;
            Console.WriteLine($"{totalEUR:f2}");
        }
    }
}
