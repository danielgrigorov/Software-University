using System;

namespace Nested_Loops___More_Exercises___06._Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char upperSector = char.Parse(Console.ReadLine());
            int rowsFirstSector = int.Parse(Console.ReadLine());
            int seatsOddRow = int.Parse(Console.ReadLine());
            int totalCounter = 0;
            int sectorsCounter = 0;
            int evenSeatsCounter = 0;

            for (char i = 'A'; i <= upperSector; i++)
            {
                for (int j = 1; j <= rowsFirstSector + sectorsCounter; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenSeatsCounter = 2;
                    }
                    for (int k = 97; k <= seatsOddRow + evenSeatsCounter + 96; k++)
                    {
                        Console.WriteLine($"{i}{j}{(char)k}");
                        totalCounter++;
                    }
                    evenSeatsCounter = 0;
                }
                sectorsCounter++;
            }
            Console.WriteLine($"{totalCounter}");
        }
    }
}
