using System;
using System.Runtime.Intrinsics.X86;

namespace Simple_Operations_and_Calculations___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double end = (b1 + b2) * h / 2;
            Console.WriteLine($"{end:f2}");
        }
    }
}
