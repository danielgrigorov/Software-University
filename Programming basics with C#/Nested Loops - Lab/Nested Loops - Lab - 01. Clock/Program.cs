﻿using System;

namespace Nested_Loops___Lab___01._Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours < 24; hours++)
            {
                for (int minutes = 0; minutes < 60; minutes++)
                {
                    for (int seconds = 0; seconds < 60; seconds++)
                    {
                        Console.WriteLine($"{hours} : {minutes} : {seconds}");
                    }
                }
            }
        }
    }
}
