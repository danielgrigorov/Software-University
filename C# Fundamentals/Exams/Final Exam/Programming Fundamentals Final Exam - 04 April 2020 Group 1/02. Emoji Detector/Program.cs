using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            BigInteger coolThreshold = 1;

            string pattern1 = @"\d";

            MatchCollection collection = Regex.Matches(line, pattern1);

            foreach (Match item in collection)
            {
                coolThreshold *= int.Parse(item.Value);
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");

            int overallEmojis = 0;

            string pattern2 = @"(::|\*\*)(?<emojiName>[A-Z][a-z][a-z]+)\1";

            MatchCollection collection2 = Regex.Matches(line, pattern2);

            overallEmojis = collection2.Count;

            Console.WriteLine($"{overallEmojis} emojis found in the text. The cool ones are:");

            foreach (Match item in collection2)
            {
                string validEmoji = item.Groups["emojiName"].Value;
                int validEmojiSum = 0;
                string validEmojiName = item.Value;

                for (int i = 0; i < validEmoji.Length; i++)
                {
                    validEmojiSum += validEmoji[i];
                }
                if (validEmojiSum >= coolThreshold)
                {
                    Console.WriteLine(validEmojiName);
                }
            }

        }
    }
}
