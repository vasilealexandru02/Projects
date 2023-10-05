using Strategy.Coches;

namespace Strategy
{
    public class CarContext
    {
        private ICar coche;

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

        public CarContext(ICar _coche)
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
