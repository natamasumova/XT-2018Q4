using System;

namespace Epam.Task2._2
{
    public class Triangle
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("All sides should be positive. Try again, please");
            }
            if (a + b < c)
            {
                throw new Exception("The biggest side should be more than sum of another sides. Try again, please");
            }
            A = a;
            B = b;
            C = c;
        }

        public double GetHeight()
        {
            double triangleHeight = A * A - (A * A - B * B) / (2 * C) - C / 2;
            return triangleHeight;
        }

        public double GetPerimeter()
        {
            return A * B * C;
        }
        
        public double GetArea()
        {
            return (C * GetHeight()) / 2;
        }

        public override string ToString()
        {
            return $"Perimeter: {GetPerimeter()}{Environment.NewLine}Area: {GetArea()}{Environment.NewLine}";
        }
    }
}
