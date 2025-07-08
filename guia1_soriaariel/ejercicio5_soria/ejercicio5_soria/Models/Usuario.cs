using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5_soria.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Nombre} ({Email})";
        }
    }
}
