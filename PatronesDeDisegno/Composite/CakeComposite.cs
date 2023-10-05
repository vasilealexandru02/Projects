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
        //public decimal TotalPrice
        //{

        //    get
        //    {
        //        decimal price = 0;
        //        foreach (var ingredient in ingredients)
        //        {
        //            if (ingredient.GetType() == this.GetType())
        //            {
        //                price += ((CakeComposite)ingredient).TotalPrice;
        //            }
        //            else
        //            {
        //                price += ingredient.Price;
        //            }

        //        }
        //        return price;
        //    }
        //}
        private List<Component> ingredients = new List<Component>();


        public void Add(Component ingredient)
        {
            ingredients.Add(ingredient);
        }


        public void Remove(Component ingredient)
        {
            ingredients.Remove(ingredient);
        }
        public void CalculatePrice()
        {
            foreach (var ingredient in ingredients)
            {
                Price += ingredient.Price;
            }
        }


        public CakeComposite(string name, decimal price = 0) : base(name, price)
        {

        }
    }
}
