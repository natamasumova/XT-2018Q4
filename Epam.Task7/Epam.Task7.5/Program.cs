﻿using System;
using System.Text.RegularExpressions;

namespace Epam.Task7._5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            string input = Console.ReadLine();
            int count = 0;
            while (match.Success)
            {
                count++;
                match = match.NextMatch();
            }
            Console.WriteLine($"Time in the text presents {count} time(s)");
        }
    }
}