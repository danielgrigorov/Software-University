using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            if (input == "int")
            {
                int firstNumber = int.Parse(firstWord);
                int secondNumber = int.Parse(secondWord);

                if (firstNumber > secondNumber)
                {
                    Console.WriteLine(firstNumber);
                }
                else
                {
                    Console.WriteLine(secondNumber);
                }
            }
            if (input == "char" || input == "string")
            {
                int result1 = 0;
                int result2 = 0;


                {
                    for (int i = 0; i < firstWord.Length; i++)
                    {
                        result1 += firstWord[i];
                    }
                    for (int i = 0; i < secondWord.Length; i++)
                    {
                        result2 += secondWord[i];
                    }
                    if (firstWord.CompareTo(secondWord) > 0)
                    {
                        Console.WriteLine(firstWord);
                    }
                    else
                    {
                        Console.WriteLine(secondWord);
                    }
                    //if (result1 > result2)
                    //{
                    //    Console.WriteLine(firstWord);
                    //}
                    //else
                    //{
                    //    Console.WriteLine(secondWord);
                    //}
                }
            }


        }
    }
}
