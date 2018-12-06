using System;

namespace Epam.Task2._7
{
    public class Rectangle : Figure
    {
        private double Width { get; set; }
        private double Height { get; set; }

        public Rectangle(double width, double height, double centerX, double centerY)
        {
            if (width <= 0 || height <= 0)
            {
                throw new Exception("This parameter should be positive");
            }
            Width = width;
            Height = height;
            CenterX = centerX;
            CenterY = centerY;
        }
        public override double GetCenterX()
        {
            return CenterX;
        }

        public override double GetCenterY()
        {
            return CenterY;
        }

        public override double GetWidth()
        {
            return Width;
        }

        public override double GetHeight()
        {
            return Height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return $"Type: Rectangle{Environment.NewLine}" + base.ToString();
        }
    }
}
