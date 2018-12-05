using System;

namespace Epam.Task2._7
{
    public class Ring : Round
    {
        public double InnerRadius { get; set; }

        public Ring(double radius, double innerRadius, double centerX, double centerY)
               : base (radius, centerX, centerY)
        {
            if (radius <= 0 || innerRadius <= 0)
            {
                throw new Exception("This parameter should be positive");
            }
            if (radius <= innerRadius)
            {
                throw new Exception("The main radius should be bigger than the inner radius");
            }
            Radius = radius;
            InnerRadius = innerRadius;
            CenterX = centerX;
            CenterY = centerY;
        }

        public override double GetWidth()
        {
            return Radius * 2;
        }

        public override double GetHeight()
        {
            return Radius * 2;
        }

        public override double GetArea()
        {
            return Math.PI * (Radius * Radius - InnerRadius * InnerRadius);
        }

        public override string ToString()
        {
            return $"Type: Ring{Environment.NewLine}" + base.ToString() + $"{Environment.NewLine}Inner radius: {InnerRadius}";
        }
    }
}
