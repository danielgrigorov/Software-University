using System;
using System.Data;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = 0;

            string command = string.Empty;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "special")
                {
                    break;
                }

                if (command == "regular")
                {
                    break;
                }

                double currentPrice = double.Parse(command);

                if (currentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                budget += currentPrice;
            }

            double budgetWT = budget;

            if (budget == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            budget *= 1.2;

            double taxesOnly = budget - budgetWT;
            
            if (command == "special")
            {
                budget *= 0.9;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {budgetWT:f2}$");
            Console.WriteLine($"Taxes: {taxesOnly:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {budget:f2}$");
        }
    }
}
