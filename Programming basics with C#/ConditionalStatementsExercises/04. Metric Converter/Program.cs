using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            if (input == "mm" && output == "cm")
            {
                num /= 10;
            }
            else if (input == "mm" && output == "m")
            {
                num /= 1000;
            }
            else if (input == "cm" && output == "m")
            {
                num /= 100;
            }
            else if (input == "cm" && output == "mm")
            {
                num *= 10;
            }
            else if (input == "m" && output == "cm")
            {
                num *= 100;
            }
            else if (input == "m" && output == "mm")
            {
                num *= 1000;
            }
            Console.WriteLine($"{num:f3}");
        }
    }
}
