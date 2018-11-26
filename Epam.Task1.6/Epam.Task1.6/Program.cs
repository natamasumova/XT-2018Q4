using System;

namespace Epam.Task1._6
{
    class Program
    {
        [Flags]
        public enum FontAdjustment
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4
        }
        public static void ForAddingAdjustment(FontAdjustment fa)
        {
            if (fa.HasFlag(FontAdjustment.None))
            {
                fa = fa ^ FontAdjustment.None;
            }
        }
        public static void Main(string[] args)
        {   
            FontAdjustment fa = FontAdjustment.None;
            while (true)
            {
                try
                {
                    Console.WriteLine($"Parameters: {fa}");
                    Console.WriteLine("Enter:\n1 - Bold\n2 - Italic\n3 - Underline");
                    int number = int.Parse(Console.ReadLine());
                    switch (number)
                    {
                        case 1:
                            ForAddingAdjustment(fa);
                            fa = fa | FontAdjustment.Bold;
                            break;
                        case 2:
                            ForAddingAdjustment(fa);
                            fa = fa | FontAdjustment.Italic;
                            break;
                        case 3:
                            ForAddingAdjustment(fa);
                            fa = fa | FontAdjustment.Underline;
                            break;
                        default:
                            throw new ArgumentException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That's not a number. Try again, please");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Incorrect number. Try again, please");
                }
            }
        }
    }
}
