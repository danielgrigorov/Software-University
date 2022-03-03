using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double guestsCount = int.Parse(Console.ReadLine());
            double budget = int.Parse(Console.ReadLine());

            double kozunaciCount = Math.Ceiling(guestsCount / 3);
            double qicaCount = guestsCount * 2;

            double razhodi = kozunaciCount * 4 + qicaCount * 0.45;

            if (razhodi <= budget)
            {
                Console.WriteLine($"Lyubo bought {kozunaciCount} Easter bread and {qicaCount} eggs.");
                Console.WriteLine($"He has {budget - razhodi:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {razhodi - budget:F2} lv. more.");
            }
        }
    }
}
