using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            double fans = double.Parse(Console.ReadLine());
            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;

            for (int i = 0; i < fans; i++)
            {
                string currentFan = Console.ReadLine();

                if (currentFan == "A")
                {
                    sectorA++;
                }
                if (currentFan == "B")
                {
                    sectorB++;
                }
                if (currentFan == "V")
                {
                    sectorV++;
                }
                if (currentFan == "G")
                {
                    sectorG++;
                }
            }
            Console.WriteLine($"{sectorA / fans * 100:f2}%");
            Console.WriteLine($"{sectorB / fans * 100:f2}%");
            Console.WriteLine($"{sectorV / fans * 100:f2}%");
            Console.WriteLine($"{sectorG / fans * 100:f2}%");
            Console.WriteLine($"{fans / capacity * 100:f2}%");
        }
    }
}
