using System;

namespace While_Loop___More_Exercises___05._Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                sum += currentNumber;
            }
            Console.WriteLine($"{sum/n:f2}");
        }
    }
}
