using System;

namespace Homework10_Part1
{
    public abstract class Alien
    {
        private int health;
        private string name;

        public Alien(int health, string name)
        {
            this.health = health;
            this.name = name;
        }

        public int GetHealth()
        {
            return health;
        }
        public void SetHealth(int health)
        {
            this.health = health;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public abstract int GetDamage();
    }
}
