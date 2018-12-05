using System;
using System.Text;

namespace Epam.Task2._4
{
    public class MyString
    {
        private char[] Array { get; set; }

        public MyString(string input)
        {
            Array = input.ToCharArray();
        }

        public bool Equals(MyString obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            int count = 0;
            while (count < obj.Array.Length)
            {
                if (this.Array[count] != obj.Array[count])
                {
                    return false;
                }
                count++;
            }
            return true;
        }

        public char[] Concat(MyString obj)
        {
            int length = this.Array.Length + obj.Array.Length, n = 0, count;
            char[] array = new char[length];
            while(n < this.Array.Length)
            {
                array[n] = this.Array[n];
                ++n;
            }
            count = n;
            n = 0;
            while(n < obj.Array.Length)
            {
                array[count] = obj.Array[n];
                count++;
                n++;
            }
            return array;
        }

        public int IndexOf(char ch)
        {
            int i = 0;
            while (i < this.Array.Length)
            {
                if (this.Array[i] == ch)
                {
                    return i;
                }
            }
            return -1;
        }

        public char[] ConvertToCharArray(MyString obj)
        {
            if (this.GetType() == typeof(string))
            {
                char[] array = { };
                foreach (var k in this.Array)
                {
                    for (int i = 0; i < this.Array.Length; i++)
                    {
                        array[i] = k;
                    }
                }
                return array;
            }
            return this.Array;
        }

        public string ConvertFromCharArray(MyString obj)
        {
            return obj.Array.ToString();
        }

        public StringBuilder ConvertToStringBuilder(MyString obj)
        {
            return new StringBuilder(this.Array.ToString());
        }
    }
}
