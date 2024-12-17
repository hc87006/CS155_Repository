/// Homework No.5  Exercise No.1
/// File Name:     ArrayDuplicator.cs 
/// @author:       Haydn Christian
/// Date:          Sep. 24, 2024
///  
/// Problem Statement: Copy a pre-defined array
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Create an initial array and print the values
/// 2. Create a second array with the same length as the first
/// 3. Use a for loop to assign the first array's values to the second array
/// 
/// Classes needed and Purpose (ArrayDuplicator) 
/// main class - ArrayDuplicator 
namespace Homework5_Part1
{
    class ArrayDuplicator
    {
        static void Main(string[] args)
        {
            double[] array = { 2, 3, 5, 1, 3, 4 };

            Console.WriteLine("The current array contains the following values:");
            
            for (int i = 0; i < array.Length; i++)
            { 
            Console.WriteLine(array[i]);
            }
            
            double[] array2 = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }

            Console.WriteLine("Here is the newly copied array:");

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
            
            Console.ReadLine();
        }
    }
}