using System;

namespace Epam.Task1._1
{
    class Program
    {
        private static Rectangle CreateRectangle(int A, int B)
        {
            int a = A;
            int b = B;
            return new Rectangle(a, b);
        }
        
        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter b: ");
                    int b = int.Parse(Console.ReadLine());

                    Rectangle rectangle = CreateRectangle(a, b);
                    Console.WriteLine($"Area: {rectangle.GetArea(a, b)}");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The numbers should be positive. Try again, please");
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a number. Try again, please");
                }
            }
        }
    }
}
