using System;
using System.Drawing;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string sizeOfSets = Console.ReadLine();
            int amountOfSets = int.Parse(Console.ReadLine());

            double price = 0;

            if (sizeOfSets == "small")
            {
                if (fruit == "Watermelon")
                {
                    price = 2 * 56;
                }
                else if (fruit == "Mango")
                {
                    price = 2 * 36.66;
                }
                else if (fruit == "Pineapple")
                {
                    price = 2 * 42.10;
                }
                else if (fruit == "Raspberry")
                {
                    price = 2 * 20;
                }
            }
            else if (sizeOfSets == "big")
            {
                if (fruit == "Watermelon")
                {
                    price = 5 * 28.70;
                }
                else if (fruit == "Mango")
                {
                    price = 5 * 19.60;
                }
                else if (fruit == "Pineapple")
                {
                    price = 5 * 24.80;
                }
                else if (fruit == "Raspberry")
                {
                    price = 5 * 15.20;
                }
            }
            double totalPrice = price * amountOfSets;

            if (totalPrice >= 400 && totalPrice <= 1000)
            {
                totalPrice *= 0.85;
            }
            else if (totalPrice > 1000)
            {
                totalPrice *= 0.5;
            }
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
