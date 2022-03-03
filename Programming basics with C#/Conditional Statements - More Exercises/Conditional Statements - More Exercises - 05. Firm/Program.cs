using System;

namespace Conditional_Statements___More_Exercises___05._Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoursNeeded = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());
            double workersOvertime = double.Parse(Console.ReadLine());

            double hoursNet2 = (days - 0.1 * days) * 8;
            double hoursNet = Math.Floor(hoursNet2);
            double overtimeNet = 2 * days * workersOvertime;

            double totalHours = hoursNet + overtimeNet;

            if (totalHours >= hoursNeeded)
            {
                Console.WriteLine($"Yes!{Math.Floor(totalHours - hoursNeeded)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Floor(hoursNeeded - totalHours)} hours needed.");
            }
        }
    }
}
