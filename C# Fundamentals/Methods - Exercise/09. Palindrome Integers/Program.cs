using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string current = Console.ReadLine();

                if (current == "END")
                {
                    break;
                }

                var reversedCurrent = current.Reverse().ToArray();

                string kur = string.Join("", reversedCurrent);

                if (current == kur)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
