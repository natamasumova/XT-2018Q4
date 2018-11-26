using System;

namespace Epam.Task1._2
{
    class Program
    {
        public static void PrintTriangle(uint n)
        {
            int i = 1;
            while (i <= n)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write(Environment.NewLine);
                i++;
            }
        }
        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter N: ");
                    uint N = uint.Parse(Console.ReadLine());
                    PrintTriangle(N);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number should be positive. Try again, please");
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a number. Try again, please");
                }
            }
        }
    }
}
