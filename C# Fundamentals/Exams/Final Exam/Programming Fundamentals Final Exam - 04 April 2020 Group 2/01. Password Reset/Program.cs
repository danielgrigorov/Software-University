using System;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            StringBuilder newPass = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }

                string[] token = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = token[0];
                string command2 = string.Empty;
                string command3 = string.Empty;


                if (command == "TakeOdd")
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (i %2 == 1)
                        {
                            newPass.Append(line[i]);
                        }
                    }
                    Console.WriteLine(newPass);
                    line = newPass.ToString();
                }
                else if (command == "Cut")
                {
                    command2 = token[1];
                    command3 = token[2];

                    line = line.Remove(int.Parse(command2), int.Parse(command3));
                    Console.WriteLine(line);
                }

                else if (command == "Substitute")
                {
                    command2 = token[1];
                    command3 = token[2];

                    if (line.Contains(command2))
                    {
                        line = line.Replace(command2, command3);
                        Console.WriteLine(line);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

            }
            Console.WriteLine($"Your password is: {line}");
        }
    }
}
