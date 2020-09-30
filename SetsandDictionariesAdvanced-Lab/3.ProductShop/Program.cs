using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var stores = new Dictionary<string, Dictionary<string, double>>();
            string input = Console.ReadLine();
            while (input != "Revision")
            {
                string[] splitted = input.Split(", ");
                string store = splitted[0];
                string product = splitted[1];
                double price = double.Parse(splitted[2]);
                if (!stores.ContainsKey(store))
                {
                    stores.Add(store, new Dictionary<string, double>());
                }
                stores[store].Add(product, price);
                input = Console.ReadLine();
            }

            var orderedShops = stores.OrderBy(s => s.Key).ToDictionary(x => x.Key, x => x.Value).ToList();
            int count = 0;
            foreach (var store in orderedShops)
            {
                Console.WriteLine($"{store.Key}->");
                foreach (var item in orderedShops[count].Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
                count++;
            }
        }
    }
}
