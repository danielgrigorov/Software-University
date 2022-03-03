using System;

namespace _09._Moving__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int volume = w * l * h;
            int counter = 0;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int boxes = int.Parse(input);
                counter += boxes;
                if (counter > volume)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (volume > counter)
            {
                Console.WriteLine($"{volume - counter} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {counter - volume} Cubic meters more.");
            }

        }
    }
}
