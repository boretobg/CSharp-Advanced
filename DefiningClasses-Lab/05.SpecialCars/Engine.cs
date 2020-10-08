using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        public double HorsePower { get; set; }
        public double CubicCapacity { get; set; }

        public Engine(double horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }
    }
}
