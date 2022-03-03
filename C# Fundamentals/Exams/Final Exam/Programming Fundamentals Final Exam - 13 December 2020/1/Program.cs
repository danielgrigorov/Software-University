using System;
using System.Text;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string current = Console.ReadLine();

                if (current == "End")
                {
                    break;
                }

                string[] token = current.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = token[0];
                string command2 = string.Empty;
                string command3 = string.Empty;

                if (command == "Translate")
                {
                    command2 = token[1];
                    command3 = token[2];

                    input = input.Replace(command2, command3);
                    Console.WriteLine(input);
                }

                else if (command == "Includes")
                {
                    command2 = token[1];

                    if (input.Contains(command2))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }

                else if (command == "Start")
                {
                    command2 = token[1];

                    bool yeah = false;

                    for (int i = 0; i < command2.Length; i++)
                    {
                        if (input[i] == command2[i])
                        {
                            yeah = true;
                        }
                        else
                        {
                            yeah = false;
                            break;
                        }
                    }

                    if (yeah)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }

                else if (command == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }

                else if (command == "FindIndex")
                {
                    command2 = token[1];

                    int lastIndex = input.LastIndexOf(command2);
                    Console.WriteLine(lastIndex);
                }

                else if (command == "Remove")
                {
                    int command22 = int.Parse(token[1]);
                    int command33 = int.Parse(token[2]);

                    input = input.Remove(command22, command33);
                    Console.WriteLine(input);
                }

            }
        }
    }
}
