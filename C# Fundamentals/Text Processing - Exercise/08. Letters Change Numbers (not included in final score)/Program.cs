using System;

namespace _08._Letters_Change_Numbers__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double finalSum = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                string current = lines[i];

                char beforeLetter = current[0];
                char afterLetter = current[current.Length - 1];

                current = current.Remove(0, 1);
                current = current.Remove(current.Length - 1, 1);

                double currentNumber = double.Parse(current);

                double currentSum = 0;

                if (beforeLetter >= 65 && beforeLetter <= 90)
                {
                    currentSum += currentNumber / (beforeLetter % 32);
                }
                else if (beforeLetter >= 97 && beforeLetter <= 122)
                {
                    currentSum += currentNumber * (beforeLetter % 32);
                }

                if (afterLetter >= 65 && afterLetter <= 90)
                {
                    currentSum -= (afterLetter % 32);
                }
                else if (afterLetter >= 97 && afterLetter <= 122)
                {
                    currentSum += (afterLetter % 32);
                }

                finalSum += currentSum;

            }

            Console.WriteLine($"{finalSum:f2}");
        }
    }
}
