using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public static class Creador
    {

        public const int NISSAN_GTR = 1;

        public const int HYUNDAII30N = 2;

        public static Coche CrearCoche(int tipo)
        {
            switch (tipo)
            {
                case NISSAN_GTR:
                    return new NissanGTR();
                case HYUNDAII30N:
                    return new HyundaiI30N();
                default:
                    return null;

            }
        }

        public static NissanGTR createNissan()
        {
            return new NissanGTR();
        }

        public static HyundaiI30N createHyundai()
        {
            return new HyundaiI30N();
        }

    }
}
