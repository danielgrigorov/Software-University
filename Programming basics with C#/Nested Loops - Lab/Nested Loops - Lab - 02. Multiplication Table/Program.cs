using System;

namespace Nested_Loops___Lab___02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int mnojitel1 = 1; mnojitel1 <= 10; mnojitel1++)
            {
                for (int mnojitel2 = 1; mnojitel2 <= 10; mnojitel2++)
                {
                    Console.WriteLine($"{mnojitel1} * {mnojitel2} = {mnojitel1 * mnojitel2}");
                }
            }
        }
    }
}
