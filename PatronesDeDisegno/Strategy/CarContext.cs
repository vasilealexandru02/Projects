using Strategy.Coches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CarContext
    {
        private ICoche coche;

        public enum TiposCoche
        {
            NissanSkyline,
            LamborghiniAventador,
            AstonMartinVanquish
        }
        public CarContext()
        {
            coche = new NissanSkyline();
        }

        /// <summary>
        /// En este constructor se crea el tipo de estrategia.
        /// </summary>
        /// <param name="tipoDeCoche"></param>
        public CarContext(TiposCoche tipoDeCoche)
        {
            switch (tipoDeCoche)
            {
                case TiposCoche.NissanSkyline:
                    coche = new NissanSkyline();
                    break;

                case TiposCoche.LamborghiniAventador:
                    coche = new LamborghiniAventador();
                    break;
                case TiposCoche.AstonMartinVanquish:
                    coche = new AstonMartinVanquish();
                    break;

                default: break;
            }
        }

        public CarContext(ICoche _coche)
        {
            coche = _coche;
        }
        public void Motor()
        {
            coche.Motor();
        }

        public void UseLamborghiniAventador()
        {
            coche = new LamborghiniAventador();
        }

        public void UseNissanSkyline()
        {
            coche = new NissanSkyline();
        }

        public void UseAstonMartinVanquish()
        {
            coche = new AstonMartinVanquish();
        }

        public void ChooseRandomCar(Enum tipoDeCoche)
        {

        }


    }
}
