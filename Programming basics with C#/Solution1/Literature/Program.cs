using System;
using System.Diagnostics.CodeAnalysis;

namespace Literature
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            double pagesForOneHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double time = numberOfPages / pagesForOneHour;
            double sum = time / days;
            Console.WriteLine(sum);

        }
    }
}
