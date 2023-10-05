using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Coches
{
    public class LamborghiniAventador : ICar
    {
        public void Motor()
        {
            Console.WriteLine("I'm an Aventador and I have a mad V12 engine!");
        }
    }
}
