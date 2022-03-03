using System;

namespace Nested_Loops___More_Exercises___07._Safe_Passwords_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPasswords = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int symbol1 = 35; symbol1 <= 55; symbol1++)
            {
                for (int symbol2 = 64; symbol2 <= 96; symbol2++)
                {
                    for (int symbol3 = 1; symbol3 <= a; symbol3++)
                    {
                        for (int symbol4 = 1; symbol4 <= b; symbol4++)
                        {
                            for (int symbol5 = 64; symbol5 <= 96; symbol5++)
                            {
                                for (int symbol6 = 35; symbol6 <= 55; symbol6++)
                                {
                                    Console.Write($"{symbol1}{symbol2}{symbol3}{symbol4}{symbol5}{symbol6}|");
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
