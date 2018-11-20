using System;

namespace Epam.Task00.Square
{
    class Program
    {
        static void PrintSquare(uint n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("The number should be odd. Try again, please.");
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if ((i == n / 2 + 1) && (j == n / 2 + 1))
                    {
                        Console.Write(" ");
                    }
                    else Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter N: ");
                uint N = uint.Parse(Console.ReadLine());
                PrintSquare(N);
            }
        }
    }
}
