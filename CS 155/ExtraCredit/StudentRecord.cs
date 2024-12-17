using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCredit
{
    internal class StudentRecord
    {
        private int quiz1;

        public void setQuiz1(int quiz1)
        {
            this.quiz1 = quiz1;
        }

        public int getQuiz1()
        {
            return quiz1;
        }
        // getter and setter for quiz 1

        private int quiz2;

        public void setQuiz2(int quiz2)
        {
            this.quiz2 = quiz2;
        }

        public int getQuiz2()
        {
            return quiz2;
        }

        // getter and setter for quiz 2

        private int quiz3;

        public void setQuiz3(int quiz3)
        {
            this.quiz3 = quiz3;
        }

        public int getQuiz3()
        {
            return quiz3;
        }

        // getter and setter for quiz 3

        private int midterm;

        public void setMidterm(int midterm)
        {
            this.midterm = midterm;
        }

        public int getMidterm()
        {
            return midterm;
        }

        // getter and setter for midterm

        private int finalExam;

        public void setFinalExam(int finalExam)
        {
            this.finalExam = finalExam;
        }

        public int getFinalExam()
        {
            return finalExam;
        }

        // getter and setter for final exam

        private double finalNumericGrade;

        public void setFinalNumericGrade(double finalNumericGrade)
        {
            this.finalNumericGrade = finalNumericGrade;
        }

        public double getFinalNumericGrade()
        {
            return finalNumericGrade;
        }

        // getter and setter for final numeric grade

        private char letterGrade;

        public void setLetterGrade(char letterGrade)
        {
            this.letterGrade = letterGrade;
        }

        public char getLetterGrade()
        {
            return letterGrade;
        }

        // getter and setter for letter grade

        public void calculateFinalNumericGrade()
        {
            finalNumericGrade = 
                (((((quiz1 + quiz2 + quiz3) / 3) * 10) * 0.25) +
                (midterm * 0.35) +
                (finalExam * 0.4));
        }

        // calculate final numeric grade

        public void calculateLetterGrade()
        {
            if (finalNumericGrade >= 90)
            {
                letterGrade = 'A';
            }
            else if (finalNumericGrade >= 80)
            {
                letterGrade = 'B';
            }
            else if (finalNumericGrade >= 70)
            {
                letterGrade = 'C';
            }
            else if (finalNumericGrade >= 60)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }
        }

        // calculate letter grade

        public string toString()
        {
            return "\nQuiz 1: " + quiz1 + "\nQuiz 2: " + quiz2 + "\nQuiz 3: " + quiz3 + "\nMidterm: " + midterm + "\nFinal Exam: " + finalExam + "\nFinal Numeric Grade: " + finalNumericGrade + "\nLetter Grade: " + letterGrade;
        }

        // return string of student record
    }
}
