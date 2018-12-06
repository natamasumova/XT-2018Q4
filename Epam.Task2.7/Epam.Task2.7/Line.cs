using System;

namespace Epam.Task2._7
{
    public class Line : Shape
    {
        private double Width { get; set; }
        private double StartX { get; set; }
        private double StartY { get; set; }
        private double EndX { get; set; }
        private double EndY { get; set; }


        public Line(double width, double startX, double startY, double endX, double endY)
        {
            if (width <= 0)
            {
                throw new Exception("This parameter should be positive");
            }
            Width = width;
            StartX = startX;
            StartY = startY;
            EndX = endX;
            EndY = endY;
        }

        public override double GetCenterX()
        {
            return (StartX + EndX) / 2;
        }

        public override double GetCenterY()
        {
            return (StartY + EndY) / 2; ;
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
            return $"Type: Line{Environment.NewLine}" + base.ToString() + 
                   $"Start coordinates: ({StartX}; {StartY}){Environment.NewLine}" +
                   $"End coordinates: ({EndX}; {EndY}){Environment.NewLine}";
        }
    }
}
