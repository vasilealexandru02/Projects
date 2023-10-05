using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Component
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        protected Component(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
