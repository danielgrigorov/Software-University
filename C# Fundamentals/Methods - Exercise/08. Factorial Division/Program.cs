using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double firstFactorial = 1;
            double secondFactorial = 1;

            for (int i = 1; i <= firstNumber; i++)
            {
                firstFactorial *= i;
            }

            for (int i = 1; i <= secondNumber; i++)
            {
                secondFactorial *= i;
            }

            double result = firstFactorial / secondFactorial;

            Console.WriteLine($"{result:f2}");
        }
    }
}
