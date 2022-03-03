using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            string V = Console.ReadLine();
            bool noMoreSpace = false;
            int counter = 0;

            while (V != "End")
            {
                double currentSuitcase = double.Parse(V);
                counter++;

                if (counter %3 ==0)
                {
                    currentSuitcase *= 1.10;
                }
                if (capacity < currentSuitcase)
                {
                    Console.WriteLine("No more space!");
                    noMoreSpace = true;
                    counter--;
                    break;
                }
                capacity -= currentSuitcase;
                V = Console.ReadLine();
            }

            if (!noMoreSpace)
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
