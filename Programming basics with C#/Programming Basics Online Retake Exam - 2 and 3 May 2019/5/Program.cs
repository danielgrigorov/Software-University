using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());

            double counterP1 = 0;
            double counterP2 = 0;
            double counterP3 = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum %2 == 0)
                {
                    counterP1++;
                }
                if (currentNum %3 == 0)
                {
                    counterP2++;
                }
                if (currentNum %4 == 0)
                {
                    counterP3++;
                }

            }
            Console.WriteLine($"{counterP1 / n *100:f2}%");
            Console.WriteLine($"{counterP2 / n * 100:f2}%");
            Console.WriteLine($"{counterP3 / n * 100:f2}%");
        }
    }
}
