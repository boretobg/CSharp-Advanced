using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        public List<Car> Cars { get; set; }
        public int Capacity { get; set; }
        public int Count { get; set; }

        public Parking(int n)
        {
            this.Cars = new List<Car>();
            this.Capacity = n;
        }


        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            for (int i = 0; i < registrationNumbers.Count; i++)
            {
                Car temp = Cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumbers[i]);
                Cars.Remove(temp);
            }
        }

        public string GetCar(string registrationNumber)
        {
            Car temp = Cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);
            return $"Make: {temp.Make}\nModel: {temp.Model}\nHorsePower: {temp.HorsePower}\nRegistrationNumber: {temp.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            Car car = Cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);
            if (car == null)
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                Cars.Remove(car);
                this.Count--;
                return $"Successfully removed {registrationNumber}";
            }
        }
        public string AddCar(Car car)
        {
            if (this.Cars.Contains(car))
            {
                return "Car with that registration number, already exists!";
            }
            else if (Cars.Count >= this.Capacity)
            {
                return "Parking is full!";
            }
            else
            {
                this.Cars.Add(car);
                this.Count++;
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }
    }
}
