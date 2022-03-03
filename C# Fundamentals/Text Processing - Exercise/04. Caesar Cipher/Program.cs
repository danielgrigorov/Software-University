using System;
using System.Text;
using System.Linq;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            StringBuilder hui = new StringBuilder();


            for (int i = 0; i < line.Length; i++)
            {
                int current = line[i];
                current += 3;


                hui.Append($"{(char)current}");

            }

            Console.WriteLine(hui);
        }
    }
}
