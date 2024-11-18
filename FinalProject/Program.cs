using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        char[] sqr = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        string command = "waiting";

        Console.WriteLine(command);

        Console.WriteLine("Tic Tac Toe");

        Player1Turn(sqr, command);

    }

    static void Player1Turn(char[] sqr, string command)
    {
        Console.WriteLine("Player 1 (X) Turn");
        Console.WriteLine("Enter a number between 1-9");
        DrawBoard(sqr);
        // DoTurn(sqr, command);
    }

    static void Player2Turn(char[] sqr, string command)
    {
        Console.WriteLine("Player 2 (O) Turn");
        Console.WriteLine("Enter a number between 1-9");
        DrawBoard(sqr);
        DoTurn(sqr, command);
    }

    public static void DoTurn(char[] sqr, string command)
    {
        command = "waiting";

        Console.WriteLine (selectedSqr());

        int selectedSqr()
        {
            while (command != "waiting")
            {
                command = Console.ReadLine();

                Console.WriteLine("Line read");

                if (int.Parse(command) >= 1 && int.Parse(command) <= 9)
                {
                    return int.Parse(command);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1-9");
                    return 0;
                }
            }
            return 0;
        }
    }

    static void DrawBoard(char[] sqr)
    {
        string divider = "---+---+---";
        Console.WriteLine($" {sqr[0]} | {sqr[1]} | {sqr[2]}\n{divider}\n {sqr[3]} | {sqr[4]} | {sqr[5]}\n{divider}\n {sqr[6]} | {sqr[7]} | {sqr[8]}\n");
    }
}