using System;

namespace Conditional_Statements___More_Exercises___04._Transport_Pric
{
    class Program
    {
        static void Main(string[] args)
        {
            int nKm = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double price = 0;

            if (nKm >= 100)
            {
                price = nKm * 0.06;
            }
            else if (nKm >=20 && nKm < 100)
            {
                price = nKm * 0.09;
            }
            else if (nKm < 20)
            {
                if (time == "day")
                {
                    price = 0.70 + nKm * 0.79;
                }
                else
                {
                    price = 0.70 + nKm * 0.9;
                }
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
