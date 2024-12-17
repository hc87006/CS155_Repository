/// Homework No. 9 Exercise No. 1
/// File Name:     Program.cs 
/// @author:       Haydn Christian
/// Date:          Oct. 28, 2024
///  
/// Problem Statement: (what you want the code to do) 
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. 
/// 2. 
/// 3. 
/// etc. 
/// 
/// Classes needed and Purpose (Input, Processing, Output) 
/// main class - GoodTime  

using System;

namespace Homework9_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Aaron");
            Person person2 = new Person("Bob");

            Console.WriteLine(person1.Equals(person2));

            Vehichle vehichle1 = new Vehichle();
            vehichle1.SetENum("1234");
            vehichle1.SetCylinders(4);
            vehichle1.SetOwner(person1.GetName());
            Console.WriteLine(vehichle1.ToString());

            Truck truck1 = new Truck();
            truck1.SetENum("5678");
            truck1.SetCylinders(6);
            truck1.SetOwner(person2.GetName());
            truck1.SetLoadCapacity(1000);
            truck1.SetTowCapacity(2000);
            Console.WriteLine(truck1.ToString());

            

        }
    }
}