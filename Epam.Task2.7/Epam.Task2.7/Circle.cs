using System;

namespace Epam.Task2._7
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, double centerX, double centerY)
        {
            if (radius <= 0)
            {
                throw new Exception("This parameter should be positive");
            }
            Radius = radius;
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
            return Radius;
        }

        public override double GetHeight()
        {
            return Radius;
        }
        public override string ToString()
        {
            return $"Type: Circle{Environment.NewLine}" + base.ToString();
        }
    }
}
