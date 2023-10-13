using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias.WorkshopExample
{
    public class Workshop
    {
        private IMechanic mechanic;

        public Workshop(IMechanic _mechanic)
        {
            mechanic = _mechanic;

        }

        public void Work()
        {
            mechanic.Work();
        }

    }
}
