using System;

namespace Epam.Task2._1_2._6
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Round round = new Round(-10, 3.5, 15);
                Console.WriteLine(round.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
