using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine().ToUpper();

            Regex numChecker = new Regex(@"([\d]+)");
            Regex symChecker = new Regex(@"([\D]+)");
            StringBuilder resSequence = new StringBuilder();
            List<char> uniqueSymList = new List<char>();
            int[] numArr = numChecker.Matches(sequence).Select(x => x.Value).Select(int.Parse).ToArray();
            string[] symArr = symChecker.Matches(sequence).Select(x => x.Value).ToArray();

            for (int i = 0; i < symArr.Length; i++)
            {
                for (int j = 0; j < numArr[i]; j++)
                {
                    resSequence.Append(symArr[i]);
                }
            }

            for (int i = 0; i < symArr.Length; i++)
            {
                if (numArr[i] == 0)
                {
                    continue;
                }

                foreach (var sym in symArr[i])
                {
                    if (!uniqueSymList.Contains(sym))
                    {
                        uniqueSymList.Add(sym);
                    }
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymList.Count}");
            Console.WriteLine(resSequence);
        }
    }
}