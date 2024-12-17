/// Homework No.8  Exercise No.1
/// File Name:     Program.cs 
/// @author:       Haydn Christian
/// Date:          Oct. 22, 2024
///  
/// Problem Statement: Simulate a duel between 3 duelists, each with a different probability of hitting their target
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Create 3 duelists with different accuracy values
/// 2. Start a duel between the 3 duelists and record who wins
/// 3. Repeat 10000 times and get average wins
/// 
/// Classes needed and Purpose (Program, Game) 
/// main class -  Game
namespace Homework8_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int duelist1Wins = 0;
            int duelist2Wins = 0;
            int duelist3Wins = 0;
            // initialize wins

            string mode = "";
            // string to get mode

            Console.WriteLine("Choose a mode: Normal or Alternate");

            while (mode != "Normal" && mode != "Alternate")
            {
                mode = Console.ReadLine();

                if (mode == "Normal")
                {
                    mode = "Normal";
                }
                else if (mode == "Alternate")
                {
                    mode = "Alternate";
                }
                else
                {
                    Console.WriteLine("Invalid mode, please try again");
                }
            }
            // set mode to mode string

            for (int i = 0; i < 10000; i++)
            // loop 10000 times
            {
                Console.Write($"\n{i + 1}\n");
                // write round number
                Duelist duelist1 = new Duelist("Aaron", 66, true, false);
                Duelist duelist2 = new Duelist("Bob", 100, true, false);
                Duelist duelist3 = new Duelist("Charlie", 199, true, false);
                // initialize duelists

                string turn = "duelist1";
                // string to keep track of turns, initialize first turn to duelist1
                bool turn1completed = false;
                // bool to keep track of if duelist1 has completed their first turn (for alternate mode)

                while (!(duelist1.GetIsWinner()) && (!(duelist2.GetIsWinner()) && !(duelist3.GetIsWinner())))
                {
                    if (turn == "duelist1")
                    // if it is duelist1's turn
                    {
                        if (mode == "Alternate" && turn1completed == false)
                        // if alternate mode and duelist1 has not completed their first turn
                        {
                            Console.WriteLine("Duelist 1 is skipping their turn");
                            turn1completed = true;
                            turn = "duelist2";
                            // skip turn
                        }

                        else if (duelist1.GetIsAlive())
                        // check if duelist1 is alive, else skip turn
                        {
                            if (duelist3.GetIsAlive())
                            // if duelist3 is alive (who has highest priority), shoot at duelist3
                            {
                                Console.Write(duelist1.GetName() + " shot at " + duelist3.GetName());
                                duelist1.ShootAt(duelist3);
                                turn = "duelist2";
                            }
                            else if (duelist2.GetIsAlive())
                            // if duelist3 is dead and duelist2 is alive, shoot at duelist2
                            {
                                Console.Write(duelist1.GetName() + " shot at " + duelist2.GetName());
                                duelist1.ShootAt(duelist2);
                                turn = "duelist2";
                            }
                            else
                            // if duelist3 and duelist2 are dead, duelist1 wins
                            {
                                duelist1.SetIsWinner(true);
                            }
                        }
                        else
                        // if duelist1 is dead, skip turn
                        {
                            turn = "duelist2";
                        }
                    }

                    else if (turn == "duelist2")
                    {
                        if (duelist2.GetIsAlive())
                        {
                            if (duelist3.GetIsAlive())
                            {
                                Console.Write(duelist2.GetName() + " shot at " + duelist3.GetName());
                                duelist2.ShootAt(duelist3);
                                turn = "duelist3";
                            }
                            else if (duelist1.GetIsAlive())
                            {
                                Console.Write(duelist2.GetName() + " shot at " + duelist1.GetName());
                                duelist2.ShootAt(duelist1);
                                turn = "duelist3";
                            }
                            else
                            {
                                duelist2.SetIsWinner(true);
                            }
                        }
                        else
                        {
                            turn = "duelist3";
                        }
                    }

                    else if (turn == "duelist3")
                    {
                        if (duelist3.GetIsAlive())
                        {
                            if (duelist2.GetIsAlive())
                            {
                                Console.Write(duelist3.GetName() + " shot at " + duelist2.GetName());
                                duelist3.ShootAt(duelist2);
                                turn = "duelist1";
                            }
                            else if (duelist1.GetIsAlive())
                            {
                                Console.Write(duelist3.GetName() + " shot at " + duelist1.GetName());
                                duelist3.ShootAt(duelist1);
                                turn = "duelist1";
                            }
                            else
                            {
                                duelist3.SetIsWinner(true);
                            }
                        }
                        else
                        {
                            turn = "duelist1";
                        }
                    }
                }

                if (duelist1.GetIsWinner())
                {
                    Console.Write(duelist1.GetName() + " is the winner!");
                    duelist1Wins++;
                }
                else if (duelist2.GetIsWinner())
                {
                    Console.Write(duelist2.GetName() + " is the winner!");
                    duelist2Wins++;
                }
                else if (duelist3.GetIsWinner())
                {
                    Console.Write(duelist3.GetName() + " is the winner!");
                    duelist3Wins++;
                }
                // check who won and increment wins
            }

            Console.WriteLine($"\nDuelist 1 won {duelist1Wins} times, or {duelist1Wins / 100}% of the time\nDuelist 2 won {duelist2Wins} times, or {duelist2Wins / 100}% of the time\nDuelist 3 won {duelist3Wins} times, or {duelist3Wins / 100}% of the time");
            // print wins and win percentage
        }
    }
}