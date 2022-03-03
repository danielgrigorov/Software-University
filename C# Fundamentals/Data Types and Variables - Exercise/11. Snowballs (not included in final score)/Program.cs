using System;
using System.Numerics;

namespace _11._Snowballs__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            BigInteger bestScore = 0;
            BigInteger bestSnowBallSnow = 0;
            BigInteger bestSnowBallTime = 0;
            BigInteger bestSnowBallQuality = 0;

            BigInteger snowballSnow = 0;
            BigInteger snowballTime = 0;
            int snowballQuality = 0;

            BigInteger snowballValue = 0;

            for (int i = 0; i < n; i++)
            {
                snowballSnow = BigInteger.Parse(Console.ReadLine());
                snowballTime = BigInteger.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = BigInteger.Pow(snowballSnow/snowballTime, snowballQuality);

                if (snowballValue > bestScore)
                {
                    bestScore = snowballValue;
                    bestSnowBallSnow = snowballSnow;
                    bestSnowBallTime = snowballTime;
                    bestSnowBallQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnowBallSnow} : {bestSnowBallTime} = {bestScore} ({ bestSnowBallQuality})");
        }
    }
}
