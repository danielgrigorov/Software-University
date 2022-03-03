using System;
using System.Text;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string current = Console.ReadLine();

                if (current == "Decode")
                {
                    break;
                }

                string[] token = current.Split("|");

                string command = token[0];
                string command2 = string.Empty;
                string command3 = string.Empty;

                if (command == "Move")
                {
                    command2 = token[1];
                    string newWord = string.Empty;
                    for (int i = 0; i < int.Parse(command2); i++)
                    {
                        newWord += input[i];
                    }
                    input = input.Remove(0, int.Parse(command2));
                    input = input.Insert(input.Length, newWord);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(token[1]);
                    command3 = token[2];

                    input = input.Insert(index, command3);
                }
                else if (command == "ChangeAll")
                {
                    command2 = token[1];
                    command3 = token[2];

                    input = input.Replace(command2, command3);
                }

            }
            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
