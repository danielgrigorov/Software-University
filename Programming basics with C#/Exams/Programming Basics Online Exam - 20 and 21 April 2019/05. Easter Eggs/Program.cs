using System;

namespace _05._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountEggs = int.Parse(Console.ReadLine());

            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;

            int maxCount = int.MinValue;
            string maxCountColour = string.Empty;

            for (int i = 0; i < amountEggs; i++)
            {
                string eggColour = Console.ReadLine();

                if (eggColour == "red")
                {
                    redEggs++;
                    if (redEggs > maxCount)
                    {
                        maxCount = redEggs;
                        maxCountColour = "red";
                    }
                }
                else if (eggColour == "orange")
                {
                    orangeEggs++;
                    if (orangeEggs > maxCount)
                    {
                        maxCount = orangeEggs;
                        maxCountColour = "orage";

                    }
                }
                else if (eggColour == "blue")
                {
                    blueEggs++;
                    if (blueEggs > maxCount)
                    {
                        maxCount = blueEggs;
                        maxCountColour = "blue";

                    }
                }
                else if (eggColour == "green")
                {
                    greenEggs++;
                    if (greenEggs > maxCount)
                    {
                        maxCount = greenEggs;
                        maxCountColour = "green";

                    }
                }
            }
            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxCount} -> {maxCountColour}");

        }
    }
}
