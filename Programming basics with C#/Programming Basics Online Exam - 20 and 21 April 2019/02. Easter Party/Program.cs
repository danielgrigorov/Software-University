using System;

namespace _02._Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsAmount = int.Parse(Console.ReadLine());
            double priceKuvertPerPerson = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cakePrice = 0.1 * budget;
            budget -= cakePrice;

            if (guestsAmount >= 10 && guestsAmount <= 15)
            {
                priceKuvertPerPerson *= 0.85;
            }
            else if (guestsAmount > 15 && guestsAmount <= 20)
            {
                priceKuvertPerPerson *= 0.8;
            }
            else if (guestsAmount > 20)
            {
                priceKuvertPerPerson *= 0.75;
            }

            double razhodi = priceKuvertPerPerson * guestsAmount;
            budget -= razhodi;

            if (budget >= 0)
            {
                Console.WriteLine($"It is party time! {budget:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {Math.Abs(budget):f2} leva needed.");
            }
        }
    }
}
