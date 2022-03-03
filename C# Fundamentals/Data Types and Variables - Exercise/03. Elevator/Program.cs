using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int counter = 0;

            while (people > 0)
            {
                people -= capacity;
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
