using System;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int mins = int.Parse(Console.ReadLine());
            int secs = int.Parse(Console.ReadLine());
            double lenghtUlei = double.Parse(Console.ReadLine());
            int secsFor100m = int.Parse(Console.ReadLine());

            int neededTimeInSecs = mins * 60 + secs;
            double putiVremeNamalq = lenghtUlei / 120;
            double obshtoNamalenoVreme = putiVremeNamalq * 2.5;
            double finalTime = (lenghtUlei / 100) * secsFor100m - obshtoNamalenoVreme;

            if (finalTime <= neededTimeInSecs)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {finalTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {finalTime - neededTimeInSecs:f3} second slower.");
            }
        }
    }
}
