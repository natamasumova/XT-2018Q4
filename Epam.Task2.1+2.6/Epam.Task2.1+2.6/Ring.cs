using System;

namespace Epam.Task2._1_2._6
{
    public class Ring : Round
    {
        private double InnerRadius { get; set; }

        private new double Circumflex => 2 * Math.PI * InnerRadius + 2 * Math.PI * Radius;
        private new double Area => Math.PI * (Radius * Radius - InnerRadius * InnerRadius);

        public Ring(double centerX, double centerY, double radius, double innerRadius)
               : base(centerX, centerY, radius)
        {
            if (radius <= 0 || innerRadius <= 0)
            {
                throw new ArgumentException("The radiuses should be positive");
            }
            CenterX = centerX;
            CenterY = centerY;
            Radius = radius;
            InnerRadius = innerRadius;
        }
    }
}
