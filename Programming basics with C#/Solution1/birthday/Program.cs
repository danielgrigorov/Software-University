using System;
using System.Diagnostics.CodeAnalysis;

namespace birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double cake = rent * 0.2;
            double drinks = cake - 0.45 * cake;
            double animator = rent / 3;
            double sum = rent + cake + drinks + animator;
            Console.WriteLine(sum);


        }
    }
}
