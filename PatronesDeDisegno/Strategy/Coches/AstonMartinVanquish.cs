using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Coches
{
    public class AstonMartinVanquish : ICoche
    {
        public void Motor()
        {
            Console.WriteLine("Soy un Aston Martin Vanquish y tengo un motor de 6000cc");
        }
    }
}
