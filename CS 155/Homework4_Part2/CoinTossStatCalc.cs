/// Homework No.4  Exercise No.2
/// File Name:     CoinTossStatCalc.cs 
/// @author:       Haydn Christian
/// Date:          Sep. 17, 2024
///  
/// Problem Statement: Calculate the statistics of a certain number of coins being heads or tails 
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. during loop, increment h/t int when inputted
/// 2. break loop with d
/// 3. calculate stats and diplay them if d is entered
/// 
/// Classes needed and Purpose coinStatCalc
/// main class - coinStatCalc  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework4_Part2
{
    class coinStatCalc
    {
        static void Main(string[] args)
        {
            double h, t, flips;
            /// create doubles h (heads), t (tails), flips (total flips)   (used double instead of int so i wouldnt have to convert it later for calculating the statistics)
            h = 0;
            t = 0;
            flips = 0;
            /// assign default values

            string current;
            /// create current string to store currently inputted value later

            Console.WriteLine("For each coin toss, enter h or f then enter");

            while (flips < 8)
            /// loop while there are less than 8 flips
            {
                current = Console.ReadLine();
                /// assign inputted value (h/t) to current
                if (current == "h")
                {
                    h++;
                    flips++;
                }
                ///increment h and flips by 1

                else if (current == "t")
                {
                    t++;
                    flips++;
                }
                /// increment t and flips by 1

                else

                {
                    Console.WriteLine("Plese enter either h or t");
                }
                /// prompt user to imput an applicable value

                Console.WriteLine(h + " heads, " + t + " tails, " + flips + " total");
                /// show current amount of heads, tails, and flips

            }

            Console.WriteLine(Math.Round((((h / flips) * 100)), 2) + " percent heads, " + Math.Round(((t / flips) * 100), 2) + " percent tails");
            /// on loop completion, display statistics
            Console.ReadLine();
        }
    }
}