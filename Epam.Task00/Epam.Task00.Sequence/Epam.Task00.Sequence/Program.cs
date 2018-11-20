using System;

namespace Epam.Task00.Sequence
{
    class Program
    {
        static string Sequence(int n)
        {
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                result += i;
                if (i < n) result += ", ";
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int N = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Sequence(N));
        }
    }
}