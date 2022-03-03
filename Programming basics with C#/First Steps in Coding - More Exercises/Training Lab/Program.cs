using System;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double absH = (h * 100) - 100;
            double desks = (Math.Floor(absH / 70));
            double absW = w * 100;
            double rows = (Math.Floor(absW / 120));
            double end = (desks * rows) - 3;
            Console.WriteLine(Math.Floor(end));




        }
    }
}
