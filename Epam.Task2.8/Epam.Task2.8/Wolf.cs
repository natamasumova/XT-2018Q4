using System;

namespace Epam.Task2._8
{
    public class Wolf : Monster
    {
        public Wolf(Field f, int damage, double step, double positionX, double positionY)
        {
            if (damage <= 0 || step <= 0 || Math.Abs(positionX) < f.Width || Math.Abs(positionY) < f.Height)
            {
                throw new ArgumentException();
            }
            Damage = damage;
            Step = step;
        }

        public override void Bite() { }
        public override void Eat() { }
        public override void Move() { }
    }
}
