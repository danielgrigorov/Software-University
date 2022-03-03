using System;

namespace Conditional_Statements___More_Exercises___08._Fuel_Tank___Pa
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelAmount = double.Parse(Console.ReadLine());
            string discountCard = Console.ReadLine();

            double price = 0;

            if (fuelType == "Gas")
            {
                if (discountCard == "Yes")
                {
                    price = 0.85 * fuelAmount;
                }
                else
                {
                    price = 0.93 * fuelAmount;
                }
            }
            else if (fuelType == "Gasoline")
            {
                if (discountCard == "Yes")
                {
                    price = 2.04 * fuelAmount;
                }
                else
                {
                    price = 2.22 * fuelAmount;
                }
            }
            else if (fuelType == "Diesel")
            {
                if (discountCard == "Yes")
                {
                    price = 2.21 * fuelAmount;
                }
                else
                {
                    price = 2.33 * fuelAmount;
                }
            }
            if (fuelAmount >= 20 && fuelAmount <= 25)
            {
                price = price - 0.08 * price;
            }
            else if (fuelAmount > 25)
            {
                price = price - 0.1 * price;
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
