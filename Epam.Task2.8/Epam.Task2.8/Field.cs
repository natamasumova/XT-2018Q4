using System;

namespace Epam.Task2._8
{
    public class Field
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Field(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool IsBusy(double coordX, double coordY)
        {
            throw new NotImplementedException();
        }
    }
}
