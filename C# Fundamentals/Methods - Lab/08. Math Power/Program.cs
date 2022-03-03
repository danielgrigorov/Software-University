using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double finalResult = FinalResult(n, power);
            Console.WriteLine(finalResult);
        }
        static double FinalResult(double n, double power)
        {
            double result = Math.Pow(n, power);
            return result;
        }
    }
}
