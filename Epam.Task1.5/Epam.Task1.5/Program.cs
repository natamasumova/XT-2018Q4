using System;
using System.Collections;
using System.Collections.Generic;

namespace Epam.Task1._5
{
    class Program
    {
        static int SumOfNumbers(List<int> numbers)
        {
            int sum = 0;
            foreach(var i in numbers)
            {
                sum += i;
            }
            return sum;
        }
        static List<int> GetNumbers(int limit)
        {
            List<int> numbers = new List<int>();
            int i = 1;
            while (i < 1000)
            {
                if (i % 3 == 0 || i % 5 == 0) numbers.Add(i);
                i++;
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers = GetNumbers(1000);
            Console.WriteLine($"The sum is {SumOfNumbers(numbers)}");
        }
    }
}
