using System;

namespace Epam.Task2._8
{
    public class Cherry : Bonus
    {
        public Cherry(Field f, double positionX, double positionY)
        {
            if (Math.Abs(positionX) < f.Width || Math.Abs(positionY) < f.Height)
            {
                throw new ArgumentException();
            }
            PositionX = positionX;
            PositionY = positionY;
        }
        public override void Upgrade(Player p) { }
    }
}
