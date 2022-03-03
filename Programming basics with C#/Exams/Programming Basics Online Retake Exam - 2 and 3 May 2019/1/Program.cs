using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pileshkoMenu = int.Parse(Console.ReadLine());
            int ribaMenu = int.Parse(Console.ReadLine());
            int veggieMenu = int.Parse(Console.ReadLine());

            double price = pileshkoMenu * 10.35 + ribaMenu * 12.4 + veggieMenu * 8.15;

            double priceWithDesert = price * 1.2;

            double finalPrice = priceWithDesert + 2.5;

            Console.WriteLine($"Total: {finalPrice:f2}");
        }
    }
}
