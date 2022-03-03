using System;
using System.Globalization;

namespace Nested_Loops___More_Exercises___01._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperLevel1 = int.Parse(Console.ReadLine());
            int upperLevel2 = int.Parse(Console.ReadLine());
            int upperLevel3 = int.Parse(Console.ReadLine());

            for (int i = 2; i <= upperLevel1; i+=2)
            {
                for (int j = 2; j <= upperLevel2; j++)
                {
                    for (int k = 2; k <= upperLevel3; k += 2)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
