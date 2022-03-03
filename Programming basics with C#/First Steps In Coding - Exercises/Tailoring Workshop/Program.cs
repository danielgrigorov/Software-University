using System;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tablesQuantity = int.Parse(Console.ReadLine());
            double tablesLenght = double.Parse(Console.ReadLine());
            double tablesWidth = double.Parse(Console.ReadLine());
            double areaCovers = tablesQuantity * (tablesLenght + 2 * 0.30) * (tablesWidth + 2 * 0.30);
            double areaSquares = tablesQuantity * (tablesLenght / 2) * (tablesLenght / 2);
            double USD = (areaCovers * 7) + (areaSquares * 9);
            double BGN = USD * 1.85;
            Console.WriteLine($"{USD:f2} USD");
            Console.WriteLine($"{BGN:f2} BGN");

        }
    }
}
