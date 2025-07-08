using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_soria
{
    public class Perro : Animal
    {
        public Perro(string Nombre) : base(Nombre) { }

        public override string EmitirSonido()
        {
            return "guau!";
        }

        public override string Presentarse()
        {
            return $"Soy un perro llamado {Nombre} y hago {EmitirSonido()}";
        }
    }
}
