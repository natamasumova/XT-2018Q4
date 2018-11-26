using System;

namespace Epam.Task1._7
{
    class Program
    {
        public static int GenerateNumber(Random random)
        {
            return random.Next(100);
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
                Console.Write(array[i] + " ");
            }
        }
        public static void SortArray(int[] array, int first, int last)
        {
            int pivot = array[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (array[i] < pivot && i <= last) i++;
                while (array[j] > pivot && j >= first) j--;
                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (j > first) SortArray(array, first, j);
            if (i < last) SortArray(array, i, last);
        }
        static void Main(string[] args)
        {
            int[] array = new int[30];
            FillArray(array);
            Console.WriteLine("Unsorted array: ");
            PrintArray(array);
            Console.Write(Environment.NewLine);
            SortArray(array,0,29);
            Console.WriteLine("Sorted array: ");
            PrintArray(array);
        }
    }
}
