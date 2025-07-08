using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3_soria
{
    using System.IO;

    public class FacturaSaver
    {
        public void GuardarEnArchivo(string contenido, string ruta)
        {
            File.WriteAllText(ruta, contenido);
        }
    }

}
