using System;

namespace _04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupsCount = double.Parse(Console.ReadLine());

            double musalaCount = 0;
            double monblanCount = 0;
            double kilimandjaroCount = 0;
            double k2Count = 0;
            double everestCount = 0;

            double peopleCounter = 0;

            for (int i = 0; i < groupsCount; i++)
            {
                double peoplePerGroupCount = double.Parse(Console.ReadLine());

                if (peoplePerGroupCount <= 5)
                {
                    musalaCount += peoplePerGroupCount;
                }
                else if (peoplePerGroupCount >=6 && peoplePerGroupCount <= 12)
                {
                    monblanCount += peoplePerGroupCount;
                }
                else if (peoplePerGroupCount >= 13 && peoplePerGroupCount <= 25)
                {
                    kilimandjaroCount += peoplePerGroupCount;
                }
                else if (peoplePerGroupCount >= 26 && peoplePerGroupCount <= 40)
                {
                    k2Count += peoplePerGroupCount;
                }
                else if (peoplePerGroupCount >= 41)
                {
                    everestCount += peoplePerGroupCount;
                }
                peopleCounter += peoplePerGroupCount;

            }
            Console.WriteLine($"{musalaCount / peopleCounter * 100:f2}%");
            Console.WriteLine($"{monblanCount / peopleCounter * 100:f2}%");
            Console.WriteLine($"{kilimandjaroCount / peopleCounter * 100:f2}%");
            Console.WriteLine($"{k2Count / peopleCounter * 100:f2}%");
            Console.WriteLine($"{everestCount / peopleCounter * 100:f2}%");

        }
    }
}
