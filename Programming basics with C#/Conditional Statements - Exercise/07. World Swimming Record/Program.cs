using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());

            double seconds = distance * timeForMeter;
            double suprotivlenie = Math.Floor(distance / 15) * 12.5;
            double finalResult = seconds + suprotivlenie;
            double difference = record - finalResult;

            if (finalResult < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalResult:f2} seconds.");
            }
            else if (finalResult > record)
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(difference):f2} seconds slower.");
            }
        }
    }
}
