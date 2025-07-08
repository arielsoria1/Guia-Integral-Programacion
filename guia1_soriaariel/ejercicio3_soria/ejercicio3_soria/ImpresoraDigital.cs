using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3_soria
{
    public class ImpresoraDigital : IImprimible
    {
        public void Imprimir(string contenido)
        {
            Console.WriteLine("Impresión digital:");
            Console.WriteLine(contenido);
        }
    }

}
