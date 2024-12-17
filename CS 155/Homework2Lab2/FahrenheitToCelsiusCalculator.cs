/// Homework No.2  Exercise No.2
/// File Name:     FahrenheitToCelsiusCalculator.cs 
/// @author:       Haydn Christian
/// Date:          Aug. 30, 2024
///  
/// Problem Statement: (what you want the code to do) 
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Prompt user to enter temperature in fahrenheit
/// 2. Convert fahrenheit string into float
/// 3. Use fahrenheit float to calculate celsius float
/// 4. Display celsius float
/// 
/// Classes needed and Purpose - FahrenheitToCelsiusCalculator 
/// main class - FahrenheitToCelsiusCalculator
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework2Lab2
{
    class FahrenheitToCelsiusCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert temperature in Fahrenheit");
            /// Prompt user for temperature in fahrenheit
            
            string fahrenheitStr = Console.ReadLine();
            /// Read user input and assign to fahrenheitStr String
            
            float fahrenheitFlt = float.Parse(fahrenheitStr);
            /// Convert fahrenheitStr string to float (fahrenheitFlt)
            
            float step1 = fahrenheitFlt - 32;
            float step2 = step1 * 5;
            float celsius = (float)Math.Round((step2 / 9), 1);
            /// degreesC = 5(degreesF – 32)/9 is broken down into 3 steps
            /// (Using 87 as fahrenheit temperature for example)
            /// Step 1: 87-32=55
            /// Step 2: 55×5=275
            /// Step 3: 275÷9=30.555 repeating
            /// 
            /// Use Math.Round tto round result to the nearest tenth (30.5)
            /// fahrenheitStr (87) is successfully converted into Celsius (30.5)

            Console.WriteLine(fahrenheitStr + "° fahrenheit is " + celsius + "° celsius");
            /// Display result
            
            Console.ReadLine();
            /// Pause on screen
        }
    }
}