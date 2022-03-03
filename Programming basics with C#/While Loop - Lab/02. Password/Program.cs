using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = Console.ReadLine();

            string attempt = Console.ReadLine();

            while (true)
            { 
                if (attempt == pass)
                
                {
                    break;
                }
            
                attempt = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {user}!");
        }
    }
}
