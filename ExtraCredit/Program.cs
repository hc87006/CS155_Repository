/// Homework No.8  Exercise No. Extra Credit
/// File Name:     filename.cs 
/// @author:       Haydn Christian
/// Date:          Oct. 11, 2024
///  
/// Problem Statement: Calculate the final grade of a student based on their quiz scores, midterm score, and final exam score
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Have user input scores
/// 2. Use the StudentRecord class to store and calculate the final grade
/// 3. Display the final grade
/// 
/// Classes needed and Purpose (Program.cs, StudentRecord.cs) 
/// main class - StudentRecord.cs 
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentRecord student = new StudentRecord();
            // instantiate new student record

            Console.WriteLine("Enter the student's quiz 1 score: (0-10)");
            student.setQuiz1(int.Parse(Console.ReadLine()));
            // set quiz 1 score

            Console.WriteLine("Enter the student's quiz 2 score: (0-10)");
            student.setQuiz2(int.Parse(Console.ReadLine()));
            // set quiz 2 score

            Console.WriteLine("Enter the student's quiz 3 score: (0-10)");
            student.setQuiz3(int.Parse(Console.ReadLine()));
            // set quiz 3 score

            Console.WriteLine("Enter the student's midterm score: (0-100)");
            student.setMidterm(int.Parse(Console.ReadLine()));
            // set midterm score

            Console.WriteLine("Enter the student's final exam score: (0-100)");
            student.setFinalExam(int.Parse(Console.ReadLine()));
            // set final exam score

            student.calculateFinalNumericGrade();
            // calculate final numeric grade

            student.calculateLetterGrade();
            // calculate final letter grade

            Console.WriteLine("The student's final grade is: " + student.toString());
            // display final grade
        }
    }
}