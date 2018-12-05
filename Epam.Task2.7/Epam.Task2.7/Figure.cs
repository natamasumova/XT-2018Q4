namespace Epam.Task2._7
{
    public abstract class Figure : Shape
    {
        public abstract double GetArea();

        public override string ToString()
        {
            return base.ToString() + $"Area: {GetArea()}";
        }
    }
}
