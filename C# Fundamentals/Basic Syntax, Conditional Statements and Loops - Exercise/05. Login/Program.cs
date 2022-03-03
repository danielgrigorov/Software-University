using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = "";

            int counter = 0;

            bool incorrectPass = true;

            for (int i = username.Length-1; i >=0; i--)
            {
                password += username[i];
            }

            string attempt = Console.ReadLine();

            while (attempt != password)
            {
                if (counter >= 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    incorrectPass = false;
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");

                counter++;
               
                attempt = Console.ReadLine();

            }
            if (incorrectPass)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
