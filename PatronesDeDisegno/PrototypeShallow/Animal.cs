using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeShallow
{
    public class Animal : ICloneable
    {
        public int Patas { get; set; }

        public string Nombre { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }


        // Clonación superficial 


    }
}
