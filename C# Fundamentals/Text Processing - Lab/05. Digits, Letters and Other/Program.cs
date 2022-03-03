using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            StringBuilder texts = new StringBuilder();
            StringBuilder numbers = new StringBuilder();
            StringBuilder others = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] >= 48 && line[i] <= 57)
                {
                    numbers.Append(line[i]);
                }
                else if (line[i] >= 65 && line[i] <= 90 )
                {
                    texts.Append(line[i]);
                }
                else if (line[i] >= 97 && line[i] <= 122)
                {
                    texts.Append(line[i]);
                }
                else
                {
                    others.Append(line[i]);
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(texts);
            Console.WriteLine(others);
        }
    }
}
