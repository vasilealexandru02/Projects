using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Ingredient : Component
    {

        public int Quantity { get; set; }

        public string Unit { get; set; }
        public Ingredient(string name, decimal price, int _quantity, string _unit) : base(name, price)
        {
            Quantity = _quantity;
            Unit = _unit;
        }
    }
}
