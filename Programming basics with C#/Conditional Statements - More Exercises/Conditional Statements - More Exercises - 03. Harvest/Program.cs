using System;

namespace Conditional_Statements___More_Exercises___03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xarea = double.Parse(Console.ReadLine());
            double YGrapesPerSqM = double.Parse(Console.ReadLine());
            double ZNeededLetersWine = double.Parse(Console.ReadLine());
            double amountWorkers = double.Parse(Console.ReadLine());

            double totalArea = Xarea * YGrapesPerSqM;

            double wineNeeded = 0.4 * totalArea / 2.5;
            double perRabotnik = (wineNeeded - ZNeededLetersWine) / amountWorkers;

            if (wineNeeded < ZNeededLetersWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(ZNeededLetersWine - wineNeeded)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineNeeded)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineNeeded - ZNeededLetersWine)} liters left -> {Math.Ceiling(perRabotnik)} liters per person.");
            }
        }
    }
}
