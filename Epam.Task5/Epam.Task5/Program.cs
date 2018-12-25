using System;
using System.IO;


namespace Epam.Task5
{
    class Program
    {
        private static bool flagForWrite = true;
        private static string catalogPath;

        static void Main() // Прежде чем запускать проверьте в режиме отладки верное ли значение Type в классе Restoration.cs
        {
            try
            {
                if (flagForWrite)
                {
                    flagForWrite = false;
                    Console.WriteLine("Введите путь к каталогу: ");
                    catalogPath = Console.ReadLine();
                }

                var watcher = new Watcher(catalogPath);
                Console.ReadLine();
                watcher.Dispose();
            }

            catch
                (DirectoryNotFoundException
                exception)
            {
                Console.WriteLine(exception.Message);

                Console.WriteLine("Создать его? y/n");

                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    try
                    {
                        Directory.CreateDirectory(exception.Message);
                        Console.Clear();

                        Main();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
