using System;

namespace Homework10_Part1
{
    public class AlienPack
    {
        private Alien[] aliens;

        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }

        public void AddAlien(Alien newAlien, int index)
        {
            aliens[index] = newAlien;
        }

        public Alien[] GetAliens()
        {
            return aliens;
        }

        public int CalculateDamage()
        {
            int totalDamage = 0;
            foreach (Alien alien in aliens)
            {
                if (alien != null)
                    totalDamage += alien.GetDamage();
            }
            return totalDamage;
        }
    }
}
