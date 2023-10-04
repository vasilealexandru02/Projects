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


        public Detalles Detalles { get; set; }
        public object Clone()
        {
            Animal animalClonado = this.MemberwiseClone() as Animal;
            // Se crea un nuevo objeto, al clonar el objeto ya no se hace referencia al objeto Detalles del primer objeto Animal, sino que es otro objeto a parte
            Detalles detalles = new Detalles();

            detalles.Color = Detalles.Color;
            detalles.Raza = Detalles.Raza;

            animalClonado.Detalles = detalles;

            return animalClonado;
        }


        // Clonación superficial 


    }


    public class Detalles
    {
        public string Color { get; set; }
        public string Raza { get; set; }
    }

}
