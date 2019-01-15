using System;
using System.Text.RegularExpressions;

namespace Epam.Task7._3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            string input = Console.ReadLine();            string pattern = @"\b([a-zA-Z]+.\w+)@([a-zA-Z]+.\w+)(.[a-zA-Z]{2,4}){1,2}";            Regex regex = new Regex(pattern);            Match match = regex.Match(input);
            Console.WriteLine($"{Environment.NewLine}E-mail addresses from this text:{Environment.NewLine}");
            while (match.Success)
            {
                Console.WriteLine(match.Value);
                match = match.NextMatch();
            }
        }
    }
}
