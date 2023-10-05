using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Coches
{
    public class NissanSkyline : ICar
    {
        public void Motor()
        {
            Console.WriteLine("I'm a Nissan Skyline and I have a 1200HP engine!");
        }
    }
}
