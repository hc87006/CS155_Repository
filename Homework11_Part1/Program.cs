/// Homework No.11 Exercise No.1
/// File Name:     Program.cs 
/// @author:       Haydn Christian
/// Date:          Nov. 12, 2024
///  
/// Problem Statement: (Read a list of most popular names, output rank and namings from user inputted name) 
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Read the list of names from a file
/// 2. Split the line into name and count, use line number as rank
/// 3. Get user input for name
/// 4. If name is on either list, output rank and namings
/// 
/// Classes needed and Purpose (NameInfo, Program) 
/// main class - Program

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Dictionary<string, NameInfo> boyNames = AddNames("boynames.txt");
        Dictionary<string, NameInfo> girlNames = AddNames("girlnames.txt");

        Console.WriteLine("Enter a name");
        string name = Console.ReadLine();
        if (boyNames.ContainsKey(name))
        {
            NameInfo info = boyNames[name];
            Console.WriteLine(name + " is ranked " + info.GetRank() + " most popular boys names with " + info.GetCount() + " namings");
        }
        else if (girlNames.ContainsKey(name))
        {
            NameInfo info = girlNames[name];
            Console.WriteLine(name + " is ranked " + info.GetRank() + " most popular girls names with " + info.GetCount() + " namings");
        }
        else
        {
            Console.WriteLine("No match exists");
        }
    }

    public class NameInfo
    {
        private int rank;
        private int count;
        private string name;

        public NameInfo(int rank, int count)
        {
            this.rank = rank;
            this.count = count;
        }

        public int GetRank()
        {
            return rank;
        }

        public int GetCount()
        {
            return count;
        }
    }

    static Dictionary<string, NameInfo> AddNames(string filename)
    {
        Dictionary<string, NameInfo> names = new Dictionary<string, NameInfo>();
        StreamReader reader = new StreamReader(filename);
        string line = reader.ReadLine();
        int rank = 0;
        while (line != null)
        {
            string[] parts = line.Split(' ');
            string name = parts[0];
            rank++;
            int count = int.Parse(parts[1]);
            NameInfo info = new NameInfo(rank, count);
            names.Add(name, info);
            line = reader.ReadLine();
        }
        return names;

    }
}
