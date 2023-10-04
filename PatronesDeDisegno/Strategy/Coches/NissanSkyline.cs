using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Coches
{
    public class NissanSkyline : ICoche
    {
        public void Motor()
        {
            Console.WriteLine("Soy un Nissan Skyline y tengo un motor de  1200CV");
        }
    }
}
