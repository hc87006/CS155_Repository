using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Part1
{
    internal class Odometer
    {
        private int miles;
        private double fuelUsed;

        public Odometer()
        {
            
        }

        public Odometer(int _miles, double _fuelUsed)
        {
            Miles = _miles;
            FuelUsed = _fuelUsed;
        }

        public int Miles { get => miles; set => miles = value; }
        public double FuelUsed { get => fuelUsed; set => fuelUsed = value; }

        public void Reset()
        {
            Miles = 0;
            FuelUsed = 0;
        }

        public void Add(int m, double f)
        {
            Miles += m;
            FuelUsed += f;
        }
        
        public double MPG()
        {
            return Miles / FuelUsed;
        }

        public string ToString()
        {
            return $"Miles: {Miles}\nFuel Used: {FuelUsed}";
        }

    }
}
