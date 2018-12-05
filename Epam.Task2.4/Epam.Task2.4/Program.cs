using System;

namespace Epam.Task2._4
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyString str1 = new MyString("Aynane");
            MyString str2 = new MyString("Aynane");
            bool dbg = str1.Compare(str2);
            char[] array = str1.Concat(str2);
        }
    }
}
