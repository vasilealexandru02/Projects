using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Coches
{
    public class AstonMartinVanquish : ICar
    {
        public void Motor()
        {
            Console.WriteLine("I'm an Aston Martin and I have a 6000cc engine");
        }
    }
}
