using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesOfWalksPerDay = int.Parse(Console.ReadLine());
            int amountOfWalks = int.Parse(Console.ReadLine());
            int amountOfCalories = int.Parse(Console.ReadLine());

            int number = minutesOfWalksPerDay * amountOfWalks * 5;

            if (number >= amountOfCalories/2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {number}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {number}.");
            }
        }
    }
}
