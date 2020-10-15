using System;

namespace ThreeUple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string fullName = $"{input[0]} {input[1]}";
            string address = input[2];
            string city = $"{input[3]} {input[4]}";
            var item1 = new Tuple<string, string, string>(fullName, address, city);

            input = Console.ReadLine().Split();
            string name = input[0];
            int liters = int.Parse(input[1]);
            var drunkOrNot = input[2] == "drunk" ? true : false;
            var item2 = new Tuple<string, int, bool>(name, liters, drunkOrNot);

            input = Console.ReadLine().Split();
            string name2 = input[0];
            double balance = double.Parse(input[1]);
            string bankName = input[2];
            var item3 = new Tuple<string, double, string>(name2, balance, bankName);

            Console.WriteLine($"{item1.Item1} -> {item1.Item2} -> {item1.Item3}\n" +
                $"{item2.Item1} -> {item2.Item2} -> {item2.Item3}\n" +
                $"{item3.Item1} -> {item3.Item2} -> {item3.Item3}");
        }
    }
}
