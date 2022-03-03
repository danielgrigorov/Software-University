using System;

namespace swim
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double totalSeconds = secondsPerMeter * distance;
            double delay = Math.Floor(distance / 15) * 12.5;
            totalSeconds += delay;

            if (totalSeconds < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSeconds:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalSeconds - worldRecord:f2} seconds slower.");
            }
        }
    }
}
