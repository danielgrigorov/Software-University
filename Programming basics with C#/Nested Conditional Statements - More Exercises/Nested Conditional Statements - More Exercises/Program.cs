using System;

namespace Nested_Conditional_Statements___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string typeOfRace = Console.ReadLine();

            double tax = 0;

            switch (typeOfRace)
            {
                case "trail":
                    tax = 5.5 * juniors + 7 * seniors;
                    break;
                case "cross-country":
                    tax = 8 * juniors + 9.5 * seniors;
                    break;
                case "downhill":
                    tax = 12.25 * juniors + 13.75 * seniors;
                    break;
                case "road":
                    tax = 20 * juniors + 21.5 * seniors;
                    break;
            }

            if (typeOfRace == "cross-country")
            {
                if (seniors + juniors >= 50)
                {
                    tax = tax - 0.25 * tax;
                }
            }
            tax = tax - 0.05 * tax;

            Console.WriteLine($"{tax:f2}");
        }
    }
}
