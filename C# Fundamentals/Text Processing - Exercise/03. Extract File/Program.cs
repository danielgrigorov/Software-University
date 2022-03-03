using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            int index = line.LastIndexOf("\\");

            string[] finalLine = line.Substring(index+1).Split(".");

            string firstHui = finalLine[0];
            string secondHui = finalLine[1];

            Console.WriteLine($"File name: {firstHui}");
            Console.WriteLine($"File extension: {secondHui}");



        }
    }
}
