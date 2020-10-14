using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class Days
    {
        public DateTime First { get; set; }
        public DateTime Second { get; set; }

        public double DaysBetween(string first, string second)
        {
            DateTime firstDate = DateTime.Parse(first);
            DateTime secondDate = DateTime.Parse(second);
            
            return Math.Abs((firstDate - secondDate).TotalDays);
        }
        public Days()
        {
            this.First = new DateTime();
            this.Second = new DateTime();
        }
    }
}
