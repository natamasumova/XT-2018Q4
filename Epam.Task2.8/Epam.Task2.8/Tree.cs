using System;

namespace Epam.Task2._8
{
    public class Tree : Obstacle
    {
        public Tree(Field f, double positionX, double positionY)
        {
            if (Math.Abs(positionX) < f.Width || Math.Abs(positionY) < f.Height)
            {
                throw new ArgumentException();
            }
            PositionX = positionX;
            PositionY = positionY;
        } 
        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
