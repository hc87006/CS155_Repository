using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Part1
{
    public class Person
    {
        private string name;

        public Person()
        {
            name = "";
        }

        public Person(string name)
        {
            this.name = name;
        }

        public Person(Person obj)
        {
            name = obj.name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string ToString()
        {
            return $"Name: {name}";
        }

        public bool Equals(Object obj)
        {
            return name == ((Person)obj).name;
        }
    }

    public class Vehichle
    {
        protected string eNum;
        protected int cylinders;
        protected Person owner;

        public Vehichle()
        {
            eNum = "";
            cylinders = 0;
            owner = new Person();
        }

        public string GetENum()
        {
            return eNum;
        }

        public void SetENum(string eNum)
        {
            this.eNum = eNum;
        }

        public int GetCylinders()
        {
            return cylinders;
        }

        public void SetCylinders(int cylinders)
        {
            this.cylinders = cylinders;
        }

        public string GetOwner()
        {
            return owner.GetName();
        }

        public void SetOwner(string name)
        {
            this.owner.SetName(name);
        }

        public string ToString()
        {
            return $"eNum: {eNum}, Cylinders: {cylinders}, Owner: {GetOwner()}";
        }
    }

    public class Truck : Vehichle
    {
        private double loadCapacity;
        private int towCapacity;

        public Truck()
        {
            loadCapacity = 0;
            towCapacity = 0;
        }

        public Truck(string eNum, int cylinders, Person owner, double loadCapacity, int towCapacity) : base()
        {
            this.eNum = eNum;
            this.cylinders = cylinders;
            this.owner = owner;
            this.loadCapacity = loadCapacity;
            this.towCapacity = towCapacity;
        }

        public double GetLoadCapacity()
        {
            return loadCapacity;
        }

        public void SetLoadCapacity(double loadCapacity)
        {
            this.loadCapacity = loadCapacity;
        }

        public int GetTowCapacity()
        {
            return towCapacity;
        }

        public void SetTowCapacity(int towCapacity)
        {
            this.towCapacity = towCapacity;
        }

        public string ToString()
        {
            return $"eNum: {eNum}, Cylinders: {cylinders}, Owner {GetOwner()}, Load Capacity: {loadCapacity}, Tow Capacity: {towCapacity}";
        }
    }
}