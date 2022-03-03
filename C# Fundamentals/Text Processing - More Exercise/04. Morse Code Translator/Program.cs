using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            char pechka = 'h';
            
            var morseCode = new Dictionary<char, string>()

                                   {
                                       {'A', ".-"},
                                       {'B', "-..."},
                                       {'C', "-.-."},
                                       {'D', "-.."},
                                       {'E', "."},
                                       {'F', "..-."},
                                       {'G', "--."},
                                       {'H', "...."},
                                       {'I', ".."},
                                       {'J', ".---"},
                                       {'K', "-.-"},
                                       {'L', ".-.."},
                                       {'M', "--"},
                                       {'N', "-."},
                                       {'O', "---"},
                                       {'P', ".--."},
                                       {'Q', "--.-"},
                                       {'R', ".-."},
                                       {'S', "..."},
                                       {'T', "-"},
                                       {'U', "..-"},
                                       {'V', "...-"},
                                       {'W', ".--"},
                                       {'X', "-..-"},
                                       {'Y', "-.--"},
                                       {'Z', "--.."},
                                   };

            string[] words = line.Split("|");

            for (int i = 0; i < words.Length; i++)
            {
                string[] current = words[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < current.Length; j++)
                {
                         pechka = morseCode.FirstOrDefault(x => x.Value == current[j]).Key;
                    result.Append(pechka);
                }
                result.Append(' ');
            }

            Console.WriteLine(result);
        }
    }
}
