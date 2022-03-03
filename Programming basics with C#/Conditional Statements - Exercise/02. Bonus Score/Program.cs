using System;

namespace _02._Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus1 = 0;
            double bonus2 = 0;

            if (num<=100)
            {
                bonus1 = 5;
            }
            else if (num>100 && num<=1000)
            {
                bonus1 = num * 0.2;
            }
            else if (num>1000)
            {
                bonus1 = num * 0.1;
            }
            if (num %2 ==0)
            {
                bonus2 = 1;
            }
            else if (num % 10 ==5)
            {
                bonus2 = 2;
            }
            Console.WriteLine(bonus1 + bonus2);
            Console.WriteLine(num + bonus1 + bonus2);
        }
    }
}
