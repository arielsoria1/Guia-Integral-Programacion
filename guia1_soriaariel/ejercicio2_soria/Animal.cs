using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_soria
{
    public class Animal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            this.Nombre = nombre;
        }

        public virtual string EmitirSonido()
        {
            return "Sonido no identificado";
        }

        public virtual string Presentarse()
        {
            return "Nombre no identificado";
        }
    }
}
