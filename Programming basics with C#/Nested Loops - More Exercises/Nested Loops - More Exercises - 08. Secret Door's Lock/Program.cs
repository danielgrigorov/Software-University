using System;

namespace Nested_Loops___More_Exercises___08._Secret_Door_s_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperLimitSymbol1 = int.Parse(Console.ReadLine());
            int upperLimitSymbol2 = int.Parse(Console.ReadLine());
            int upperLimitSymbol3 = int.Parse(Console.ReadLine());

            for (int symbol1 = 2; symbol1 <= upperLimitSymbol1; symbol1+=2)
            {
                for (int symbol2 = 2; symbol2 <= upperLimitSymbol2; symbol2++)
                {
                    for (int symbol3 = 2; symbol3 <= upperLimitSymbol3; symbol3 += 2)
                    {
                        if (symbol2 == 2 || symbol2 == 3 || symbol2 == 5 || symbol2 == 7)
                        {
                            Console.WriteLine($"{symbol1} {symbol2} {symbol3}");
                        }
                    }
                }
            }
        }
    }
}
