using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount {get;set;}
        public double FuelConsumptionPerKilometer { get;set;}
        public double TravelledDistance { get; set; }

        public bool Capable(List<Car> car)
        {

            return true;
        }
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;
        }
        public Car()
        {

        }
    }
}
