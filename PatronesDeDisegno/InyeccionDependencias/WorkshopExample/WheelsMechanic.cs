using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias.WorkshopExample
{
    public class WheelsMechanic : IMechanic
    {
        public string Name { get; set; }

        public WheelsMechanic(string name)
        {
            Name = name;
        }

        public void Work()
        {
            Console.WriteLine("Leave me alone, im fixing those wheels.");
        }
    }
}
