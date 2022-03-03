using System;

namespace _05._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double score = 0;
            int zeroToNine = 0;
            int tenToNineteen = 0;
            int twentyToTwentynine = 0;
            int thirtyToThirtynine = 0;
            int fortyToFifty = 0;
            int invalidNumbers = 0;

            for (int i = 0; i < n; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());

                if (currentNumber >= 0 && currentNumber <=9 )
                {
                    score += currentNumber * 0.2;
                    zeroToNine++;
                }
                else if (currentNumber >=10 && currentNumber <=19)
                {
                    score += currentNumber * 0.3;
                    tenToNineteen++;
                }
                else if (currentNumber >= 20 && currentNumber <= 29)
                {
                    score += currentNumber * 0.4;
                    twentyToTwentynine++;
                }
                else if (currentNumber >= 30 && currentNumber <= 39)
                {
                    score += 50;
                    thirtyToThirtynine++;
                }
                else if (currentNumber >= 40 && currentNumber <= 50)
                {
                    score += 100;
                    fortyToFifty++;
                }
                else
                {
                    score = score / 2;
                    invalidNumbers++;
                }
            }
            Console.WriteLine($"{score:f2}");
            Console.WriteLine($"From 0 to 9: {zeroToNine * 1.0/n*100:f2}%");
            Console.WriteLine($"From 10 to 19: {tenToNineteen*1.0/n*100:f2}%");
            Console.WriteLine($"From 20 to 29: {twentyToTwentynine*1.0/n*100:f2}%");
            Console.WriteLine($"From 30 to 39: {thirtyToThirtynine*1.0/n*100:f2}%");
            Console.WriteLine($"From 40 to 50: {fortyToFifty*1.0/n*100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumbers*1.0/n*100:f2}%");
        }
    }
}
