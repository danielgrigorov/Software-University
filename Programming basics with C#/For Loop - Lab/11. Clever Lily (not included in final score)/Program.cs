using System;

namespace _11._Clever_Lily__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double savedMoney = 0;
            int counter = 1;

            for (int i = 1; i <= age; i++)
            {
                if (i %2 != 0)
                {
                    savedMoney += toyPrice;
                }
                else if (i %2 == 0)
                {
                    savedMoney += counter *10;
                    savedMoney -= 1;
                    counter++;
                }
            }
            if (savedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {savedMoney - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - savedMoney:f2}");
            }
        }
    }
}
