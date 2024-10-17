/// Homework No. 8 Exercise No.1
/// File Name:     program.cs 
/// @author:       Haydn Christian
/// Date:          Oct. 15, 2024
///  
/// Problem Statement: (Create an Odometer) 
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

namespace Homework7_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odometer trip1 = new Odometer();
            trip1.Add(50, 10);
            Console.WriteLine(trip1.ToString());
            Console.WriteLine("Fuel used for trip1: " + trip1.MPG());

            Odometer trip2 = new Odometer();
            trip2.Add(100, 20);
            Console.WriteLine(trip2.ToString());
            Console.WriteLine("Fuel used for trip2: " + trip2.MPG());

            trip1.Reset();
            Console.WriteLine(trip1.ToString());
        }
    }
}