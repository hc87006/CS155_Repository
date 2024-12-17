/// Homework No.5 Exercise No.2
/// File Name:     ArrayReverser.cs 
/// @author:       Haydn Christian
/// Date:          Sep. 24, 2024
///  
/// Problem Statement: reverse a pre-defined array
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Initialize starting array, print
/// 2. Take last index of starting array, make it first index of reversed array, repeat
/// 3. Print reversed index
/// 
/// Classes needed and Purpose (ArrayReverser) 
/// main class - ArrayReverser 
namespace Homework5_Part2
{
    class ArrayReverser
    {
        static void Main(string[] args)
        {
            // Normal array
            
            int[] array = { 1, 2, 3, 4, 5 };
            // define initial array

            Console.WriteLine("The current array contains the following values:");

            for (int i = 0; i < array.Length; i++)
            // start at 0, end and array length, increment every loop
            {
                Console.WriteLine(array[i]);
                // write value at current array index
            }
            
            // Reverse array

            int[] rArray = new int [array.Length];
            // define reversed array length
            int r = array.Length - 1;
            // reverse int / instead of starting at the first index, start at the last

            for (int i = 0; i < rArray.Length; i++)
            {
                rArray[i] = array[r];
                r--;
                // reverse array i = 0, array r = 4
                // increase i by 1 every loop, decrease r by 1 every loop
                //
                // rArray index 0 = array index 4 (1, 5)
                // rArray index 1 = array index 3 (2, 4)
                // so on
            }

            Console.WriteLine("Here is your newly reversed array:");
            
            for (int i = 0; i < rArray.Length; i++)
            {
                Console.WriteLine(rArray[i]);
            }
            // same as above


            Console.ReadLine();
        }
    }
}