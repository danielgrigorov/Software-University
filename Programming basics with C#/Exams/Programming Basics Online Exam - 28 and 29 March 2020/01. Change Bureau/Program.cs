using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoins = double.Parse(Console.ReadLine());
            double uani = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double amountBtcInLv = 1168 * bitcoins;
            double amountBtcInLvToEur = amountBtcInLv / 1.95;

            double amountUaniInUsd = uani * 0.15;
            double amountUaniinUsdToEur2 = amountUaniInUsd * 1.76;
            double amountUaniinUsdToEur = amountUaniinUsdToEur2 / 1.95;

            double totalAmount = amountBtcInLvToEur + amountUaniinUsdToEur;
            double totalAmountAfterCommission = totalAmount - commission / 100 * totalAmount;

            Console.WriteLine($"{totalAmountAfterCommission:f2}");
        }
    }
}
