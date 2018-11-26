using System;

namespace Epam.Task1._1
{
    class Rectangle
    {
        public int a;
        public int b;
        public Rectangle(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException();
            }
            this.a = a;
            this.b = b;
        }
        public int GetArea(int width, int height)
        {
            return width * height;
        }
    }
}