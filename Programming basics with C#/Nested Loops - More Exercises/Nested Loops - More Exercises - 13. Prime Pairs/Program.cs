using System;

namespace Nested_Loops___More_Exercises___13._Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCouple = int.Parse(Console.ReadLine());
            int secondCouple = int.Parse(Console.ReadLine());
            int diffFirstCouple = int.Parse(Console.ReadLine());
            int diffSecondCouple = int.Parse(Console.ReadLine());

            bool isPrime = false;
            bool isPrime2 = false;

            for (int i = firstCouple; i <= firstCouple + diffFirstCouple; i++)
            {
                for (int j = secondCouple; j <= secondCouple + diffSecondCouple; j++)
                {
                    for (int a = 2; a <= i / 2; a++)
                    {
                        if (i % a == 0)
                        {
                            isPrime = true;
                            break;
                        }
                        isPrime = false;

                    }
                    for (int b = 2; b <= j / 2; b++)
                    {
                        if (j % b == 0)
                        {
                            isPrime2 = true;
                            break;
                        }
                        isPrime2 = false;
                    }
                    if (!isPrime && !isPrime2)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                }
            }

        }
    }
}
