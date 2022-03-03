using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();

            if (degrees >= 10 && degrees <= 18)
            {
                if (timeOfTheDay == "Morning")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");
                }
                else if (timeOfTheDay == "Afternoon")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
                else if (timeOfTheDay == "Evening")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
            }
            else if (degrees > 18 && degrees <= 24)
            {
                if (timeOfTheDay == "Morning")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
                else if (timeOfTheDay == "Afternoon")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                }
                else if (timeOfTheDay == "Evening")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
            }
            else if (degrees >= 25)
            {
                if (timeOfTheDay == "Morning")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                }
                else if (timeOfTheDay == "Afternoon")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Swim Suit and Barefoot.");
                }
                else if (timeOfTheDay == "Evening")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
            }
        }
    }
}
