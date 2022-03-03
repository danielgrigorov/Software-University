using System;
using System.Text;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            bool success = true;

            for (int i = 0; i < userNames.Length; i++)
            {
                if (userNames[i].Length >= 3 && userNames[i].Length <= 16)
                {
                    for (int j = 0; j < userNames[i].Length; j++)
                    {
                        string current = userNames[i];

                        if (current[j] == '-' || current[j] == '_' || (current[j] >= 48 && current[j] <= 57) || (current[j] >= 65 && current[j] <= 90) || (current[j] >= 97 && current[j] <= 122))
                        {
                            continue;
                        }
                        else
                        {
                            success = false;
                            break;
                        }
                        
                    }

                    if (success)
                    {
                        Console.WriteLine(userNames[i]);
                    }

                    success = true;
                }
            }
        }
    }
}
