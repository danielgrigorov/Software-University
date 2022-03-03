using System;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            int naum = 0;
            string result = string.Empty;

            for (int i = 0; i < numberAsString.Length; i++)
            {
                if (numberAsString[0] == '0')
                {
                    numberAsString = numberAsString.Remove(0, 1);
                }
                else
                {
                    break;
                }
            }

            for (int i = numberAsString.Length-1; i >= 0; i--)
            {
                int lastDigit = int.Parse(numberAsString[i].ToString());

                if (((lastDigit * multiplier) + naum) <=9)
                {
                    string resultAsNumber = ((lastDigit * multiplier) + naum).ToString();
                    result = result.Insert(0, resultAsNumber);
                    naum = 0;
                }
                else
                {
                    int resultAsNumber = (lastDigit * multiplier) + naum;
                    int resultAsNumberHui = resultAsNumber %10;
                    naum = resultAsNumber / 10;
                    result = result.Insert(0, resultAsNumberHui.ToString());
                }

            }

            if (naum!= 0)
            {
                result = result.Insert(0, naum.ToString());
            }

            result = result.TrimStart('0');

            if (result == string.Empty)
            {
                Console.WriteLine(0);
            }

            else
            {
                Console.WriteLine(result);
            }

            //bool isZero = true;

            //foreach (var item in result)
            //{
            //    if (item != '0')
            //    {
            //        isZero = false;
            //    }
            //}

            //if (isZero)
            //{
            //    result = 0.ToString();
            //}

            //Console.WriteLine(result);

        }
    }
}
