﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersAsStrings = Console.ReadLine()
                .Split("|")
                .Reverse()
                .ToList();

            List<int> numbers = new List<int>();

            string newKon = string.Join(" ", numbersAsStrings);

            for (int i = 0; i < numbersAsStrings.Count; i++)
            {
                numbers.AddRange(numbersAsStrings[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }


            //for (int i = 0; i < numbersAsStrings.Count; i++)
            //{
            //    numbers.AddRange(numbersAsStrings[i].Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //       .Select(int.Parse)
            //       .ToList()
            //       );
               
            //}
            Console.WriteLine(string.Join (" ", numbers));
        }
    }
}
