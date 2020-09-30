using System;
using System.Collections.Generic;

namespace _6.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hash = new HashSet<string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] splitted = input.Split(", ");
                if (splitted[0] == "IN")
                {
                    hash.Add(splitted[1]);
                }
                else if (splitted[0] == "OUT")
                {
                    hash.Remove(splitted[1]);
                }
                input = Console.ReadLine();
            }

            if (hash.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }
    }
}
