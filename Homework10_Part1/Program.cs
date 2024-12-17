/// Homework No.10 Exercise No.1
/// File Name:     Program.cs 
/// @author:       Haydn Christian
/// Date:          Nov. 11, 2024
///  
/// Problem Statement: (Simulate combat with aliens) 
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Create an Alien class and a method to calculate damage
/// 2. Create Alien Subclasses 
/// 3. Test the Alien damage in an alien pack in the program
/// etc. 
/// 
/// Classes needed and Purpose (Input, Processing, Output) 
/// main class - GoodTime  

using System;

namespace Homework10_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlienPack pack = new AlienPack(3);
            pack.AddAlien(new SnakeAlien(100, "Snake"), 0);
            pack.AddAlien(new OgreAlien(100, "Ogre"), 1);
            pack.AddAlien(new MarshmallowManAlien(100, "Marshmallow"), 2);

            Console.WriteLine("Total damage by alien pack: " + pack.CalculateDamage());
        }
    }
}
