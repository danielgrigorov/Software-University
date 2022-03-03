using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int age = 18;

            for (int i = 1800; i <= n; i++)
            {
                if (i %2 == 0)
                {
                    totalMoney -= 12000;
                }
                else if (i %2 != 0)
                {
                    totalMoney = totalMoney - (12000 + 50 * age);
                }
                age++;
            }
            if (totalMoney >=0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {totalMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(totalMoney):f2} dollars to survive.");
            }
        }
    }
}
