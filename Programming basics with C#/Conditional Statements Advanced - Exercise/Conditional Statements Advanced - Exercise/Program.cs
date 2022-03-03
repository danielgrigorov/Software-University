using System;
using System.Data;

namespace Conditional_Statements_Advanced___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double price = 0;

            if (projection == "Premiere")
            {
                price = 12;
            }

            else if (projection == "Normal")
            {
                price = 7.5;
            }

            else if (projection == "Discount")
            {
                price = 5;
            }

            double finalResult = price * row * column;
            Console.WriteLine($"{finalResult:f2} leva");
        }
    }
}
