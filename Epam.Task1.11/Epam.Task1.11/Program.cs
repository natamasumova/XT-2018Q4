using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.Task1._11
{
    class Program
    {
        static char[] GetSeparator(string str)
        {
            StringBuilder sb = new StringBuilder();
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsSeparator(charArray[i]) == true ||
                    char.IsDigit(charArray[i]) == true ||
                    char.IsPunctuation(charArray[i]) == true)
                {
                    sb.Append(charArray[i].ToString());
                }
            }
            return sb.ToString().ToCharArray();
        }

        static string[] GetStringArray(string str)
        {
            return str.Split(GetSeparator(str), StringSplitOptions.RemoveEmptyEntries);
        }

        static int CountAverage(string str)
        {
            int count = 0;
            int average = 0;
            string[] stringArray = GetStringArray(str);
            List<int> stringLengths = new List<int>();
            foreach (string s in stringArray)
            {
                stringLengths.Add(s.Length);
            }

            foreach (int i in stringLengths)
            {
                average += i;
                count++;
            }
            return average / count;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the string: ");
                string someString = Console.ReadLine();
                Console.WriteLine($"The average length of words is {CountAverage(someString)}");
            }
        }
    }
}
