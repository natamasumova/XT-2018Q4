using System;

namespace Epam.Task4._1
{
    public class Program
    {
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
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if (compare(array[j], array[j + 1]) > 0)
                    {
                        var tmp = array[j];
                        array[j] = array[j + 1];
                        array[j+1] = tmp;
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
            string[] stringArray = { "Нельзя", "просто", "так", "взять", "и", "не", "использовать", "делегат"};
            int[] intArray = { 7, 4, 8, 9, 456, 5, 697, 34, 45, 34, 34, 58 };
            double[] doubleArray = { 5, 8, 5.003, 3.14, 64, 74, 3.1443, 46.54676 };
            char[] charArray = { 's', 'o', 'r', 't', 'a', 'r', 'r', 'a', 'y' };

            Sort(stringArray, Compare);
            Sort(intArray, Compare);
            Sort(doubleArray, Compare);
            Sort(charArray, Compare);

            PrintArray(stringArray);
            PrintArray(intArray);
            PrintArray(doubleArray);
            PrintArray(charArray);
        }
    }
}
