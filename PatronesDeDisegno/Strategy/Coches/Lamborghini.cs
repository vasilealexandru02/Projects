using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Coches
{
    public class LamborghiniAventador : ICoche
    {
        public void Motor()
        {
            Console.WriteLine("Soy un Lamborghini Aventador y tengo un motor V12 con muy mala leche ");
        }
    }
}
