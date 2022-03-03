using System;

namespace Nested_Loops___Lab___05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double savedMoney = 0;

            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());

                while (minBudget > savedMoney)
                {
                    double currentSavings = double.Parse(Console.ReadLine());
                    savedMoney += currentSavings;

                    if (minBudget <= savedMoney)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        savedMoney = 0;
                        break;
                    }
                }
                    destination = Console.ReadLine();

            }
        }
    }
}
