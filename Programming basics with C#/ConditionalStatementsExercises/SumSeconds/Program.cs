using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = num1 + num2 + num3;
            int min = sum / 60;
            int sec = sum % 60;

            if (sec < 10)
            {
                Console.WriteLine($"{min}:{sec:d2}");
            }

            else
            {
                Console.WriteLine($"{min}:{sec}");
            }
        }
    }
}
