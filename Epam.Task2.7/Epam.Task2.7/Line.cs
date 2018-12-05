using System;

namespace Epam.Task2._7
{
    public class Line : Shape
    {
        public double Width { get; set; }

        public Line(double width, double centerX, double centerY)
        {
            if (width <= 0)
            {
                throw new Exception("This parameter should be positive");
            }
            Width = width;
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
            return 0.3;
        }
        public override string ToString()
        {
            return $"Type: Line{Environment.NewLine}" + base.ToString();
        }
    }
}
