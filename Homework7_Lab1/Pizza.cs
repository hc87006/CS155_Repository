using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Lab1
{
    internal class Pizza
    {
        private string size;
        private int cheese;
        private int pepperoni;
        private int ham;

        public Pizza()
        {
            
        }

        public string Size { get => size; set => size = value; }
        public int Cheese { get => cheese; set => cheese = value; }
        public int Pepperoni { get => pepperoni; set => pepperoni = value; }
        public int Ham { get => ham; set => ham = value; }

        public Pizza(string _size, int _cheese, int _pepperoni, int _ham)
        {
            Size = _size;
            Cheese = _cheese;
            Pepperoni = _pepperoni;
            Ham = _ham;
        }

        public double calcCost()
        {
            double cost = 0;
            if (Size == "small")
            {
                cost = 10 + (Cheese + Pepperoni + Ham) * 2;
            }
            else if (Size == "medium")
            {
                cost = 12 + (Cheese + Pepperoni + Ham) * 2;
            }
            else if (Size == "large")
            {
                cost = 14 + (Cheese + Pepperoni + Ham) * 2;
            }

            return cost;
        }

        public string ToString()
        {
            return $"Size: {Size}\nCheese: {Cheese}\nPepperoni: {Pepperoni}\nHam: {Ham}\nCost: {calcCost()}";
        }
    }
}
