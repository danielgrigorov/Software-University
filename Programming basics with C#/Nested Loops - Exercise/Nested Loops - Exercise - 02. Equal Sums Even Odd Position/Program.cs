﻿using System;

namespace Nested_Loops___Exercise___02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                string currentNum = i.ToString();
                int evenPositions = 0;
                int oddPositions = 0;
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenPositions += currentDigit;
                    }
                    else
                    {
                        oddPositions += currentDigit;
                    }
                }
                if (oddPositions == evenPositions)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
