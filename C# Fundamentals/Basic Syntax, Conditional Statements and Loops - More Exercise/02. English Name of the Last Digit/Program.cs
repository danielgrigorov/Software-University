using System;

namespace _02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int currentDigit = number.Length - 1;

            char current = number[currentDigit];

            if (current == 51)
            {
                Console.WriteLine("three");
            }
            else if (current == 48)
            {
                Console.WriteLine("zero");
            }
            else if (current == 49)
            {
                Console.WriteLine("one");
            }
            else if (current == 50)
            {
                Console.WriteLine("two");
            }
            else if (current == 52)
            {
                Console.WriteLine("four");
            }
            else if (current == 53)
            {
                Console.WriteLine("five");
            }
            else if (current == 54)
            {
                Console.WriteLine("six");
            }
            else if (current == 55)
            {
                Console.WriteLine("seven");
            }
            else if (current == 56)
            {
                Console.WriteLine("eight");
            }
            else if (current == 57)
            {
                Console.WriteLine("nine");
            }
        }
    }
}
