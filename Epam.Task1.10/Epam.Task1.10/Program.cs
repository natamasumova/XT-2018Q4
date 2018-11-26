using System;

namespace Epam.Task1._10
{
    class Program
    {
        public static int GenerateNumber(Random random)
        {
            return random.Next(100);
        }

        static void FillArray(int[,] array, int m, int n)
        {
            Random random = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i,j] = GenerateNumber(random);
                }
            }
        }

        static int Sum(int[,] array, int m, int n)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j=0; j<m; j++)
                {
                    if (i == j) sum += array[i, j];
                }
            }
            return sum;
        }
        static void PrintArray(int[,] array, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.Write(Environment.NewLine);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first dimension: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second dimension: ");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[m, n];
            FillArray(array, m, n);
            PrintArray(array, m, n);
            Console.WriteLine($"The sum is {Sum(array,m,n)}");
        }
    }
}
