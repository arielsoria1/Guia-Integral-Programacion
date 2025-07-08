using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3_soria
{
    public class FacturaPrinter
    {
        private readonly IImprimible _impresora;

        public FacturaPrinter(IImprimible impresora)
        {
            _impresora = impresora;
        }

        public void Imprimir(string contenido)
        {
            _impresora.Imprimir(contenido);
        }
    }

}
