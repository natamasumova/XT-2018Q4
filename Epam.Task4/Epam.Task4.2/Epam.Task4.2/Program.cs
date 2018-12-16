using System;

namespace Epam.Task4._2
{
    public class Program
    {
        public static int Compare(string string1, string string2)
        {
            if (string1 == null || string2 == null)
            {
                throw new ArgumentException("There cannot be null elements in array.");
            }

            if (string1.Length < string2.Length)
            {
                return -1;
            }
            else if (string1 == string2)
            {
                return 0;
            }
            else return 1;
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

        public static void Main(string[] args)
        {
            string[] stringArray = { "Нельзя", "просто", "так", "взять", "и", "не", "использовать", "делегат" };
            try
            {
                Sort(stringArray, Compare);
                PrintArray(stringArray);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
