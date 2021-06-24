﻿using System;
namespace InheritanceExamples
{
    public class Automobile
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfSeats { get; set; }
        public int NumberOfDoors { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Automobile(int numberOfWheels, int numberOfSeats)
        {
            NumberOfWheels = numberOfWheels;
            NumberOfSeats = numberOfSeats;
        }

        public Automobile()
        {

        }

        public virtual void Drive()
        {
            Console.WriteLine($"I can drive I am an Automobile {Model} : {Year}");
        }
    }
}
