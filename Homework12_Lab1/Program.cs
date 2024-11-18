/// Homework No.12 Exercise No.2
/// File Name:     Program.cs 
/// @author:       Haydn Christian
/// Date:          Nov. 18, 2024
///  
/// Problem Statement: (Create a delegate for a rectangle that points to both the perimiter and area) 
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Create a delegate for the rectangle
/// 2. Create a method for the perimiter and area
/// 3. Use the delegate to point to the methods and print results
/// etc. 
/// 
/// Classes needed and Purpose (Program) 
/// main class - Program

using System;
using static Program.Rectangle;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        RectangleDelegate rectDel = new RectangleDelegate(rect.GetPerimeter);
        // Create delegate and rectangle object, point to GetPerimeter
        rectDel += rect.GetArea;
        // Also point to GetArea
        rectDel.Invoke(4.9, 5.5);
        // Invoke GetArea and GetPerimeter methods
    }

    public class Rectangle
    {
        public delegate void RectangleDelegate(double width, double height);

        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine($"Perimeter: {2 * (width + height)}");
            // Calculate and print perimeter
        }
        public void GetArea(double width, double height)
        {
            Console.WriteLine($"Area: {width * height}");
            // Calculate and print area
        }
    }
}