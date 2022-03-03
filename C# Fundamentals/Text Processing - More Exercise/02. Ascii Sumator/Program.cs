using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string line = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] > firstChar && line[i] < secondChar)
                {
                    sum += line[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
