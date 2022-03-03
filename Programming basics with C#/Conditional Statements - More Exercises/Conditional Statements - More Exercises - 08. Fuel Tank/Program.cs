using System;

namespace Conditional_Statements___More_Exercises___08._Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelLiters = double.Parse(Console.ReadLine());

            if (fuelType == "Diesel" || fuelType == "Gas" || fuelType == "Gasoline")
            {
                if (fuelLiters >= 25)
                {
                    if (fuelType == "Diesel")
                    {
                        Console.WriteLine("You have enough diesel.");
                    }
                    else if (fuelType == "Gas")
                    {
                        Console.WriteLine("You have enough gas.");
                    }
                    else if (fuelType == "Gasoline")
                    {
                        Console.WriteLine("You have enough gasoline.");
                    }
                }
                else
                {
                    if (fuelType == "Diesel")
                    {
                        Console.WriteLine("Fill your tank with diesel!");
                    }
                    else if (fuelType == "Gas")
                    {
                        Console.WriteLine("Fill your tank with gas!");
                    }
                    else if (fuelType == "Gasoline")
                    {
                        Console.WriteLine($"Fill your tank with gasoline!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
