using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositedAmount = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());
            double sum = depositedAmount + months * (depositedAmount * interestRate/ 100/12);
            Console.WriteLine(sum);

        }
    }
}
