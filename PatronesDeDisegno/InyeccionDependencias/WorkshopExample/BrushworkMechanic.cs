using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias.WorkshopExample
{
    public class BrushworkMechanic : IMechanic
    {
        public string Name { get; set; }

        public BrushworkMechanic(string name)
        {
            Name = name;
        }

        public void Work()
        {
            Console.WriteLine("Hi! My name is" + Name + " and I'm in paiting your car!");
        }
    }
}
