using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamarin.Models
{
    public class Mockup
    {
        // Campos privados
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;

        // Propiedades públicas

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _nombre = value;
                }
                else
                {
                    throw new ArgumentException("El nombre no puede estar vacío o ser null.");
                }
            }
        }

        public string Apellido
        {
            get { return _apellido; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _apellido = value;
                }
                else
                {
                    throw new ArgumentException("El apellido no puede estar vacío o ser null.");
                }
            }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set
            {
                if (value <= DateTime.Today)
                {
                    _fechaNacimiento = value;
                }
                else
                {
                    throw new ArgumentException("La fecha de nacimiento no puede ser una fecha futura.");
                }
            }
        }

        // Propiedad de solo lectura para calcular la edad
        public int Edad
        {
            get
            {
                int edad = DateTime.Today.Year - _fechaNacimiento.Year;

                if (_fechaNacimiento.Date > DateTime.Today.AddYears(-edad))
                {
                    edad--;
                }

                return edad;
            }
        }

    }
}
