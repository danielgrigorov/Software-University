using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> banWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string text = Console.ReadLine();

            for (int i = 0; i < banWords.Count; i++)
            {
                while (text.Contains(banWords[i]))
                {
                    string replacement = string.Empty;

                    for (int j = 0; j < banWords[i].Length; j++)
                    {
                        replacement += "*";
                    }

                    text = text.Replace(banWords[i], replacement);
                }
            }

            Console.WriteLine(text);
        }
    }
}
