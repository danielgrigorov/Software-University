using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "end")
            {
                string reversedLine = string.Empty;

                for (int i = line.Length-1; i >= 0; i--)
                {
                    reversedLine += line[i];
                }

                Console.WriteLine($"{line} = {reversedLine}");

                line = Console.ReadLine();
            }
        }
    }
}
