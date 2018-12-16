using System;
using System.Threading;

namespace Epam.Task4._3
{
    public class Program
    {
        public event EventHandler FinishedSort;
        public static int Compare(string string1, string string2)
        {
            int i = 0;
            while (i < string1.Length && i < string2.Length)
            {
                if (string1[i] > string2[i])
                {
                    return 1;
                }
                else if (string1[i] < string2[i])
                {
                    return -1;
                }
                i++;
            }
            return 0;
        }

        public static int Compare(int num1, int num2)
        {
            if (num1 > num2)
            {
                return 1;
            }
            else if (num1 < num2)
            {
                return -1;
            }
            else return 0;
        }
        public static int Compare(double num1, double num2)
        {
            if (num1 > num2)
            {
                return 1;
            }
            else if (num1 < num2)
            {
                return -1;
            }
            else return 0;
        }
        public static int Compare(char char1, char char2)
        {
            if (char1 > char2)
            {
                return 1;
            }
            else if (char1 < char2)
            {
                return -1;
            }
            else return 0;
        }
        public static void Sort<T>(T[] array, Func<T, T, int> compare)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (compare(array[j], array[j + 1]) > 0)
                    {
                        var tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
            SortIsFinished(EventArgs.Empty);
        }

        public static void PrintArray<T>(T[] array)
        {
            int i = 0;
            while (i < array.Length)
            {
                Console.Write($"{array[i]} ");
                i++;
            }
            Console.WriteLine(Environment.NewLine);
        }

        public static void SortThread<T>(T[] array, Func<T, T, int> compare)
        {
            var thread = new Thread(() => Sort(array, compare));
            thread.Start();
        }
        private static void SortIsFinished(EventArgs e)
        {
            Console.WriteLine("The sorting has been finished!");
        }

        public static void Main(string[] args)
        {
            int[] array = { 65, 3, 67, 8, 4, 34, 4, 2, 9, 5, 12 };
            try
            {
                Sort(array, Compare);
                PrintArray(array);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
