using System;

namespace fruitmarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananasQuantity = double.Parse(Console.ReadLine());
            double orangesQuantity = double.Parse(Console.ReadLine());
            double raspberriesQuantity = double.Parse(Console.ReadLine());
            double strawberriesQuantity = double.Parse(Console.ReadLine());
            double raspberriesPrice = strawberriesPrice / 2;
            double orangesPrice = raspberriesPrice - 0.4 * raspberriesPrice;
            double bananasPrice = raspberriesPrice - 0.8 * raspberriesPrice;
            double sumStrawberries = strawberriesPrice * strawberriesQuantity;
            double sumBananas = bananasPrice * bananasQuantity;
            double sumOranges = orangesPrice * orangesQuantity;
            double sumRaspberries = raspberriesPrice * raspberriesQuantity;
            double sumTotal = sumBananas + sumOranges + sumRaspberries + sumStrawberries;
            Console.WriteLine($"{sumTotal:f2}");




        }
    }
}
