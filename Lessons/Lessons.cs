using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lessons
{
    public class Item
    {
        public Item(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        public void IncreasePriceBy(double Percent)
        {
            Price += Price * Percent / 100;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }
}
