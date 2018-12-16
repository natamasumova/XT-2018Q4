using System;

namespace Epam.Task4._5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            try
            {
                string str = Console.ReadLine();
                bool isInt = str.IsInt();
                Console.WriteLine(str.IsInt());
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}
