using System;

namespace Epam.Task2._1_2._6
{
    public class Round
    {
        protected double CenterX { get; set; }
        protected double CenterY { get; set; }
        protected double Radius { get; set; }

        protected double Circumflex => 2 * Math.PI * Radius;
        protected double Area => Math.PI * Radius * Radius;

        public Round(double centerX, double centerY, double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("The radius should be positive");
            }
            CenterX = centerX;
            CenterY = centerY;
            Radius = radius;
        }
        
        public override string ToString()
        {
            return $"X center coordinate: {this.CenterX}{Environment.NewLine}" +
                   $"Y center coordinate: {this.CenterY}{Environment.NewLine}" +
                   $"Radius: {this.Radius}{Environment.NewLine}" +
                   $"Circumflex: {this.Circumflex}{Environment.NewLine}" +
                   $"Area: {this.Area}";
        }
    }
    
}
