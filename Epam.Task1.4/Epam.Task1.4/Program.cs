using System;

namespace Epam.Task1._1
{
    class Program
    {
        public static void CheckNumber(int N)
        {
            if (N <= 0) throw new ArgumentException();
        }

        public static void PrintTriangle(int n, int offset)
        {
            int pointer = 1;
            int spaces = n - 1 + offset;
            int stars;
            for (int i = 1; i <= n; i++)
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
        public static void PrintTree(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                PrintTriangle(i, n - i);
            }
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter N: ");
                    int N = int.Parse(Console.ReadLine());
                    CheckNumber(N);
                    PrintTree(N);
                }
                catch (ArgumentException)
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
