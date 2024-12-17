/// Homework No.10 Exercise No.2 
/// File Name:     Program.cs 
/// @author:       Haydn Christian
/// Date:          Nov. 11, 2024
///  
/// Problem Statement: (Store contact information with the ability to search) 
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Create a dictionary to store contacts
/// 2. Create a Contact class to store contact information
/// 3. Add a method to search for a contact in the dictionary
/// 
/// Classes needed and Purpose (Program, Contact) 
/// main class - Program 


using System;
using System.Collections.Generic;

namespace Homework10_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Contact> phonebook = new Dictionary<string, Contact>();
            Contact contact1 = new Contact("John Doe", "123-456-7890");
            Contact contact2 = new Contact("Jane Doe", "098-765-4321");
            // Create dictionary and contacts

            phonebook.Add(contact1.GetName(), contact1);
            phonebook.Add(contact2.GetName(), contact2);
            // Add contacts to dictionary

            Search.SearchContact(phonebook, "John Doe");
            Search.SearchContact(phonebook, "Jane Doe");
            // Search for contacts

            phonebook.Remove("John Doe");
            // Remove contact

            Search.SearchContact(phonebook, "John Doe");
            Search.SearchContact(phonebook, "Jane Doe");
            // Search again

        }
    }

    class Contact
    {
        private string name;
        private string number;

        public Contact(string name, string number) : this()
        {
            this.name = name;
            this.number = number;
        }

        public Contact()
        {

        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetNumber()
        {
            return number;
        }
        public void SetNumber(string number)
        {
            this.number = number;
        }

        public string ToString()
        {
            return name + ", " + number;
        }
    }

    class Search
    {
        public static void SearchContact(Dictionary<string, Contact> phonebook, string name)
        {
            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine(phonebook[name].ToString());
            }
            else
            {
                Console.WriteLine("Contact not found");
            }

            // If the contact is in the dictionary, print the contact, else print "Contact not found"
        }
    }

    // Search class to search for contacts in the dictionary
}
