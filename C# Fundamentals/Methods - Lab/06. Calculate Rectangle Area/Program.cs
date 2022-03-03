using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double result = Result(w,h);
            Console.WriteLine(result);
        }
        static double Result(double w, double h)
        {
            return w * h;
        }
    }
}
