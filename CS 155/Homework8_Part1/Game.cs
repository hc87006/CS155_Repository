using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Part1
{
    class Duelist
    {
        private string name;
        private int accuracy;
        private bool isAlive;
        private bool isWinner;

        public Duelist(string name, int accuracy, bool isAlive, bool isWinner)
        {
            this.name = name;
            this.accuracy = accuracy;
            this.isAlive = isAlive;
            this.isWinner = isWinner;
        }
        // duelist class with name, accuracy, check if still alive, and check if winner

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        // get and set name

        public int GetAccuracy()
        {
            return accuracy;
        }
        public void SetAccuracy(int accuracy)
        {
            this.accuracy = accuracy;
        }
        //get and set accuracy

        public bool GetIsAlive()
        {
            return isAlive;
        }
        public void SetIsAlive(bool isAlive)
        {
            this.isAlive = isAlive;
        }
        // get and set isAlive

        public bool GetIsWinner()
        {
            return isWinner;
        }
        public void SetIsWinner(bool isWinner)
        {
            this.isWinner = isWinner;
        }
        // get and set isWinner

        public void ShootAt(Duelist target)
        {
            Random rand = new Random();
            int chance = rand.Next(0, 200);
            // random number between 0 and 200

            if (chance < accuracy)
            {
                Console.Write($". Target is dead\n");
                target.SetIsAlive(false);
            }

            else
            {
                Console.Write($". Target is alive\n");
            }
            // if random number is less than accuracy, target is dead, else target is alive
        }
    }
}
