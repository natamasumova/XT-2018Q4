using System;

namespace Epam.Task1._8
{
    class Program
    {
        public static int GenerateNumber(Random random)
        {
            return random.Next(-100, 100);
        }

        static void FillArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GenerateNumber(random);
            }
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.Write(Environment.NewLine);
        }
        static int NonNegativeSum(int[] array)
        {
            int sum = 0;
            int i = 0;
            while (i < array.Length)
            {
                if (array[i] >= 0) sum += array[i];
                i++;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in array: ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine($"Non-negative sum is {NonNegativeSum(array)}");
        }
    }
}
