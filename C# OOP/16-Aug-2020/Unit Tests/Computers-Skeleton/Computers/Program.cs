using System;
using System.Collections.Generic;

namespace Computers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers;
            Computer computer;
            ComputerManager computerManager;

            computers = new List<Computer>();
            computer = new Computer("Asus", "X202", 222m);
            computerManager = new ComputerManager();

            computerManager.AddComputer(computer);

            Console.WriteLine(computerManager.Count);
            Console.WriteLine(computerManager.Computers.Count);
            Console.WriteLine(computer);
            computers.Add(computer);
            Console.WriteLine(computers[0]);
        }
    }
}
