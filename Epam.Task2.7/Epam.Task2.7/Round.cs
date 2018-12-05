using System;

namespace Epam.Task2._7
{
    public class Round : Figure
    {
        public double Radius { get; set; }

        public Round(double radius, double centerX, double centerY)
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
            return Radius * 2;
        }

        public override double GetHeight()
        {
            return Radius * 2;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"Type: Round{Environment.NewLine}" + base.ToString() + $"{Environment.NewLine}Radius: {Radius}";
        }
    }
}