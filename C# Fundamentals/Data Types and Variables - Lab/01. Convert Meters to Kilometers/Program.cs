using System;
using System.Numerics;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            decimal b = a / 1000.0m;

            Console.WriteLine($"{b:f2}");
        }
    }
}
