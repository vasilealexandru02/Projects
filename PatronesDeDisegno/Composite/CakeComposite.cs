using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class CakeComposite : Component
    {
       
        private List<Component> ingredients = new List<Component>();



        public void Add(Component ingredient)
        {
            if (!ingredients.Contains(ingredient))
            {
                Price += ingredient.Price;
            }
            
            ingredients.Add(ingredient);

        }

        public void Remove(Component ingredient)
        {
            Price -= ingredient.Price;
            ingredients.Remove(ingredient);
        }

        public CakeComposite(string name, decimal price = 0) : base(name, price)
        {

        }
    }
}
