using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main()
        {
            try
            {
                StreamReader reader = new ("game.cs");
                reader.Close();
                Console.WriteLine("Attempting to verify game files...");
                Console.WriteLine("game.cs has been found.");
                Console.WriteLine("game.cs appears to be valid.\n");
                Console.WriteLine("Welcome back!\n");
                Console.WriteLine("Would you like to create a new game?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No\n");

                string command = "";

                while (command != "1" && command != "2")
                {
                    command = Console.ReadLine();

                    if (command == "1")
                    {
                        Console.WriteLine("\nChoose a game type:");
                        Console.WriteLine("1. Rock, Paper, Scissors");
                        Console.WriteLine("2. Tic Tac Toe\n");
                        GameChoice();
                    }
                    else if (command == "2")
                    {
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                        command = "";
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Attempting to verify game files...");
                Console.WriteLine("game.cs appears to be empty\n");
                Console.WriteLine("Let's fix that!");

                Console.WriteLine("Choose a game type:");
                Console.WriteLine("1. Rock, Paper, Scissors");
                Console.WriteLine("2. Tic Tac Toe\n");
                GameChoice();
            }
        }
        
        public static void GameChoice()
        {
            string command = "";
            string gameChoice;

            while (command != "1" && command != "2")
            {
                command = Console.ReadLine();

                if (command == "1" || command == "2")
                {
                    gameChoice = command;

                    switch (gameChoice)
                    {
                        case "1":
                            RPSGameGenerator rpsGame = new();
                            rpsGame.RunCustomizationOptions();
                            rpsGame.WriteGameFile();
                            break;
                        case "2":
                            TTTGameGenerator tttGame = new();
                            tttGame.RunCustomizationOptions();
                            tttGame.WriteGameFile();
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}