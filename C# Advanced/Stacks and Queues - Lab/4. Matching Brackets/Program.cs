using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<string>();

            int openingBracketIndex = 0;
            int closingBracketIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i.ToString());
                }
                else if (input[i] == ')')
                {
                     closingBracketIndex = i;
                    openingBracketIndex = int.Parse(stack.Pop());
                    string result = input.Substring(openingBracketIndex, closingBracketIndex - openingBracketIndex + 1);
                    Console.WriteLine(result);

                }
            }
        }
    }
}
