using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriqPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudQuantity = double.Parse(Console.ReadLine());
            double safridQuantity = double.Parse(Console.ReadLine());
            int midiQuantity = int.Parse(Console.ReadLine());
            double palamudPrice = skumriqPrice + 0.6 * skumriqPrice;
            double safridPrice = cacaPrice + 0.8 * cacaPrice;
            double midiPrice = 7.50;
            double palamudOverall = palamudPrice * palamudQuantity;
            double safridOverall = safridPrice * safridQuantity;
            double midiOverall = midiPrice * midiQuantity;
            double end = palamudOverall + safridOverall + midiOverall;
            Console.WriteLine($"{end:f2}");
        }
    }
}
