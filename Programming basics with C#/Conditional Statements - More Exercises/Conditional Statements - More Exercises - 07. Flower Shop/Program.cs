using System;

namespace Conditional_Statements___More_Exercises___07._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoliiCount = int.Parse(Console.ReadLine());
            int zumbuliCoint = int.Parse(Console.ReadLine());
            int roziCount = int.Parse(Console.ReadLine());
            int kaktusiCount = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double price = magnoliiCount * 3.25 + zumbuliCoint * 4 + roziCount * 3.5 + kaktusiCount * 8;
            double priceAfterTaxes = price - 0.05 * price;

            if (priceAfterTaxes >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(priceAfterTaxes - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - priceAfterTaxes)} leva.");
            }
        }
    }
}
