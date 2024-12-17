namespace Homework10_Part1
{
    public class SnakeAlien : Alien
    {
        public SnakeAlien(int health, string name) : base(health, name) { }

        public override int GetDamage()
        {
            return 10;
        }
    }
}
