using System;
using System.Text.RegularExpressions;

namespace Epam.Task7._5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            string input = Console.ReadLine();            string pattern = @"\b(([0-1]?[0-9])|([2][0-3])):([0-5][0-9])\b";            Regex regex = new Regex(pattern);            Match match = regex.Match(input);
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
