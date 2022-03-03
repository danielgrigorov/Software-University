using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();

            while (true)
            {
                string current = Console.ReadLine();

                if (current == "Reveal")
                {
                    break;
                }

                string[] token = current.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string command = token[0];
                string command2 = string.Empty;
                string command3 = string.Empty;

                if (command == "InsertSpace")
                {
                    command2 = token[1];

                    concealedMessage = concealedMessage.Insert(int.Parse(command2), " ");
                    Console.WriteLine(concealedMessage);
                }

                else if (command == "Reverse")
                {
                    command2 = token[1];

                    if (!concealedMessage.Contains(command2))
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        int index = concealedMessage.IndexOf(command2);
                        concealedMessage = concealedMessage.Remove(index, command2.Length);


                        string newMessage = string.Empty;

                        for (int i = command2.Length - 1; i >= 0; i--)
                        {
                            newMessage += command2[i];
                        }
                        concealedMessage = concealedMessage.Insert(concealedMessage.Length, newMessage);
                        Console.WriteLine(concealedMessage);
                    }
                }

                else if (command == "ChangeAll")
                {
                    command2 = token[1];
                    command3 = token[2];

                    concealedMessage = concealedMessage.Replace(command2, command3);
                    Console.WriteLine(concealedMessage);
                }


            }
            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }
    }
}
