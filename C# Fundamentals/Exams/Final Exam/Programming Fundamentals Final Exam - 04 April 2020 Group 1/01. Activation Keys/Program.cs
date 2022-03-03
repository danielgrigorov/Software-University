using System;
using System.Text;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string current = string.Empty;

            while (true)
            {
                current = Console.ReadLine();

                if (current == "Generate")
                {
                    break;
                }

                string[] token = current.Split(">>>");

                string command = token[0];
                string secondCommand = token[1];
                string thirdCommand = string.Empty;
                string fourtCommand = string.Empty;

                if (token.Length == 3)
                {
                    thirdCommand = token[2];
                }
                else if (token.Length == 4)
                {
                    thirdCommand = token[2];
                    fourtCommand = token[3];
                }

                if (command == "Contains")
                {
                    if (input.Contains(secondCommand))
                    {
                        Console.WriteLine($"{input} contains {secondCommand}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                else if (command == "Flip")
                {
                    if (secondCommand == "Upper")
                    {
                        string kon = input.Substring(int.Parse(thirdCommand), int.Parse(fourtCommand) - int.Parse(thirdCommand));
                        string novKon = kon.ToUpper();
                        input = input.Replace(kon, novKon);
                        Console.WriteLine(input);
                    }
                    else if (secondCommand == "Lower")
                    {
                        string kon = input.Substring(int.Parse(thirdCommand), int.Parse(fourtCommand) - int.Parse(thirdCommand));
                        string novKon = kon.ToLower();
                        input = input.Replace(kon, novKon);
                        Console.WriteLine(input);
                    }
                }
                else if (command == "Slice")
                {
                    input = input.Remove(int.Parse(secondCommand), int.Parse(thirdCommand) - int.Parse(secondCommand));
                    Console.WriteLine(input);
                }

            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
