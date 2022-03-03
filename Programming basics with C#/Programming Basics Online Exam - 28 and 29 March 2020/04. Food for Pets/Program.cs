using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfDays = int.Parse(Console.ReadLine());
            double amountOfFood = double.Parse(Console.ReadLine());

            double eatenDogFood = 0;
            double eatenCatFood = 0;
            double eatenBiscuits = 0;
            int counter = 0;

            for (int i = 0; i < amountOfDays; i++)
            {
                int DogFood = int.Parse(Console.ReadLine());
                int CatFood = int.Parse(Console.ReadLine());

                eatenDogFood += DogFood;
                eatenCatFood += CatFood;
                counter++;

                if (counter %3 == 0)
                {
                    eatenBiscuits += 0.1 * (DogFood + CatFood);
                }
            }
            Console.WriteLine($"Total eaten biscuits: {Math.Round(eatenBiscuits)}gr.");
            Console.WriteLine($"{(eatenDogFood + eatenCatFood) / amountOfFood * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{eatenDogFood / (eatenDogFood + eatenCatFood) * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{eatenCatFood / (eatenCatFood + eatenDogFood) * 100:f2}% eaten from the cat.");
        }
    }
}
