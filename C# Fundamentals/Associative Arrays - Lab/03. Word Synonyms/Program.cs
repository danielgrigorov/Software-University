using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = int.Parse(Console.ReadLine());

            var words = new Dictionary<string, List<string>>();

            for (int i = 0; i < total; i++)
            {
                var word = Console.ReadLine();
                var synonym = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }

                words[word].Add(synonym);
            }

            foreach (var item in words)
            {
                var word = item.Key;
                var synonyms = item.Value;

                Console.WriteLine($"{word} - {string.Join (", ", synonyms)}");
            }
        }
    }
}
