using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var stack = new Stack<char>();

            bool allGood = true;

            int counter = 0;

            if (input[0] == '(' || input[0] == '[' || input[0] == '{' || input[0] == ' ')
            {
                stack.Push(input[0]);
            }
            else
            {
                Console.WriteLine("NO");
                allGood = false;
            }

            if (allGood == true)
            {
                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                    {
                        stack.Push(input[i]);
                    }
                    else if (input[i] == ')' && stack.Any())
                    {
                        if (stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            allGood = false;
                            break;
                        }
                    }
                    else if (input[i] == ']' && stack.Any())
                    {
                        if (stack.Peek() == '[')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            allGood = false;
                            break;
                        }
                    }
                    else if (input[i] == '}' && stack.Any())
                    {
                        if (stack.Peek() == '{')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            allGood = false;
                            break;
                        }
                    }
                    else if (input[i] == ' ')
                    {
                        if (stack.Peek() == ' ')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            stack.Push(' ');
                        }
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        allGood = false;
                        break;

                    }
                }
            }

            if (allGood)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
