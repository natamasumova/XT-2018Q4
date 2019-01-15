using System;
using System.Text.RegularExpressions;

namespace Epam.Task7._4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your number:");
                string input = Console.ReadLine();
                string patternSimple = @"^(-?\d+(.\d+)?)$";
                string patternScience = @"^(-?\d+(.\d+)?e(\+|-)\d+)$";

                Regex regexSimple = new Regex(patternSimple);
                Regex regexScience = new Regex(patternScience);

                if (regexSimple.IsMatch(input))
                {
                    Console.WriteLine($"This is a number in a simple notation{Environment.NewLine}");
                }
                else
                {
                    if (regexScience.IsMatch(input))
                    {
                        Console.WriteLine($"This is a number in a science notation{Environment.NewLine}");
                    }
                    else
                    {
                        Console.WriteLine($"This is not a number{Environment.NewLine}");
                    }
                }
            }
        }
    }
}
