using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias
{
    public class Cantinero
    {
        IBebida bebida;
        public Cantinero(IBebida _bebida)
        {
            bebida = _bebida;
        }
        public void Preparar()
        {
            bebida.Preparar();
        }
    }
}
