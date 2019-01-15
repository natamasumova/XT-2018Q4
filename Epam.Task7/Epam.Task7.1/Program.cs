using System;
using System.Text.RegularExpressions;

namespace Epam.Task7._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            string input = Console.ReadLine();            string pattern = @"\b([0-1][1-9]|[1][0-9]|[3][0-1])\-([0][1-9]|[1][0-2])\-[1-2][0-9]{3}$";            Regex regex = new Regex(pattern);            Match match = regex.Match(input);
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
