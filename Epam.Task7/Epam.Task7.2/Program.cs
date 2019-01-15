using System;
using System.Text.RegularExpressions;

namespace Epam.Task7._2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            string input = Console.ReadLine();            string pattern = @"<(\/?[^>]+)>";            string target = "_";            Regex regex = new Regex(pattern);            Match match = regex.Match(input);
            string result = regex.Replace(input, target);
            Console.WriteLine(result);
        }
    }
}
