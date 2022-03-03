using System;

namespace Nested_Conditional_Statements___More_Exercises___04._Car_To
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string classOfTheCar = string.Empty;
            string typeOfTheCar = string.Empty;

            double price = 0;

            if (budget <= 100)
            {
                classOfTheCar = "Economy class";

                if (season == "Summer")
                {
                    typeOfTheCar = "Cabrio";
                    price = 0.35 * budget;
                }
                else if (season == "Winter")
                {
                    typeOfTheCar = "Jeep";
                    price = 0.65 * budget;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                classOfTheCar = "Compact class";
                if (season == "Summer")
                {
                    typeOfTheCar = "Cabrio";
                    price = 0.45 * budget;
                }
                else if (season == "Winter")
                {
                    typeOfTheCar = "Jeep";
                    price = 0.8 * budget;
                }
            }
            else if (budget > 500)
            {
                typeOfTheCar = "Jeep";
                classOfTheCar = "Luxury class";
                price = 0.9 * budget;
            }

            Console.WriteLine($"{classOfTheCar}");
            Console.WriteLine($"{typeOfTheCar} - {price:f2}");
        }
    }
}

