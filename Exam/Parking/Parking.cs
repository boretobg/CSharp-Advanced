using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Parking
{
    public class Parking
    {
        public List<Car> Cars = new List<Car>();
        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count = 0;

        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
        }

        public void Add(Car car)
        {
            if (Count < Capacity)
            {
                this.Cars.Add(car);
                this.Count++;
            }
        }
        public bool Remove(string manifacturer, string model)
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].Manifacturer == manifacturer && Cars[i].Model == model)
                {
                    Cars.RemoveAt(i);
                    this.Count--;
                    return true;
                }
            }
            return false;
        }
        public Car GetLatestCar()
        {
            if (Cars.Count == 0)
            {
                return null;
            }
            int max = int.MinValue;
            Car latest = new Car();
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].Year > max)
                {
                    max = Cars[i].Year;
                    latest = Cars[i];
                }
            }
            return latest;
        }
        public Car GetCar(string manifacturer, string model)
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].Manifacturer == manifacturer && Cars[i].Model == model)
                {
                    return Cars[i];
                }
            }
            return null;
        }
        public string GetStatistics()
        {
            string output = $"The cars are parked in {this.Type}:\n{string.Join("\n", Cars)}";
            return output;
        }
    }
}
