using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDogFoodInKg = int.Parse(Console.ReadLine());
            int totalDogFoodInGrams = totalDogFoodInKg * 1000;
            string input = Console.ReadLine();

            while (input != "Adopted")
            {
                int currentDogFoodInGrams = int.Parse(input);

                totalDogFoodInGrams -= currentDogFoodInGrams;

                input = Console.ReadLine();
            }
            if (totalDogFoodInGrams >=0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {totalDogFoodInGrams} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(totalDogFoodInGrams)} grams more.");
            }
        }
    }
}
