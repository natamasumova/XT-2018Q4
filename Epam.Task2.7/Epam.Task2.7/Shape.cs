using System;

namespace Epam.Task2._7
{
    public abstract class Shape
    {
        protected double CenterX { get; set; }
        protected double CenterY { get; set; }

        public abstract double GetCenterX();
        public abstract double GetCenterY();
        public abstract double GetWidth();
        public abstract double GetHeight();

        public override string ToString()
        {
            return $"Center coodrinates: ({GetCenterX()}; {GetCenterY()}){Environment.NewLine}" +
                   $"Width: {GetWidth()}{Environment.NewLine}" +
                   $"Height: {GetHeight()}{Environment.NewLine}";
        }
    }
}
