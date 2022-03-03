using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double tax = 0;
            int counter = 0;
            double overallTax = 0;

            for (int i = 1; i <= days; i++)
            {
                for (int j = 1; j <= hours; j++)
                {
                    if (i %2 != 0 && j %2 == 0)
                    {
                        tax += 1.25;
                    }
                    else if (i %2 == 0 && j %2 != 0)
                    {
                        tax += 2.50;
                    }
                    else
                    {
                        tax += 1.00;
                    }

                }
                counter++;

                Console.WriteLine($"Day: {counter} - {tax:f2} leva");

                overallTax += tax;
                tax = 0;
            }
            Console.WriteLine($"Total: {overallTax:F2} leva");
        }
    }
}
