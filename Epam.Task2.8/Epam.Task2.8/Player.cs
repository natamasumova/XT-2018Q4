namespace Epam.Task2._8
{
    public class Player : FieldObject
    {
        private int Strength { get; set; }
        private int Agility { get; set; }
        private int Intellect { get; set; }
        private int Stamina { get; set; }
        private int HitPoints { get; set; }

        public Player()
        {
            Strength = 20;
            Agility = 20;
            Intellect = 20;
            Stamina = 20;
            HitPoints = 100;
            PositionX = 0;
            PositionY = 0;
        }

        public Player(int strength, int agility, int intellect, int stamina, int hitpoints)
        {
            Strength = strength;
            Agility = agility;
            Intellect = intellect;
            Stamina = stamina;
            HitPoints = hitpoints;
            PositionX = 0;
            PositionY = 0;
        }

        public void MoveTo(double coordX, double coordY) { }
        public void TakeBonus(Bonus b) { }
    }
}
