using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentNumber = 1;

            int counter = 0;

            while (currentNumber <= n)
            {
                for (int i = 1+counter; i <= currentNumber+counter; i++)
                {
                    Console.Write($"{currentNumber} ");
                }
                Console.WriteLine();

                currentNumber++;
                counter++;
            }
        }
    }
}
