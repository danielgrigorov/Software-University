using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int kozunaciCount = int.Parse(Console.ReadLine());

            int paketiSugar = 0;
            int paketiFlour = 0;

            int bestSugar = int.MinValue;
            int bestFlour = int.MinValue;

            for (int i = 0; i < kozunaciCount; i++)
            {
                int sugar = int.Parse(Console.ReadLine());
                int flour = int.Parse(Console.ReadLine());

                if (sugar > bestSugar)
                {
                    bestSugar = sugar;
                }
                if (flour > bestFlour)
                {
                    bestFlour = flour;
                }

                paketiSugar += sugar;
                paketiFlour += flour;
            }

            double krainiPaketiSugar = Math.Ceiling(paketiSugar *1.0 / 950);
            double krainiPaketiFlour = Math.Ceiling(paketiFlour * 1.0 / 750);

            Console.WriteLine($"Sugar: {krainiPaketiSugar}");
            Console.WriteLine($"Flour: {krainiPaketiFlour}");
            Console.WriteLine($"Max used flour is {bestFlour} grams, max used sugar is {bestSugar} grams.");
        }
    }
}
