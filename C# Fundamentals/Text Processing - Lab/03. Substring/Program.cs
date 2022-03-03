using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();

            int index = secondLine.IndexOf(firstLine);

            while (index != -1)
            {
                secondLine = secondLine.Remove(index, firstLine.Length);
                index = secondLine.IndexOf(firstLine);
            }
            Console.WriteLine(secondLine);
        }
    }
}
