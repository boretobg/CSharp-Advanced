using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Car>();

                string input = string.Empty;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] splitted = input.Split();
                string model = splitted[0];
                double fuelAmmount = double.Parse(splitted[1]);
                double fuelConsumption = double.Parse(splitted[2]);

                Car car = new Car(model, fuelAmmount, fuelConsumption);
                list.Add(car);
            }

            input = Console.ReadLine();
            while (input != "End")
            {
                string[] splitted = input.Split();
                string carModel = splitted[0];
                double fuelConsumption = double.Parse(splitted[1]);

                
                input = Console.ReadLine();
            }
        }
    }
}
