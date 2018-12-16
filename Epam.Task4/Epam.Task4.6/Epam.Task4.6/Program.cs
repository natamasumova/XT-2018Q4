using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task4._6
{
    public class Program
    {
        public static bool IsPositive(int x)
        {
            return x >= 0;
        }
        public static List<int> SeekPositive(List<int> array)
        {
            List<int> array2 = new List<int>();
            foreach (var element in array)
            {
                if (element > 0)
                {
                    array2.Add(element);
                }
            }
            return array2;
        }

        public static List<int> SeekPositive(List<int> array, Predicate<int> isPositive)
        {
            List<int> array2 = new List<int>();
            foreach (var element in array)
            {
                if (isPositive(element))
                {
                    array2.Add(element);
                }
            }
            return array2;
        }

        public static long CountTime(List<int> array)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            SeekPositive(array);
            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }

        public static long CountTime(List<int> array, Predicate<int> predicate)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            SeekPositive(array, predicate);
            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }

        public static long CountTimeFromLinq(List<int> array)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            var query = from item in array
                        where item > 0
                        select item;
            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }

        public static void PrintTime(long time)
        {
            Console.WriteLine($"RunTime: {time}");
        }

        public static void Main(string[] args)
        {
            Predicate<int> positive = new Predicate<int>(IsPositive);
            List<int> array = new List<int> { 6, 4, -3, -8, 0, 5, -34, 0, 6 };

            PrintTime(CountTime(array));
            PrintTime(CountTime(array, positive));
            PrintTime(CountTime(array, delegate (int x) { return x >= 0; }));
            PrintTime(CountTime(array, (x) => x >= 0));
            PrintTime(CountTimeFromLinq(array));
        }
    }
}
