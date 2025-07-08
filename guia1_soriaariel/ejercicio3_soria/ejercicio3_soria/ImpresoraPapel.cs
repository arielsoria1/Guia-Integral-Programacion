using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3_soria
{
    public class ImpresoraPapel : IImprimible
    {
        public void Imprimir(string contenido)
        {
            Console.WriteLine("Impresión en papel (simulada):");
            Console.WriteLine(contenido);
        }
    }

}
