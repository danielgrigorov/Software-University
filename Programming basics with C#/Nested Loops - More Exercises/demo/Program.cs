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
            int insideCounterA = 0;
            int insideCounterB = 0;
            int insideCounter3 = 0;
            int symbol1 = 35;
            int symbol2 = 64;

            for (int symbol3 = 1 + insideCounter3; symbol3 <= a; symbol3++)
            {
                for (int symbol4 = 1; symbol4 <= b; symbol4++)
                {
                    Console.Write($"{(char)(symbol1 + insideCounterA)}{(char)(symbol2 + insideCounterB)}{symbol3}{symbol4}{(char)(symbol2 + insideCounterB)}{(char)(symbol1 + insideCounterA)}|");
                    counter++;
                    insideCounterA++;
                    insideCounterB++;
                    if (insideCounterA > 20)
                    {
                        insideCounterA = 0;
                    }
                    if (insideCounterB > 32)
                    {
                        insideCounterB = 0;
                    }
                    if (counter >= maxPasswords)
                    {
                        return;
                    }
                }
                insideCounter3++;
            }
        }
    }
}
