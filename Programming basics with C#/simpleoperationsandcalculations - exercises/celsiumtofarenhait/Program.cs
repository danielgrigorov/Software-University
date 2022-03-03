using System;

namespace celsiumtofarenhait
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsium = double.Parse(Console.ReadLine());
            double Farenhait = Celsium * 1.8000 + 32.00;
            Console.WriteLine($"{Farenhait:f2}");
        }
    }
}
