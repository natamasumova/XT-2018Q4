﻿using System;
using System.Text.RegularExpressions;

namespace Epam.Task7._3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            string input = Console.ReadLine();
            Console.WriteLine($"{Environment.NewLine}E-mail addresses from this text:{Environment.NewLine}");
            while (match.Success)
            {
                Console.WriteLine(match.Value);
                match = match.NextMatch();
            }
        }
    }
}