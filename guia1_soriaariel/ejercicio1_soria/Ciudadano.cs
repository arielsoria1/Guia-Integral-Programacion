using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_soria
{
    public class Ciudadano
    {
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public int Edad { get; set; }

        public Ciudadano(string nombreCompleto, string dni, int edad)
        {
            this.NombreCompleto = nombreCompleto;
            this.DNI = dni;
            this.Edad = edad;
        }

            public string Saludar()
        {
            return $"Hola, me llamo {NombreCompleto} y tengo {Edad} años.";
        }

        public bool TieneEdadValida()
        {
            return Edad > 0;
        }

        public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }
    }
}
