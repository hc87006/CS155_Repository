namespace Homework10_Part1
{
    public class OgreAlien : Alien
    {
        public OgreAlien(int health, string name) : base(health, name) { }

        public override int GetDamage()
        {
            return 6;
        }
    }
}
