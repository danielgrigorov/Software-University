using System;
using System.Text;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Travel")
                {
                    break;
                }

                string[] token = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string command = token[0];
                string command2 = token[1];
                string command3 = token[2];

                if (command == "Add Stop")
                {
                    if (int.Parse(command2) >= 0 && int.Parse(command2) <= input.Length)
                    {
                        line = line.Insert(int.Parse(command2), command3);
                        Console.WriteLine(line);
                    }
                    else
                    {
                        Console.WriteLine(line);

                    }

                }
                else if (command == "Remove Stop")
                {
                    if (int.Parse(command2) >=0 && int.Parse(command2) <= line.Length -1 && int.Parse(command3) >= 0 && int.Parse(command3) <= line.Length - 1)
                    {
                        line = line.Remove(int.Parse(command2), int.Parse(command3) - int.Parse(command2)+1);
                        Console.WriteLine(line);
                    }
                    else
                    {
                        Console.WriteLine(line);

                    }
                }
                else if (command == "Switch")
                {
                    if (line.Contains(command2))
                    {
                        line = line.Replace(command2, command3);
                        Console.WriteLine(line);
                    }
                    else
                    {
                        Console.WriteLine(line);

                    }
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {line}");
        }
    }
}
