using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int copynumber = number;

            int sum = 0;

            while (copynumber != 0)
            {
                int currentDigit = copynumber % 10;

                int currentFactoriel = 1;

                for (int i = 1; i <= currentDigit; i++)
                {
                    currentFactoriel *= i;
                }
                sum += currentFactoriel;

                copynumber /= 10;
            }

            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
