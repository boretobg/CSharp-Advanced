using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;
        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }

        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            this.data = new List<Car>();
        }

        public void Add(Car car)
        {
            if (data.Count < Capacity)
            {
                this.data.Add(car);
            }
        }
        public bool Remove(string manifacturer, string model)
        {
            Car toRemove = data.FirstOrDefault(c =>
            c.Manifacturer == manifacturer && c.Model == model);
            if (toRemove != null)
            {
                data.Remove(toRemove);
                return true;
            }
            return false;
        }
        public Car GetLatestCar()
        {
            Car newest = data.OrderByDescending(x => x.Year).FirstOrDefault();
            return newest;
            //if (data.Count == 0)
            //{
            //    return null;
            //}
            //int max = int.MinValue;
            //Car latest = new Car();
            //for (int i = 0; i < data.Count; i++)
            //{
            //    if (data[i].Year > max)
            //    {
            //        max = data[i].Year;
            //        latest = data[i];
            //    }
            //}
            //return latest;
        }
        public Car GetCar(string manifacturer, string model)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Manifacturer == manifacturer && data[i].Model == model)
                {
                    return data[i];
                }
            }
            return null;
        }
        public string GetStatistics()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"The cars are parked in {this.Type}");
            foreach (var car  in data)
            {
                result.AppendLine(car.ToString());
            }
            return result.ToString();
        }
    }
}
