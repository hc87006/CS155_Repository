using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class RPSGameGenerator : GameGenerator
    {
        private string item1;
        private string item2;
        private string item3;

        public string GetItem1()
        {
            return item1;
        }
        public void SetItem1(string item1)
        {
            this.item1 = item1;
        }

        public string GetItem2()
        {
            return item2;
        }
        public void SetItem2(string item2)
        {
            this.item2 = item2;
        }

        public string GetItem3()
        {
            return item3;
        }
        public void SetItem3(string item3)
        {
            this.item3 = item3;
        }

        public override void RunCustomizationOptions()
        {
            Console.WriteLine("Simple enough, but a bit overdone.\nPick 3 new items (or don't, it's none of my business) \n(item 1, item 2, item 3)");
            string items = Console.ReadLine();

            try
            {
                string[] itemsArray = items.Split(", ");
                SetItem1(itemsArray[0]);
                SetItem2(itemsArray[1]);
                SetItem3(itemsArray[2]);
                Console.WriteLine($"You have chosen {itemsArray[0]}, {itemsArray[1]}, and {itemsArray[2]}");
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
            StreamReader part2reader = new("part2rps.txt");

            while ((line = part2reader.ReadLine()) != null)
            {
                if (line.Contains("1*"))
                {
                    line = line.Replace("1*", GetItem1().ToLower());
                }
                if (line.Contains("2*"))
                {
                    line = line.Replace("2*", GetItem2().ToLower());
                }
                if (line.Contains("3*"))
                {
                    line = line.Replace("3*", GetItem3().ToLower());
                }

                writer.WriteLine(line);
            }
            part2reader.Close();

            writer.Close();
            Console.WriteLine("Written");
        }
    }
}
