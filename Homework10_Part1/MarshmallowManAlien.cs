namespace Homework10_Part1
{
    public class MarshmallowManAlien : Alien
    {
        public MarshmallowManAlien(int health, string name) : base(health, name) { }

        public override int GetDamage()
        {
            return 1;
        }
    }
}
