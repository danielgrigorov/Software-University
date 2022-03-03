using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sellings = double.Parse(Console.ReadLine());

            double commission = 0;

            if (town == "Sofia")
            {
                if (sellings >= 0 && sellings <= 500)
                {
                    commission = 0.05 * sellings;
                }
                else if (sellings > 500 && sellings <= 1000)
                {
                    commission = 0.07 * sellings;
                }
                else if (sellings > 1000 && sellings <= 10000)
                {
                    commission = 0.08 * sellings;
                }
                else if (sellings > 10000)
                {
                    commission = 0.12 * sellings;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (sellings >= 0 && sellings <= 500)
                {
                    commission = 0.045 * sellings;
                }
                else if (sellings > 500 && sellings <= 1000)
                {
                    commission = 0.075 * sellings;
                }
                else if (sellings > 1000 && sellings <= 10000)
                {
                    commission = 0.10 * sellings;
                }
                else if (sellings > 10000)
                {
                    commission = 0.13 * sellings;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (sellings >= 0 && sellings <= 500)
                {
                    commission = 0.055 * sellings;
                }
                else if (sellings > 500 && sellings <= 1000)
                {
                    commission = 0.08 * sellings;
                }
                else if (sellings > 1000 && sellings <= 10000)
                {
                    commission = 0.12 * sellings;
                }
                else if (sellings > 10000)
                {
                    commission = 0.145 * sellings;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            if (commission != 0)
            {
                Console.WriteLine($"{commission:f2}");
            }
        }
    }
}
