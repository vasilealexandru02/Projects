using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Singleton
    {
        private static Singleton instance = null;
        public string mensaje = "";

        protected Singleton()
        {
            mensaje = "Hola mundo, este es mi primera vez utilizando singleton :)!";
        }

        public static Singleton Instance()
        {
            if (instance == null)
                instance = new Singleton();

            return instance;
        }

    }
