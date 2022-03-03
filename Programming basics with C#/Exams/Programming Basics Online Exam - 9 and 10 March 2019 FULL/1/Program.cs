using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double kecove = budget * 0.6;
            double ekip = kecove * 0.8;
            double topka = ekip / 4;
            double aksesoari = topka / 5;

            double price = kecove + ekip + topka + aksesoari + budget;

            Console.WriteLine($"{price:f2}");
        }
    }
}
