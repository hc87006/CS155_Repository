/// Homework No.12 Exercise No.1
/// File Name:     Program.cs 
/// @author:       Haydn Christian
/// Date:          Nov. 18, 2024
///  
/// Problem Statement: (Use a LINQ query to determine if someone is eleigbe for the kids menu, and if someone is above average height) 
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Create a LINQ query and add data
/// 2. Determine if person is under the age of 12, print
/// 3. Determine if person is above the average height, print
/// 
/// Classes needed and Purpose (Program) 
/// main class - Program 
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Person> People = new List<Person>();
        List<Person> KidsMealEligible = new List<Person>();
        List<Person> AboveAverageHeight = new List<Person>();
        // Initialize lists

        People.Add(new Person("John", 10, 4.5));
        People.Add(new Person("Jane", 22, 5.5));
        People.Add(new Person("Jack", 8, 4.0));
        People.Add(new Person("Jill", 12, 5.0));
        People.Add(new Person("Jim", 19, 5.5));
        // Add data

        int personCount = (from p in People select p).Count();
        double sum = 0;
        foreach (Person person in People)
        {
            sum += person.Height;
        }
        double averageHeight = sum / personCount;
        // Calculate average height

        Console.WriteLine($"Number of people: {personCount}");
        foreach (Person person in People)
        {
            Console.WriteLine($"{person.Name} (Age {person.Age}) is {person.Height} tall.");
        }
        // Print all people

        Console.WriteLine();
        Console.WriteLine($"Average height: {averageHeight}");
        Console.WriteLine("Kids under 12 are eligible for the kids menu");
        Console.WriteLine();
        // Print basic info

        KidsMealEligible.AddRange(from person in People where person.Age < 12 select person);
        foreach (Person person in KidsMealEligible)
        {
            Console.WriteLine($"{person.Name} (Age {person.Age}) is eligible for the kids meal.");
        }
        // Add kids meal eligible people to list and print

        AboveAverageHeight.AddRange(from person in People where person.Height > averageHeight select person);
        foreach (Person person in AboveAverageHeight)
        {
            Console.WriteLine($"{person.Name} ({person.Height} tall) is above average height.");
        }
        // Add above average height people to list and print

    }
}

public class Person
{
    string name;
    int age;
    double height;

    public Person(string name, int age, double height)
    {
        this.name = name;
        this.age = age;
        this.height = height;
    }

    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }
    public double Height { get => height; set => height = value; }
}