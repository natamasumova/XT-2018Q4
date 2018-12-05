using System;

namespace Epam.Task2._3_2._5
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                DateTime date = Convert.ToDateTime("2000-01-25");
                User user1 = new User("Masumova", "Natalya", date, "Arturovna");
                User user2 = new User("Masumova", "Natalya", date);
                Console.WriteLine(user1.ToString());
                Console.WriteLine();
                Console.WriteLine(user2.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
