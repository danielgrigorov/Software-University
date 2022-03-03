using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();

            string firstWord = line[0];
            string secondWord = line[1];

            int sum = 0;

            if (firstWord.Length == secondWord.Length)
            {
                int currentSum = 0;

                for (int i = 0; i < firstWord.Length; i++)
                {
                    currentSum = firstWord[i] * secondWord[i];
                    sum += currentSum;
                }
            }
            else
            {
                if (firstWord.Length > secondWord.Length)
                {
                    int currentSum = 0;
                    int secondWordFinal = secondWord.Length;

                    for (int i = 0; i < secondWord.Length; i++)
                    {
                        currentSum = firstWord[i] * secondWord[i];
                        sum += currentSum;
                    }

                    for (int j = secondWord.Length; j < firstWord.Length; j++)
                    {
                        currentSum = firstWord[j];
                        sum += currentSum;
                    }
                }
                else if (secondWord.Length > firstWord.Length)
                {
                    int currentSum = 0;
                    int firstWordFinal = firstWord.Length;

                    for (int i = 0; i < firstWord.Length; i++)
                    {
                        currentSum = firstWord[i] * secondWord[i];
                        sum += currentSum;
                    }

                    for (int j = firstWord.Length; j < secondWord.Length; j++)
                    {
                        currentSum = secondWord[j];
                        sum += currentSum;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
