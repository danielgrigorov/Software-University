using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLefttHalf = 0;
            int sumRightHalf = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sumLefttHalf += number;
            }
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sumRightHalf += number;
            }
            if (sumLefttHalf == sumRightHalf)
            {
                Console.WriteLine($"Yes, sum = {sumRightHalf}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumRightHalf - sumLefttHalf)}");
            }
        }
    }
}
