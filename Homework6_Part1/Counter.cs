/// Homework No.6  Exercise No.1
/// File Name:     Counter.cs 
/// @author:       Haydn Christian
/// Date:          Sep. 30, 2024
///  
/// Problem Statement: Update the value of a counter using user input 
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Use a getter and setter to update value using user input (increment, decrement)
/// 2. Display value on user input
/// 3. Exit when user inputs exit command
/// 
/// Classes needed and Purpose - Counter (Updating values based on input), Program (Displaying output in console) 
/// main class - Counter  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_Part1
{
    class Counter
    {
        private int value;

        public void setValue(int value)
        {
            this.value = value;
        }

        public int getValue()
        {
            return value;
        }

        public int Increment()
        {
            value++;
            return value;
        }

        public int Decrement()
        {
            if (value == 0)
            {
                Console.WriteLine("Value cannot be less than 0");
                return value;
            }
            else
            {
                value--;
            }

            return value;
        }

        public string toString()
        {
            return "\nYour current value is " + value + "\n";
        }

        public string Reset()
        {
            value = 0;
            return "\nYour value has been reset to " + value + "\n";
        }
    }

}