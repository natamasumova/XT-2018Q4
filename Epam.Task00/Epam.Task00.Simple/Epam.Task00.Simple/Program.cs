using System;

namespace Epam.Task00.Sequence
{
    class Program
    {
        static bool IsSimple(uint n)
        {
            int i = 2;
            while (i < n)
            {
                if (n % i == 0) return false;
                i++;
            }
            return true;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter N: ");
                uint N = uint.Parse(Console.ReadLine());
                Console.WriteLine(IsSimple(N));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}