using System;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double racketPrice = double.Parse(Console.ReadLine());
            int racketsCount = int.Parse(Console.ReadLine());
            int maratonkiCount = int.Parse(Console.ReadLine());

            double maratonkiTotal = maratonkiCount * racketPrice / 6;
            double racketsTotal = racketPrice * racketsCount;
            double accesoriesTotal = (maratonkiTotal + racketsTotal) * 0.2;

            double moneyTotal = maratonkiTotal + racketsTotal + accesoriesTotal;

            double djoko = moneyTotal / 8;
            double sponsori = moneyTotal * 7 / 8;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(djoko)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsori)}");

        }
    }
}
