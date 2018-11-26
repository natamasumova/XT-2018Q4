using System;

namespace Epam.Task1._1
{
    class Program
    {
        public static void PrintTriangle(uint n)
        {
            int pointer=1;
            int spaces = (int)n - 1;
            int stars;
            for (int i=1; i<=n; i++)
            {
                stars = 2 * i - 1;
                while (pointer <= spaces)
                {
                    Console.Write(" ");
                    pointer++;
                }
                while (stars > 0)
                {
                    Console.Write("*");
                    stars--;
                }
                Console.Write(Environment.NewLine);
                spaces--;
                pointer = 1;
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
