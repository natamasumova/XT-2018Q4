﻿using System;
using System.Text.RegularExpressions;

namespace Epam.Task7._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            string input = Console.ReadLine();
            if (match.Success)
            {
                Console.WriteLine("There is date in this text");
            }
            else
            {
                Console.WriteLine("There is no date in this text");
            }
        }
    }
}