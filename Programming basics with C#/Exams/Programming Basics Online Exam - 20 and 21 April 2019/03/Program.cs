using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string colour = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            int price = 0;

            if (size == "Large")
            {
                if (colour == "Red")
                {
                    price = 16;
                }
                else if (colour == "Green")
                {
                    price = 12;
                }
                else if (colour == "Yellow")
                {
                    price = 9;
                }
            }
            else if (size == "Medium")
            {
                if (colour == "Red")
                {
                    price = 13;
                }
                else if (colour == "Green")
                {
                    price = 9;
                }
                else if (colour == "Yellow")
                {
                    price = 7;
                }
            }
            else if (size == "Small")
            {
                if (colour == "Red")
                {
                    price = 9;
                }
                else if (colour == "Green")
                {
                    price = 8;
                }
                else if (colour == "Yellow")
                {
                    price = 5;
                }
            }

            double finalPrice = price * count;

            double totalPrice = 0.65 * finalPrice;

            Console.WriteLine($"{totalPrice:F2} leva.");
        }
    }
}
