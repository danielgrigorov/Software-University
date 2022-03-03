using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            int maxNUmber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < minNumber)
                {
                    minNumber = number;
                }
                if (number > maxNUmber)
                {
                    maxNUmber = number;
                }
            }
            Console.WriteLine($"Max number: {maxNUmber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
