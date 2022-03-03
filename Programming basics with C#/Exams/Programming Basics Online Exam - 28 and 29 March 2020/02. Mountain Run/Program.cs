using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double neededSeconds = distanceInMeters * timeForOneMeter;
            double zabavqne = (Math.Floor(distanceInMeters / 50) * 30);

            double totalTime = neededSeconds + zabavqne;

            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($" Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime - recordInSeconds:f2} seconds slower.");
            }
        }
    }
}
