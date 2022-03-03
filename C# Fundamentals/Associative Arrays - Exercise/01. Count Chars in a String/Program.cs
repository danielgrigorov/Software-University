using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();

            var result = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == ' ')
                {
                    continue;
                }

                if (!result.ContainsKey(words[i]))
                {
                    result[words[i]] = 0;
                }
                result[words[i]]++;
            }
            foreach (var resul in result)
            {
                Console.WriteLine($"{resul.Key} -> {resul.Value}");
            }
        }
    }
}
