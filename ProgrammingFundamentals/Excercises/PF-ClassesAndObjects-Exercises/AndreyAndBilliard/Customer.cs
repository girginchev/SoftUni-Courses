using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    public class Customer
    {
        public string Name { get; set; }

        public string Product { get; set; }

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal Bill() => Quantity * Price;
    }
}
