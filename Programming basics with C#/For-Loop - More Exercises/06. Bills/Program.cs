using System;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double electricity = 0;
            double water = 0;
            double internet = 0;
            double others = 0;

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                double almostAllBills = (input + 20 + 15);
                double othersForTheMonth = almostAllBills + 0.2 * almostAllBills;
                others += othersForTheMonth;
                electricity += input;
                water += 20;
                internet += 15;
            }
            double average = (electricity + water + internet + others) / n;

            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:F2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
