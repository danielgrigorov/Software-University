using System;

namespace _01._Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            double kozunaci = double.Parse(Console.ReadLine());
            double eggs = double.Parse(Console.ReadLine());
            double kurabii = double.Parse(Console.ReadLine());

            double price = kozunaci * 3.2 + eggs * 4.35 + kurabii * 5.4 + eggs * 12 * 0.15;

            Console.WriteLine($"{price:f2}");
        }
    }
}
