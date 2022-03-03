using System;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                int index1Start = line.IndexOf('@');
                int index2Start = line.IndexOf('|');

                string name = line.Substring(index1Start+1, index2Start - index1Start-1);

                int index1Final = line.IndexOf('#');
                int index2Final = line.IndexOf('*');

                string age = line.Substring(index1Final + 1, index2Final - index1Final-1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
