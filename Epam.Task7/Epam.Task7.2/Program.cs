﻿using System;
using System.Text.RegularExpressions;

namespace Epam.Task7._2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            string input = Console.ReadLine();
            string result = regex.Replace(input, target);
            Console.WriteLine(result);
        }
    }
}