using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        { }
        public string Year { get; set; } = "1999";
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Bronco";
        public abstract void DriveAbstract();
        public virtual void DriveVirtual() { Console.WriteLine("WOW that's  a fast motercycle"); }

        //public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
 }               
   


             