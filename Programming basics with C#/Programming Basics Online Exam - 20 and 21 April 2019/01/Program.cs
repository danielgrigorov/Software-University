using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double brashnoNaKg = double.Parse(Console.ReadLine());
            double amountBrashno = double.Parse(Console.ReadLine());
            double amountZahar = double.Parse(Console.ReadLine());
            double amountKori = double.Parse(Console.ReadLine());
            double amountMaq = double.Parse(Console.ReadLine());

            double zaharNaKg = 0.75 * brashnoNaKg;
            double koriNaBroi = 1.10 * brashnoNaKg;
            double maqNaBroi = 0.2 * zaharNaKg;

            double price = brashnoNaKg * amountBrashno + amountZahar * zaharNaKg + amountKori * koriNaBroi + amountMaq * maqNaBroi;

            Console.WriteLine($"{price:f2}");
        }
    }
}
