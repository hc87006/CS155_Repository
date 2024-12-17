using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class TTTGameGenerator : GameGenerator
    {
        private char player1char;
        private char player2char;

        public string GetPlayer1Char()
        {
            return player1char.ToString();
        }
        public void SetPlayer1Char(char player1char)
        {
            this.player1char = player1char;
        }

        public string GetPlayer2Char()
        {
            return player2char.ToString();
        }
        public void SetPlayer2Char(char player2char)
        {
            this.player2char = player2char;
        }

        public override void RunCustomizationOptions()
        {
            Console.WriteLine("Simple enough, but X's and O's are a bit stale.\nPick 2 new characters (or don't, it's none of my business) \n(1,2)");
            string chars = Console.ReadLine();

            try
            {
                SetPlayer1Char(chars[0]);
                SetPlayer2Char(chars[2]);
                Console.WriteLine($"You have chosen {player1char} and {player2char}");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please try again.");
                RunCustomizationOptions();
            }
        }

        public override void WriteGameFile()
        {
            StreamWriter writer = new("game.cs");
            StreamReader part1reader = new("part1.txt");
            string line;
            Console.WriteLine("Writing game file...");

            while ((line = part1reader.ReadLine()) != null)
            {
                writer.WriteLine(line);
            }

            part1reader.Close();
            StreamReader part2reader = new("part2ttt.txt");

            while ((line = part2reader.ReadLine()) != null)
            {
                if (line.Contains("1*"))
                {
                    line = line.Replace("1*", GetPlayer1Char());
                }
                if (line.Contains("2*"))
                {
                    line = line.Replace("2*", GetPlayer2Char());
                }
                writer.WriteLine(line);
            }
            part2reader.Close();

            writer.Close();
            Console.WriteLine("Written");
        }
    }
}
