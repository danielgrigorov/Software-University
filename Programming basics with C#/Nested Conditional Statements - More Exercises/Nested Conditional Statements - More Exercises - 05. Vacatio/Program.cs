using System;

namespace Nested_Conditional_Statements___More_Exercises___05._Vacatio
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string nastanqvane = string.Empty;
            string location = string.Empty;
            double price = 0;

            if (budget <= 1000)
            {
                nastanqvane = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = 0.65 * budget;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = 0.45 * budget;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                nastanqvane = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = 0.8 * budget;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = 0.6 * budget;
                }
            }
            else if (budget > 3000)
            {
                nastanqvane = "Hotel";
                price = 0.9 * budget;
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                }
            }
            Console.WriteLine($"{location} - {nastanqvane} - {price:f2}");
        }
    }
}
