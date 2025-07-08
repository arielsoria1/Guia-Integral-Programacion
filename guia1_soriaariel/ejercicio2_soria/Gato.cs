using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_soria
{
    public class Gato : Animal
    {
        public Gato(string Nombre) : base(Nombre) { }

        public override string EmitirSonido()
        {
            return "miau!";
        }

        public override string Presentarse()
        {
            return $"Soy un gato llamado {Nombre} y hago {EmitirSonido()}";
        }
    }
}
