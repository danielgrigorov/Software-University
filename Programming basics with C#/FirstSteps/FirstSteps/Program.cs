using System;
using System.Diagnostics;
using System.Threading;

namespace FirstSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqrmtr = double.Parse(Console.ReadLine());
            double priceWithoutDiscount = sqrmtr * 7.61;
            double discount = priceWithoutDiscount * 0.18;
            double finalPrice = priceWithoutDiscount - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}