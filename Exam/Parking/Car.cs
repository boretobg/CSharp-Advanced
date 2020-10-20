using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Car
    {
        public string Manifacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string manifacturer, string model, int year)
        {
            this.Manifacturer = manifacturer;
            this.Model = model;
            this.Year = year;
        }
        public Car()
        {

        }
        public override string ToString()
        {
            return $"{this.Manifacturer} {this.Model} ({this.Year})";
        }
    }
}
