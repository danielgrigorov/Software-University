using System;

namespace While_Loop___Exercise___01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string currentBook = "";
            int counter = 0;

            while (currentBook != "No More Books")
            {
                currentBook = Console.ReadLine();
                if (currentBook == input)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                counter++;
            }
            if (currentBook == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter-1} books.");

            }
        }
    }
}
