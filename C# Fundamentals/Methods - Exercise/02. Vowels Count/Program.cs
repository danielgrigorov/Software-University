using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 65 || input[i] == 69 || input[i] == 73 || input[i] == 79 || input[i] == 85 || input[i] == 89 || input[i] == 97 || input[i] == 101 || input[i] == 105 || input[i] == 111 || input[i] == 117 || input[i] == 121)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
