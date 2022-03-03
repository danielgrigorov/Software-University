using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string finalResult = RepeatString(name, n);

            Console.WriteLine(finalResult);
        }
        static string RepeatString(string name, int n)
        {
            string result = name;

            for (int i = 0; i < n-1; i++)
            {
                result += name;
            }
            return result;
        }
    }
}
