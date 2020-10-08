using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new List<Tire>();
            string input = Console.ReadLine();
            while (input != "No more tires")
            {
                double[] line = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                var temp = new List<Tire>();
                for (int i = 0; i < line.Length; i++)
                {
                    double year = line[i];
                    double pressure = line[i + 1];
                    Tire tire = new Tire(year, pressure);
                    temp.Add(tire);
                    i++;
                }
                tires.Add(temp);
                input = Console.ReadLine();
            }

            List<Engine> engines = new List<Engine>();
            input = Console.ReadLine();
            while (input != "Engines done")
            {
                double[] line = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                var engine = new Engine(line[0], line[1]);
                engines.Add(engine);
                input = Console.ReadLine();
            }
            ;

            //Show special
        }
    }
}
