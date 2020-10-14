using System;
using System.Runtime.InteropServices;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            Days days = new Days();
            Console.WriteLine(days.DaysBetween(firstDate, secondDate));
        }
    }
}
