using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _7.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashVIP = new HashSet<string>();
            var hashRegular = new HashSet<string>();

            string input = Console.ReadLine();
            while (input != "PARTY")
            {
                if (input[0] >= 65 && input[0] <= 90 || input[0] >= 97 && input[0] <= 122)
                {
                    hashRegular.Add(input);
                }
                else
                {
                    hashVIP.Add(input);
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                if (hashVIP.Contains(input))
                {
                    hashVIP.Remove(input);
                }
                else if (hashRegular.Contains(input))
                {
                    hashRegular.Remove(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(hashVIP.Count + hashRegular.Count);
            foreach (var item in hashVIP)
            {
                Console.WriteLine(item);
            }
            foreach (var item in hashRegular)
            {
                Console.WriteLine(item);
            }
        }
    }
}
