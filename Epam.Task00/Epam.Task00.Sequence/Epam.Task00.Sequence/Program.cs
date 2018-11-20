using System;

namespace Epam.Task00.Sequence
{
    class Program
    {
        static string Sequence(uint n)
        {
            string result = "";
            int i = 1;
            while (i < n)
            {
                result += i + ", ";
                i++;
            }
            result += n;
            return result;
        }
        
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter N: ");
                uint N = uint.Parse(Console.ReadLine());
                Console.WriteLine(Sequence(N));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}