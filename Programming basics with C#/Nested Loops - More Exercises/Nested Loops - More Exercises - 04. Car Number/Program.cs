using System;

namespace Nested_Loops___More_Exercises___04._Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerLimit = int.Parse(Console.ReadLine());
            int upperLimit = int.Parse(Console.ReadLine());

            for (int i = lowerLimit; i <= upperLimit; i++)
            {
                for (int j = lowerLimit; j <= upperLimit; j++)
                {
                    for (int k = lowerLimit; k <= upperLimit; k++)
                    {
                        for (int l = lowerLimit; l <= upperLimit; l++)
                        {
                            if (i > l && (j+k) %2 == 0 && (i+l) %2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
