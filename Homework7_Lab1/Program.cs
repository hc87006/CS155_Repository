using System;

namespace Homework7_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentCommand = "waiting";

            Console.WriteLine("Commands: create, exit"); 

            while (currentCommand != "exit")
            {
                Console.WriteLine("Enter a command: ");
                currentCommand = Console.ReadLine();
                
                if (currentCommand == "create")
                {
                    Console.WriteLine("Enter the size of the pizza: (small, medium, large)");
                    string size = Console.ReadLine();
                    
                    Console.WriteLine("Enter the amount of cheese: ");
                    int cheese = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Enter the amount of pepperoni: ");
                    int pepperoni = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Enter the amount of ham: ");
                    int ham = int.Parse(Console.ReadLine());
                    
                    Pizza pizza = new Pizza(size, cheese, pepperoni, ham);
                    Console.WriteLine(pizza.ToString());
                }
                else if (currentCommand == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command");
                }
            }
        }
    }
}