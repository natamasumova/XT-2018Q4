using System;

namespace Epam.Task1._8
{
    class Program
    {
        public static int GenerateNumber(Random random)
        {
            return random.Next(-100,100);
        }

        static void FillArray(int[,,] array)
        {
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        array[i,j,k] = GenerateNumber(random);
                    }
                }
            }
        }
        static void ChangeNumbers(int[,,] array)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (array[i, j, k] > 0) array[i, j, k] = 0;
                    }
                }
            }
        }
        static void PrintArray(int[,,] array)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine($"array[{i},{j},{k}] = {array[i, j, k]}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[,,] array = new int[3,3,3];
            FillArray(array);
            Console.WriteLine("Before changing: ");
            PrintArray(array);
            Console.Write(Environment.NewLine);
            ChangeNumbers(array);
            Console.WriteLine("After changing: ");
            PrintArray(array);
        }
    }
}
