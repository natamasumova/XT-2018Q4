namespace Epam.Task2._8
{
    public abstract class Monster : FieldObject
    {
        protected int Damage { get; set; }
        protected double Step { get; set; }

        public abstract void Bite();
        public abstract void Eat();
        public abstract void Move();
    }
}
