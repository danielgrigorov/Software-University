using System;

namespace Nested_Conditional_Statements___More_Exercises___10._Multipl
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            while (number >= 0)
            {
                Console.WriteLine($"Result: {number *2:f2}");
                number = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("Negative number!");
        }
    }
}
