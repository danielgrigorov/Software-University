using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            for (int i = username.Length-1; i >= 0; i--)
            {
                Console.Write($"{username[i]}");
            }
        }
    }
}
