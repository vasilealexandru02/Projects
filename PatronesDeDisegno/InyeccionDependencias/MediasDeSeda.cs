using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias
{
    public class MediasDeSeda : IBebida
    {
        public void Preparar()
        {
            Console.WriteLine("Preparando medias de seda!");
        }
    }
}
