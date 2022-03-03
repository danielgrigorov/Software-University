using System;

namespace Nested_Loops___More_Exercises___02._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char lowerLimit = char.Parse(Console.ReadLine());
            char upperLimit = char.Parse(Console.ReadLine());
            char missing = char.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = lowerLimit; i <= upperLimit; i++)
            {
                for (int j = lowerLimit; j <= upperLimit; j++)
                {
                    for (int k = lowerLimit; k <= upperLimit; k++)
                    {
                        if (i == missing || j == missing || k == missing)
                        {
                            continue;
                        }
                        Console.Write($"{(char)i}{(char)j}{(char)k} ");
                        counter++;
                    }
                }
            }
            Console.Write($"{counter}");
        }
    }
}
