using System;

namespace Nested_Loops___More_Exercises___11._HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double taxPerDay = 0;
            double totalMoney = 0;

            for (int i = 1; i <= days ; i++)
            {
                for (int j = 1; j <= hours; j++)
                {
                    if (i %2 != 0 && j %2 != 0)
                    {
                        taxPerDay += 1;
                    }
                    if (i %2 !=0 && j %2 == 0)
                    {
                        taxPerDay += 1.25;
                    }
                    if (i %2 == 0 && j %2 != 0)
                    {
                        taxPerDay += 2.50;
                    }
                    if (i %2 == 0 && j %2 == 0)
                    {
                        taxPerDay += 1;
                    }

                }
                Console.WriteLine($"Day: {i} - {taxPerDay:f2} leva");
                totalMoney += taxPerDay;
                taxPerDay = 0;
            }
            Console.WriteLine($"Total: {totalMoney:f2} leva");
        }
    }
}
