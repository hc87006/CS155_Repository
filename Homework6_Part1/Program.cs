using System;

namespace Homework6_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentCommand = "waiting";
            Counter counter = new Counter();
            counter.setValue(0);

            Console.WriteLine("Menu:\nIncrement\nDecrement\nEquals\nReset\nExit\n");

            while (currentCommand == "waiting")
            {
                currentCommand = Console.ReadLine();

                if (currentCommand == "Equals")
                {
                    Console.WriteLine(counter.toString());
                    currentCommand = "waiting";
                }
                
                else if (currentCommand == "Increment")
                {
                    counter.Increment();
                    currentCommand = "waiting";
                }

                else if (currentCommand == "Decrement")
                {
                    counter.Decrement();
                    currentCommand = "waiting";
                }

                else if (currentCommand == "Reset")
                {
                    counter.Reset();
                    currentCommand = "waiting";
                }

                else if (currentCommand == "Exit")
                {
                    break;
                }
            }
        }
    }
}