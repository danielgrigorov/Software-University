using System;

namespace Nested_Loops___Exercise___03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string Num = Console.ReadLine();
            int sumProstiChisla = 0;
            int sumNeprostiChisla = 0;
            bool isPrime = false;

            while (Num != "stop")
            {
                int currentNum = int.Parse(Num);

                if (currentNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    Num = Console.ReadLine();
                    continue;
                }

                if (currentNum == 1)
                {
                    sumProstiChisla += currentNum;
                    Num = Console.ReadLine();
                    continue;
                }
                if (currentNum == 0)
                {
                    sumNeprostiChisla += currentNum;
                    Num = Console.ReadLine();
                    continue;
                }

                for (int a = 2; a <= currentNum / 2; a++)
                {
                    
                    if (currentNum % a == 0)
                    {
                        sumNeprostiChisla+= currentNum;
                        isPrime = true;
                        break;
                    }
                    isPrime = false;
                }
                if (!isPrime)
                {
                    sumProstiChisla+= currentNum;
                }
                Num = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumProstiChisla}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNeprostiChisla}");
        }
    }
}
