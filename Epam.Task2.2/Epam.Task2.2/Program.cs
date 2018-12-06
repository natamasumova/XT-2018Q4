using System;

namespace Epam.Task2._2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter A: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter B: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter C: ");
                    double c = double.Parse(Console.ReadLine());

                    Triangle triangle = new Triangle(a, b, c);
                    Console.WriteLine(triangle.ToString());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect input. Try again please");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
