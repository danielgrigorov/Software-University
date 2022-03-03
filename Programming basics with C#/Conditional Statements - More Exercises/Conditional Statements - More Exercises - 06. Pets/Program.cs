using System;

namespace Conditional_Statements___More_Exercises___06._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int totalFood = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            double totalNeededFood = days * dogFood + days * catFood + days * turtleFood/1000;

            if (totalFood >= totalNeededFood)
            {
                Console.WriteLine($"{Math.Floor(totalFood - totalNeededFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalNeededFood - totalFood)} more kilos of food are needed.");
            }
        }
    }
}
