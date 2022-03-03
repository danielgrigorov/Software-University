using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int numberAsInt = int.Parse(number);

            string evenSum = "";
            string oddSum = "";

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] %2 != 0)
                {
                    oddSum += number[i];
                }
                else
                {
                    evenSum += number[i];
                }
            }
            int newEvenSum = int.Parse(evenSum);
            int newOddSum = int.Parse(oddSum);

            Console.WriteLine(newOddSum * newEvenSum);
        }
    }
}
